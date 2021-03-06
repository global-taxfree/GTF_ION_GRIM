﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using GTF_STFM.Tran;
using GTF_STFM.Util;
using GTF_GRIM_SG.Util;
using GTF_Printer;
using log4net;

namespace GTF_STFM.Screen
{
    public partial class DetailSlipInfo : MetroFramework.Forms.MetroForm
    {
        public delegate void researchDocIdListDelegate();
        public event researchDocIdListDelegate researchDocIdList;

        public string DocId { get; set; }
        public Boolean ViewVoid = false;

        public DetailSlipInfo(ILog Logger = null)
        {
            InitializeComponent();
        }

        private void DetailSlipInfo_Load(object sender, EventArgs e)
        {
            GetDetailDocId();
            
        }

        private void GetDetailDocId()
        {
            Transaction tran = new Transaction();
            string strRsult = tran.getDocIdDetails(DocId);
            if (!strRsult.Equals(""))
            {
                JArray a = JArray.Parse(strRsult);

                foreach (JObject json in a.Children<JObject>())
                {
                    txt_DocId.Text = json["doc_id"].ToString();
                    txt_IssueDate.Text = json["issue_date"].ToString();
                    txt_StoreName.Text = json["store_name"].ToString();
                    txt_GSTNo.Text = json["gst_no"].ToString();
                    txt_Status.Text = json["status"].ToString();
                    txt_StatusCode.Text = json["status_code"].ToString();

                    txt_PassportNo.Text = json["passport_no"].ToString();
                    txt_CountryCode.Text = json["country_code"].ToString();
                    txt_Gender.Text = json["gender"].ToString();
                    txt_FirstName.Text = json["first_name"].ToString();
                    txt_LastName.Text = json["last_name"].ToString();
                    txt_DateOfBirth.Text = json["date_of_birth"].ToString();

                    txt_SalesAmt.Text = json["sales_amt"].ToString();
                    txt_GSTAmt.Text = json["gst_amt"].ToString();
                    txt_RefundAmt.Text = json["refund_amt"].ToString();
                    txt_ServiceAmt.Text = json["service_amt"].ToString();

                    txt_TID.Text = json["tid"].ToString();
                    txt_MID.Text = json["mid"].ToString();

                    txt_TokenType.Text = json["token_type"].ToString();
                    txt_TokenDisplay.Text = json["token_display"].ToString();
                }

            }

            int nRow = GRD_RECEIPT.RowCount;
            for (int i = nRow - 1; i >= 0; i--)
            {
                GRD_RECEIPT.Rows.RemoveAt(i);
            }

            GRD_RECEIPT.Refresh();

            strRsult = tran.getReceiptDetails(DocId);
            if (!strRsult.Equals(""))
            {
                JArray a = JArray.Parse(strRsult);

                int i = 0;
                foreach (JObject json in a.Children<JObject>())
                {
                    GRD_RECEIPT.Rows.Add();

                    GRD_RECEIPT[0, i].Value = json["number"].ToString();
                    GRD_RECEIPT[1, i].Value = json["receipt_no"].ToString();
                    GRD_RECEIPT[2, i].Value = json["purchase_date"].ToString();
                    GRD_RECEIPT[3, i].Value = json["purchase_amt"].ToString();
                    GRD_RECEIPT[4, i].Value = json["quantity"].ToString();
                    GRD_RECEIPT[5, i].Value = json["purchase_item"].ToString();
                    i++;
                }
                GRD_RECEIPT.Refresh();
            }

            if (txt_StatusCode.Text.Equals("01"))       // Issued
            {
                BTN_VOID.Visible = true;
                BTN_REPRINT.Visible = true;
            }
            else if (txt_StatusCode.Text.Equals("02"))  // Refunded
            {
                BTN_VOID.Visible = false;
                BTN_REPRINT.Visible = false;
            }
            else if (txt_StatusCode.Text.Equals("03")) // Void
            {
                BTN_VOID.Visible = false;
                BTN_REPRINT.Visible = true;
            }
            else
            {
                BTN_VOID.Visible = false;
                BTN_REPRINT.Visible = false;
            }

            if(ViewVoid)
            {
                BTN_VOID.Visible = false;
                BTN_REPRINT.Visible = true;
            }
        }

        private void BTN_VOID_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/VoidConfirmation"), 
                "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
                try
                {
                    Transaction tran = new Transaction();

                    string strReq = string.Empty;
                    string strRes = string.Empty;

                    JObject jsonReq = new JObject();
                    JObject jsonRes = null;

                    jsonReq.Add("status", "Void");
                    jsonReq.Add("tid", txt_TID.Text.ToString());
                    jsonReq.Add("mid", txt_MID.Text.ToString());
                    jsonReq.Add("docid", txt_DocId.Text.ToString().Replace(".", ""));
                    jsonReq.Add("userId", Constants.USER_ID);

                    strRes = tran.voidTicket(jsonReq.ToString());

                    jsonRes = JObject.Parse(strRes);

                    if (jsonRes["code"].ToString().Equals("00"))
                    {
                        MessageBox.Show(jsonRes["message"].ToString());

                        txt_StatusCode.Text = "03"; // Void
                        txt_Status.Text = "Voided";
                        PrintTicket(2);
                    }
                    else
                    {
                        MessageBox.Show(jsonRes["message"].ToString());
                    }
                    GetDetailDocId();

                    this.researchDocIdList();
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void DetailSlipInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void BTN_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BTN_REPRINT_Click(object sender, EventArgs e)
        {
            try
            {
                setWaitCursor(true);
                
                if (txt_StatusCode.Text.Equals("01"))       // Issued
                {
                    PrintTicket(3);
                }
                else if(txt_StatusCode.Text.Equals("03"))   // Void
                {
                    PrintTicket(2);
                }
                else
                {
                    MessageBox.Show("Ticket not valid");
                }
            }
            finally
            {
                setWaitCursor(false);
            }
        }

        private void PrintTicket(int flag)
        {
            try
            {
                setWaitCursor(true);
                if (Constants.PRINTER_OPOS_TYPE != null)
                {
                    JObject json = new JObject();
                    json.Add("retailer_name", txt_StoreName.Text);
                    json.Add("gst_no", txt_GSTNo.Text);
                    json.Add("doc_id", txt_DocId.Text);
                    json.Add("issue_date", txt_IssueDate.Text);
                    json.Add("passport_number", txt_PassportNo.Text);
                    json.Add("country_code", txt_CountryCode.Text);

                    JArray jsonArrary = new JArray();

                    int nRow = GRD_RECEIPT.RowCount;
                    for (int i = 0; i < nRow; i++)
                    {
                        JObject jsonReceipt = new JObject();

                        jsonReceipt.Add("number", GRD_RECEIPT.Rows[i].Cells["No"].Value.ToString());
                        jsonReceipt.Add("receipt_number", GRD_RECEIPT.Rows[i].Cells["ReceiptNumber"].Value.ToString());
                        jsonReceipt.Add("receipt_date", GRD_RECEIPT.Rows[i].Cells["PurchaseDate"].Value.ToString());
                        jsonReceipt.Add("gross_amount", GRD_RECEIPT.Rows[i].Cells["PurchaseAmount"].Value.ToString());
                        jsonReceipt.Add("quantity", GRD_RECEIPT.Rows[i].Cells["Quantity"].Value.ToString());
                        jsonReceipt.Add("description", GRD_RECEIPT.Rows[i].Cells["PurchaseItem"].Value.ToString());

                        jsonArrary.Add(jsonReceipt);
                    }

                    json.Add("purchase_list", jsonArrary.ToString());

                    json.Add("sales_amt", txt_SalesAmt.Text);
                    json.Add("gst_amt", txt_GSTAmt.Text);
                    json.Add("service_amt", txt_ServiceAmt.Text);
                    json.Add("refund_amt", txt_RefundAmt.Text);

                    if (txt_TokenType.Text.Trim().Equals(""))
                    {
                        json.Add("token_type", txt_TokenType.Text);
                        json.Add("token_display", txt_TokenDisplay.Text);
                    }
                    else
                    {
                        json.Add("token_type", "");
                        json.Add("token_display", "");
                    }

                    BixolonPrinterUtil printer = new BixolonPrinterUtil();

                    if (txt_StatusCode.Text.Equals("01"))       // Issued
                    {
                        printer.PrintOPOS(Constants.PRINTER_OPOS_TYPE, json.ToString(), flag);
                    }
                    else if (txt_StatusCode.Text.Equals("03"))   // Void
                    {
                        printer.PrintOPOS(Constants.PRINTER_OPOS_TYPE, json.ToString(), flag);
                    }
                    else
                    {
                        MessageBox.Show("Ticket not valid");
                    }
                }
            }
            finally
            {
                setWaitCursor(false);
            }
        }

        private void setWaitCursor(Boolean bWait)
        {
            if (bWait)
            {
                Cursor.Current = Cursors.WaitCursor;
                this.UseWaitCursor = true;
            }
            else
            {
                Cursor.Current = Cursors.Default;
                this.UseWaitCursor = false;
            }
        }
    }
}
