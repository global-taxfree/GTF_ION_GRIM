using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing;
using System.Resources;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;
using System.IO;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using GTF_GRIM_SG.Properties;
using GTF_Printer;
using GTF_STFM.Util;

namespace GTF_GRIM_SG.Util
{
    class WindowPrinterUtil
    {
        StringFormat strFormat = new StringFormat();
        Font strFont = new Font("Arial", 10);
        private const int nPageWidth = 276;

        private EncodingOptions EncodingOptions { get; set; }
        private Type Renderer { get; set; }

        private Dictionary<string, string> m_ListDocId;
        private Dictionary<string, string> m_ListRetailer;
        private Dictionary<string, string> m_ListTourist;
        private Dictionary<string, object> m_ListPurchase;

        public int PrintTicket(string retailer, string docid, string tourist, string purchase)
        {
            int nRet = 0;

            Renderer = typeof(BitmapRenderer);

            try
            {
                ParseParameter(retailer, docid, tourist, purchase);

                UserPrintDocument printDoc = new UserPrintDocument();
                printDoc.UserPrintPageEvent += new UserPrintDocument.UserPrintPageEventHandler(PrintSlip);
                printDoc.Print();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nRet = -1;
            }
            return nRet;
        }

        public void ParseParameter(string retailer, string docid, string tourist, string purchase)
        {
            m_ListRetailer = new Dictionary<string, string>();
            m_ListDocId = new Dictionary<string, string>();
            m_ListTourist = new Dictionary<string, string>();
            m_ListPurchase = new Dictionary<string, object>();

            //Retailer
            ParseRetailer(retailer);

            ParseDocId(docid);

            ParseTourist(tourist);

            ParsePurchase(purchase);
        }

        public void ParseRetailer(string retailer)
        {
            string[] arrRetailer = retailer.Split('|');
            m_ListRetailer.Add(Properties.Resource_MapKey.RetailerName, arrRetailer[0]);
            m_ListRetailer.Add(Properties.Resource_MapKey.BizNo, arrRetailer[1]);
        }

        public void ParseDocId(string docid)
        {
            string[] arrDocId = docid.Split('|');
            m_ListDocId.Add(Properties.Resource_MapKey.DocId, arrDocId[0]);
            m_ListDocId.Add(Properties.Resource_MapKey.DateOfIssue, arrDocId[1]);
        }

        public void ParseTourist(string tourist)
        {
            string[] arrTourist = tourist.Split('|');
            m_ListTourist.Add(Properties.Resource_MapKey.PassportNumber, arrTourist[0]);
            m_ListTourist.Add(Properties.Resource_MapKey.Nationality, arrTourist[1]);
        }

        public void ParsePurchase(string purchase)
        {
            string[] arrPurchase = purchase.Split('|');
            m_ListPurchase.Add(Properties.Resource_MapKey.PurchaseTotalCnt, arrPurchase[0]);

            int nOffset = 1;
            for (int i = 0; i < Convert.ToInt32(m_ListPurchase[Properties.Resource_MapKey.PurchaseTotalCnt]); i++)
            {
                Dictionary<string, string> ItemData = new Dictionary<string, string>();
                ItemData.Add(String.Format("{0}_{1}", Properties.Resource_MapKey.PurchaseSeq, i), arrPurchase[nOffset++]);
                ItemData.Add(Properties.Resource_MapKey.DateOfSales, arrPurchase[nOffset++]);
                ItemData.Add(Properties.Resource_MapKey.SaleAmount, arrPurchase[nOffset++]);
                ItemData.Add(Properties.Resource_MapKey.ReceiptNo, arrPurchase[nOffset++]);

                m_ListPurchase.Add(String.Format("{0}_{1}", Properties.Resource_MapKey.PurchaseSeq, i), ItemData);
            }

            m_ListPurchase.Add(Properties.Resource_MapKey.TotalSaleAmount, arrPurchase[nOffset++]);
            m_ListPurchase.Add(Properties.Resource_MapKey.TotalTaxAmount, arrPurchase[nOffset++]);
            m_ListPurchase.Add(Properties.Resource_MapKey.TotalCharge, arrPurchase[nOffset++]);
            m_ListPurchase.Add(Properties.Resource_MapKey.TotalRefundAmount, arrPurchase[nOffset++]);
        }

        public void PrintSlip(object sender, PrintPageEventArgs e)
        {
            float yPos = 0;

            PrintHeader(e, ref yPos);

            PrintCentralRefundAgency(e, ref yPos);

            PrintRetailerDetails(e, ref yPos);

            PrintDocID(e, ref yPos);

            PrintTouristPassport(e, ref yPos);

            PrintPurchase(e, ref yPos);

            PrintIdentifier(e, ref yPos);

            PrintInformation(e, ref yPos);

            PrintFooter(e, ref yPos);
        }

        public void PrintHeader(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                // Print Logo
                ResourceManager rm = GTF_GRIM_SG.Properties.Resources.ResourceManager;
                Bitmap head_logo = (Bitmap)rm.GetObject("GTFHEAD");

                e.Graphics.DrawImage((Image)head_logo, new Rectangle(0, (int)yPos, head_logo.Width, head_logo.Height));
                yPos += head_logo.Height;

                strFont = new Font("Arial", 10, FontStyle.Bold);
                strFormat.LineAlignment = StringAlignment.Center;
                strFormat.Alignment = StringAlignment.Center;

                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height * 2);
                e.Graphics.DrawString(Properties.Resource_Print.HeaderDesc, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height * 2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PrintCentralRefundAgency(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                strFont = new Font("Arial", 10);
                strFormat.Alignment = StringAlignment.Near;
                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.FillRectangle(Brushes.Black, rect);
                e.Graphics.DrawString(Properties.Resource_Print.Title_CentralRefundAgency, strFont, Brushes.White, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                yPos += strFont.Height;

                strFormat.Alignment = StringAlignment.Center;
                rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height * 5);
                e.Graphics.DrawString(Properties.Resource_Print.CentralRefundAgency, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height * 6;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PrintRetailerDetails(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                strFont = new Font("Arial", 10);
                strFormat.Alignment = StringAlignment.Near;
                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.FillRectangle(Brushes.Black, rect);
                e.Graphics.DrawString(Properties.Resource_Print.Title_RetailerDetails, strFont, Brushes.White, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                yPos += strFont.Height;

                rect = new Rectangle(0, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.RetailerName, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(nPageWidth / 2, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(m_ListRetailer[Properties.Resource_MapKey.RetailerName], strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                yPos += strFont.Height;

                strFormat.Alignment = StringAlignment.Near;
                rect = new Rectangle(0, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.GSTRegNo, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(nPageWidth / 2, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(m_ListRetailer[Properties.Resource_MapKey.BizNo], strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                yPos += strFont.Height * 2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PrintDocID(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                strFont = new Font("Arial", 10);
                strFormat.Alignment = StringAlignment.Near;
                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.FillRectangle(Brushes.Black, rect);
                e.Graphics.DrawString(Properties.Resource_Print.Title_DocId, strFont, Brushes.White, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                yPos += strFont.Height;

                var writer = new BarcodeWriter
                {
                    Format = (BarcodeFormat)BarcodeFormat.CODE_128,
                    Options = EncodingOptions ?? new EncodingOptions
                    {
                        PureBarcode = true,
                        Height = 58,
                        Width = 200
                    },
                    Renderer = (IBarcodeRenderer<Bitmap>)Activator.CreateInstance(Renderer)
                };

                Bitmap barcodeBitmap = writer.Write(getDocId(m_ListDocId[Properties.Resource_MapKey.DocId]));
                Image img = (Image)barcodeBitmap;

                Point p = new Point(40, (int)Math.Round(yPos));
                e.Graphics.DrawImage(img, p);
                yPos += strFont.GetHeight(e.Graphics) + strFont.Height * 4;


                rect = new Rectangle(0, (int)yPos, nPageWidth * (1 / 3), strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.DocID, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(93, (int)yPos, nPageWidth - 93, strFont.Height);
                e.Graphics.DrawString(m_ListDocId[Properties.Resource_MapKey.DocId], strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                yPos += strFont.Height * 2;

                strFormat.Alignment = StringAlignment.Near;
                rect = new Rectangle(0, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.DateofIssue, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(nPageWidth / 2, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(m_ListDocId[Properties.Resource_MapKey.DateOfIssue], strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                yPos += strFont.Height * 2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PrintTouristPassport(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                strFont = new Font("Arial", 10);
                strFormat.Alignment = StringAlignment.Near;
                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.FillRectangle(Brushes.Black, rect);
                e.Graphics.DrawString(Properties.Resource_Print.Title_TouristPassport, strFont, Brushes.White, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                yPos += strFont.Height;

                rect = new Rectangle(0, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.Number, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(nPageWidth / 2, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(m_ListTourist[Properties.Resource_MapKey.PassportNumber], strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                yPos += strFont.Height * 2;

                strFormat.Alignment = StringAlignment.Near;
                rect = new Rectangle(0, (int)yPos, nPageWidth / 2, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.Nationality, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(nPageWidth / 2, (int)yPos, nPageWidth / 2, strFont.Height);
                //e.Graphics.DrawString(getCountryStr(m_ListTourist[Properties.Resource_MapKey.Nationality]), strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawString(m_ListTourist[Properties.Resource_MapKey.Nationality], strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height * 2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PrintPurchase(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                strFont = new Font("Arial", 10);
                strFormat.Alignment = StringAlignment.Near;
                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.FillRectangle(Brushes.Black, rect);
                e.Graphics.DrawString(Properties.Resource_Print.Title_Purchase, strFont, Brushes.White, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                yPos += strFont.Height * 2;

                // Print Each Items..
                for (int i = 0; i < Convert.ToInt32(m_ListPurchase[Properties.Resource_MapKey.PurchaseTotalCnt]); i++)
                {
                    string mapKey = String.Format("{0}_{1}", Properties.Resource_MapKey.PurchaseSeq, i);
                    Dictionary<string, string> ItemData = (Dictionary<string, string>)m_ListPurchase[mapKey];

                    strFormat.Alignment = StringAlignment.Near;
                    rect = new Rectangle(0, (int)yPos, nPageWidth * (2 / 3), strFont.Height);
                    e.Graphics.DrawString(Properties.Resource_Print.DateofSales, strFont, Brushes.Black, rect, strFormat);
                    e.Graphics.DrawRectangle(Pens.White, rect);

                    strFormat.Alignment = StringAlignment.Far;
                    rect = new Rectangle(nPageWidth / 2, (int)yPos, nPageWidth / 2, strFont.Height);
                    e.Graphics.DrawString(ItemData[Properties.Resource_MapKey.DateOfSales], strFont, Brushes.Black, rect, strFormat);
                    e.Graphics.DrawRectangle(Pens.White, rect);
                    yPos += strFont.Height;

                    strFormat.Alignment = StringAlignment.Near;
                    rect = new Rectangle(0, (int)yPos, nPageWidth * (2 / 3), strFont.Height);
                    e.Graphics.DrawString(Properties.Resource_Print.ReceiptNo, strFont, Brushes.Black, rect, strFormat);
                    e.Graphics.DrawRectangle(Pens.White, rect);

                    strFormat.Alignment = StringAlignment.Far;
                    rect = new Rectangle(nPageWidth / 2, (int)yPos, nPageWidth / 2, strFont.Height);
                    e.Graphics.DrawString(ItemData[Properties.Resource_MapKey.ReceiptNo], strFont, Brushes.Black, rect, strFormat);
                    e.Graphics.DrawRectangle(Pens.White, rect);
                    yPos += strFont.Height;

                    strFormat.Alignment = StringAlignment.Near;
                    rect = new Rectangle(0, (int)yPos, nPageWidth * (2 / 3), strFont.Height);
                    e.Graphics.DrawString(Properties.Resource_Print.Amount, strFont, Brushes.Black, rect, strFormat);
                    e.Graphics.DrawRectangle(Pens.White, rect);

                    strFormat.Alignment = StringAlignment.Far;
                    rect = new Rectangle(nPageWidth / 2, (int)yPos, nPageWidth / 2, strFont.Height);

                    e.Graphics.DrawString(String.Format("{0:F2}", Convert.ToDouble(ItemData[Properties.Resource_MapKey.SaleAmount])), strFont, Brushes.Black, rect, strFormat);
                    e.Graphics.DrawRectangle(Pens.White, rect);
                    yPos += strFont.Height * 2;
                }

                yPos += strFont.Height * 2;

                // Print Total Items                
                strFormat.Alignment = StringAlignment.Near;
                rect = new Rectangle(0, (int)yPos, 184, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.SalesAmountInclGST, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(185, (int)yPos, 92, strFont.Height);
                e.Graphics.DrawString(String.Format("{0:F2}", Convert.ToDouble(m_ListPurchase[Properties.Resource_MapKey.TotalSaleAmount])), strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height;

                strFormat.Alignment = StringAlignment.Near;
                rect = new Rectangle(0, (int)yPos, 184 * (2 / 3), strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.GSTAmount, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(185, (int)yPos, 92, strFont.Height);
                e.Graphics.DrawString(m_ListPurchase[Properties.Resource_MapKey.TotalTaxAmount].ToString(), strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height;

                strFormat.Alignment = StringAlignment.Near;
                rect = new Rectangle(0, (int)yPos, 184, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.ServiceFee, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(185, (int)yPos, 92, strFont.Height);
                e.Graphics.DrawString(m_ListPurchase[Properties.Resource_MapKey.TotalCharge].ToString(), strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height;

                strFormat.Alignment = StringAlignment.Near;
                rect = new Rectangle(0, (int)yPos, 184, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.ProvisionalRefundAmount, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(185, (int)yPos, 92, strFont.Height);
                e.Graphics.DrawString(m_ListPurchase[Properties.Resource_MapKey.TotalRefundAmount].ToString(), strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height * 2;

                strFormat.Alignment = StringAlignment.Near;
                rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height * 2);
                e.Graphics.DrawString(Properties.Resource_Print.PurchaseDesc, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                yPos += strFont.Height * 3;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PrintIdentifier(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                strFont = new Font("Arial", 10);
                strFormat.Alignment = StringAlignment.Near;
                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.FillRectangle(Brushes.Black, rect);
                e.Graphics.DrawString(Properties.Resource_Print.Title_Identifier, strFont, Brushes.White, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                yPos += strFont.Height;

                rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.DocID02, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height * 2;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PrintInformation(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                strFont = new Font("Arial", 10);
                strFormat.Alignment = StringAlignment.Near;
                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.FillRectangle(Brushes.Black, rect);
                e.Graphics.DrawString(Properties.Resource_Print.Title_Information, strFont, Brushes.White, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                yPos += strFont.Height;

                rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.hompage, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height * 2;

                rect = new Rectangle(0, (int)yPos, nPageWidth * (1 / 3), strFont.Height);
                e.Graphics.DrawString(Properties.Resource_Print.DocID, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                strFormat.Alignment = StringAlignment.Far;
                rect = new Rectangle(93, (int)yPos, nPageWidth - 93, strFont.Height);
                e.Graphics.DrawString(m_ListDocId[Properties.Resource_MapKey.DocId], strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);

                yPos += strFont.Height * 3;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public void PrintFooter(PrintPageEventArgs e, ref float yPos)
        {
            try
            {
                strFont = new Font("Arial", 10, FontStyle.Bold);
                strFormat.Alignment = StringAlignment.Near;
                Rectangle rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height * 2);
                e.Graphics.DrawString(Properties.Resource_Print.Desc01, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height * 3;

                rect = new Rectangle(0, (int)yPos, nPageWidth, strFont.Height * 2);
                e.Graphics.DrawString(Properties.Resource_Print.Desc02, strFont, Brushes.Black, rect, strFormat);
                e.Graphics.DrawRectangle(Pens.White, rect);
                yPos += strFont.Height * 2;

                // Barcode
                IBarcodeWriter writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new ZXing.QrCode.QrCodeEncodingOptions
                    {
                        Width = 100,
                        Height = 100
                    }
                };

                Bitmap barcodeBitmap = writer.Write(getDocId(m_ListDocId[Properties.Resource_MapKey.DocId]));
                Image img = (Image)barcodeBitmap;
                Point p = new Point((nPageWidth / 2) - 50, (int)Math.Round(yPos));
                e.Graphics.DrawImage(img, p);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        public string getDocId(string docid)
        {
            string[] arrDocId = docid.Split('.');

            string strDocId = "";
            for (int i = 0; i < arrDocId.Length; i++)
            {
                strDocId += arrDocId[i];
            }

            return strDocId;
        }
    }
}
