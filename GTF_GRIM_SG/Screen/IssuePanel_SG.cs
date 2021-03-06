﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Resources;
using MetroFramework;
using MetroFramework.Forms;
using Newtonsoft.Json.Linq;
using log4net;
using GTF_Comm;
using GTF_Passport;
using GTF_STFM.Util;
using GTF_Printer;
using GTF_GRIM_SG.Properties;
using GTF_STFM.Tran;
using GTF_GRIM_SG.Util;
using System.Security;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace GTF_STFM.Screen
{
    public partial class IssuePanel_SG : UserControl
    {
        static ItemForm itemForm = new ItemForm();
        static CardForm cardForm = new CardForm();

        ControlManager m_CtlSizeManager = null;
        GTF_PassportScanner m_passScan = null;

        private Image[] StatusImgs;
        private String gender = "";
        private String date_of_birth = "";
        private String expiry_date = "";
        private String dup_rc = "N";

        public IssuePanel_SG(ILog Logger = null)
        {
            InitializeComponent();
            //최초생성시 좌표, 크기 조정여부 등록함. 화면별로 Manager 를 가진다. 
            m_CtlSizeManager = new ControlManager(this);

            //횡좌표이동
            //m_CtlSizeManager.addControlMove(BTN_PASSPORT_MANUAL, true, false, false, false);
            //m_CtlSizeManager.addControlMove(BTN_ISSUE, true, false, false, false);
            //m_CtlSizeManager.addControlMove(BTN_CLEAR, true, false, false, false);
            //m_CtlSizeManager.addControlMove(BTN_SCAN, true, false,false,false);
            //m_CtlSizeManager.addControlMove(BTN_ITEM_ADD, true, false, false, false);
            //m_CtlSizeManager.addControlMove(BTN_ITEM_DEL, true, false, false, false);

            //횡늘림
            m_CtlSizeManager.addControlMove(TIL_1, false, false, true, false);
            m_CtlSizeManager.addControlMove(LAY_PASSPORT, false, false, true, false);
            m_CtlSizeManager.addControlMove(TIL_2, false, false, true, false);
            m_CtlSizeManager.addControlMove(LAY_COMMAND, false, false, true, false);

            //종횡 늘림
            m_CtlSizeManager.addControlMove(GRD_ITEMS, false, false, true, true);

            //화면 디스크립트 변경
            m_CtlSizeManager.ChageLabel(this);

            itemForm.addReceiptDetails += new ItemForm.addReceiptDetailslDelegate(addReceipt);
            itemForm.closeAddReceiptDetails += new ItemForm.closeAddReceiptDetailsDelegate(closeReceipt);
            itemForm.closeFormDetails += new ItemForm.closeFormDetailsDelegate(closeItemForm);

            ResourceManager rm = GTF_GRIM_SG.Properties.Resources.ResourceManager;
            StatusImgs = new Image[] { (Bitmap)rm.GetObject("approved"), (Bitmap)rm.GetObject("rejected") };
            
            cmbbox_Token.Items.Add("Doc-Id");
            cmbbox_Token.Items.Add("Card");
            cmbbox_Token.SelectedIndex = 0;
            txt_DisplayCardNo.Visible = false;
            txt_DisplayCardNo.Text = "";
            txt_CardNo.Text = "";

            cardForm.addCardNoDetails += new CardForm.addCardNoDetailslDelegate(addCardNo);
            cardForm.closeCardNoForm += new CardForm.closeCardNoFormDelegate(closeCardNoForm);
            this.BTN_SCAN.Click += new System.EventHandler(this.BTN_SCAN_Click);
            AutoCompleteCountry();
        }

        private void addReceipt()
        {
            int nRow = GRD_ITEMS.RowCount;
            int nChkCnt = 0;

            string newReceipt = string.Empty;
            //MessageBox.Show(GRD_ITEMS[2, (int)arrIndex[0]].Value.ToString());

            //전표 중복 체크를 위해 DB조회 
            Transaction tran = new Transaction();
           
            string strReq = string.Empty;
            string strRes = string.Empty;

            JObject jsonReq = new JObject();

            //MessageBox.Show("shopid::" + itemForm.Controls["LAY_SHOP"].Controls["txt_MID"].Text.ToString());
            jsonReq.Add("shop_id", itemForm.Controls["LAY_SHOP"].Controls["txt_MID"].Text.ToString());
            //jsonReq.Add("mid", GRD_ITEMS.Rows[0].Cells["MID"].Value.ToString());            
            
            //jsonReq.Add("receipt_no", itemForm.Controls["LAY_ITEM"].Controls["txt_ReceiptNo"].Text.ToString());
            newReceipt = itemForm.Controls["LAY_ITEM"].Controls["txt_ReceiptNo"].Text.ToString().Replace(" ", "").Trim();
            jsonReq.Add("receipt_no", newReceipt);

            jsonReq.Add("userId", Constants.USER_ID);          
            jsonReq.Add("outlet", Constants.OUTLET_TYPE);
            
            // Token
            jsonReq = MakeTokenData(jsonReq);

            nChkCnt = tran.checkRctCount(jsonReq.ToString());
            /*
            if (nChkCnt == 0)
            {
                for (int n = 0; n < nRow; n++)
                {
                    if (GRD_ITEMS.Rows[n].Cells["ReceiptNumber"].Value.ToString().Equals(newReceipt))
                    {
                        nChkCnt = 1;
                    }
                }
            }
            */
            // 중복 건수가 있을 경우 리턴
            if (nChkCnt > 0) {
                //MessageBox.Show("Hey!!");
                MessageBox.Show(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/DuplicateReceiptNo"));
                return;
            }
            
            for (int i = nRow - 1; i >= 0; i--)
            {
                if (GRD_ITEMS.Rows[i].Cells["GSTNo"].Value.ToString().Equals(itemForm.Controls["LAY_SHOP"].Controls["txt_GSTNo"].Text.ToString()) &&
                    GRD_ITEMS.Rows[i].Cells["ReceiptNumber"].Value.ToString().Equals(newReceipt))
                    //GRD_ITEMS.Rows[i].Cells["ReceiptNumber"].Value.ToString().Equals(itemForm.Controls["LAY_ITEM"].Controls["txt_ReceiptNo"].Text.ToString()))
                {
                    MessageBox.Show(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/DuplicateReceiptNo"));

                    DialogResult dialogResult = MessageBox.Show(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/ProceedWithoutDuplicateReceiptNo"),
                                    "Confirmation", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (!GRD_ITEMS.Rows[i].Cells["ResCode"].Value.ToString().Equals("00"))
                        {
                            //do something
                            GRD_ITEMS.Rows[i].Cells["Outlet"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_GroupName"].Text;
                            GRD_ITEMS.Rows[i].Cells["StoreName"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_StoreName"].Text;
                            GRD_ITEMS.Rows[i].Cells["GSTNo"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_GSTNo"].Text;
                            GRD_ITEMS.Rows[i].Cells["ReceiptNumber"].Value = newReceipt;
                            GRD_ITEMS.Rows[i].Cells["PurchaseDate"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_PurchaseDate"].Text;
                            GRD_ITEMS.Rows[i].Cells["PurchaseAmount"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_PurchaseAmt"].Text;
                            GRD_ITEMS.Rows[i].Cells["Quantity"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_Quantity"].Text;
                            GRD_ITEMS.Rows[i].Cells["PurchaseItem"].Value = itemForm.Controls["LAY_ITEM"].Controls["cmbbox_PurchateItem"].Text;
                            // Hidden
                            GRD_ITEMS.Rows[i].Cells["TID"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_TID"].Text;
                            GRD_ITEMS.Rows[i].Cells["MID"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_MID"].Text;

                            itemForm.Hide();
                        }else
                        {
                            MessageBox.Show(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/AleardyIssuedTicket"));
                        }
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //do something else
                    }
                    return;
                }
            }
            if(itemForm.txt_Keyword.Enabled)
            {
                GRD_ITEMS.Rows.Add();

                GRD_ITEMS.Rows[nRow].Cells["Outlet"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_GroupName"].Text;
                GRD_ITEMS.Rows[nRow].Cells["StoreName"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_StoreName"].Text;
                GRD_ITEMS.Rows[nRow].Cells["GSTNo"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_GSTNo"].Text;
                GRD_ITEMS.Rows[nRow].Cells["ReceiptNumber"].Value = newReceipt;
                GRD_ITEMS.Rows[nRow].Cells["PurchaseDate"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_PurchaseDate"].Text;
                GRD_ITEMS.Rows[nRow].Cells["PurchaseAmount"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_PurchaseAmt"].Text;
                GRD_ITEMS.Rows[nRow].Cells["Quantity"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_Quantity"].Text;
                GRD_ITEMS.Rows[nRow].Cells["PurchaseItem"].Value = itemForm.Controls["LAY_ITEM"].Controls["cmbbox_PurchateItem"].Text;
                // Hidden
                GRD_ITEMS.Rows[nRow].Cells["TID"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_TID"].Text;
                GRD_ITEMS.Rows[nRow].Cells["MID"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_MID"].Text;

                GRD_ITEMS.Rows[nRow].Cells["ResCode"].Value = "";
            }
            else
            {
                 
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["Outlet"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_GroupName"].Text;
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["StoreName"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_StoreName"].Text;
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["GSTNo"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_GSTNo"].Text;
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["ReceiptNumber"].Value = newReceipt;
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["PurchaseDate"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_PurchaseDate"].Text;
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["PurchaseAmount"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_PurchaseAmt"].Text;
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["Quantity"].Value = itemForm.Controls["LAY_ITEM"].Controls["txt_Quantity"].Text;
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["PurchaseItem"].Value = itemForm.Controls["LAY_ITEM"].Controls["cmbbox_PurchateItem"].Text;
                // Hidden
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["TID"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_TID"].Text;
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["MID"].Value = itemForm.Controls["LAY_SHOP"].Controls["txt_MID"].Text;

                GRD_ITEMS.Rows[itemForm.issue_index].Cells["ResCode"].Value = "";
                GRD_ITEMS.Rows[itemForm.issue_index].Cells["Reason"].Value = "";
            }

            itemForm.Hide();
        }

        private void closeReceipt()
        {
            itemForm.Hide();
        }

        private void closeItemForm()
        {
            itemForm = new ItemForm();
            itemForm.addReceiptDetails += new ItemForm.addReceiptDetailslDelegate(addReceipt);
            itemForm.closeAddReceiptDetails += new ItemForm.closeAddReceiptDetailsDelegate(closeReceipt);
            itemForm.closeFormDetails += new ItemForm.closeFormDetailsDelegate(closeItemForm);
        }

        private void addCardNo()
        {
            txt_CardNo.Text = cardForm.Controls["LAY_CARD"].Controls["txt_CardNo"].Text;
            txt_DisplayCardNo.Text = cardForm.Controls["LAY_CARD"].Controls["txt_DisplayCardNo"].Text;
            cardForm.Hide();

            if (txt_CardNo.Text.Equals(""))
            {
                cmbbox_Token.SelectedIndex = 0;
                txt_DisplayCardNo.Visible = false;
                txt_DisplayCardNo.Text = "";
                txt_CardNo.Text = "";
            }
            txt_Dummy.Focus();
        }

        private void closeCardNoForm()
        {
            cardForm = new CardForm();
            cardForm.addCardNoDetails += new CardForm.addCardNoDetailslDelegate(addCardNo);
            cardForm.closeCardNoForm += new CardForm.closeCardNoFormDelegate(closeCardNoForm);
        }

        public void init()
        {
            BTN_ITEM_ADD.Focus();

        }

        private void IssuePanel_Load(object sender, EventArgs e)
        {
            m_passScan = GTF_PassportScanner.Instance();
        }

        private void BTN_SCAN_Click(object sender, EventArgs e)
        {
            try
            {
                if(!txt_PassportNo.Text.Equals(""))
                {
                    return;
                }
                this.BTN_SCAN.Click -= new System.EventHandler(this.BTN_SCAN_Click);
                BTN_SCAN.Enabled = false;
                txt_PassportNo.Text = "";
                txt_CountryCode.Text = "";
                txt_FirstName.Text = "";
                txt_LastName.Text = "";
                expiry_date = "";
                date_of_birth = "";
                gender = "";

                Utils gtfUtil = new Utils();

                setWaitCursor(true);
                if (m_passScan.open(Constants.PASSPORT_TYPE) > 0)
                {
                    int strmrz = m_passScan.scan(Constants.SCAN_TIMEOUT);
                    if (strmrz > 0)
                    {
                        //싱가폴
                        if (m_passScan.GetNationality().Equals("SGP"))
                        {
                            MetroMessageBox.Show(this, "The Singapore Passport is non-refundable.", "Passport Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txt_PassportNo.Text = m_passScan.GetPassportNo();
                            txt_CountryCode.Text = m_passScan.GetNationality();
                            txt_FirstName.Text = m_passScan.GetPassportLastName();
                            txt_LastName.Text = m_passScan.GetPassportFirstName();
                            expiry_date = "20" + m_passScan.GetExpireDate();
                            date_of_birth = gtfUtil.getFullDate(m_passScan.GetBirthDate());
                            gender = m_passScan.GetSex();
                        }
                        
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Please check if passport is inserted into slot", "Passport Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Passport scanner not connected", "Passport Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
                //MessageBox.Show(ex.Message);
            }
            finally
            {
                m_passScan.close();
                BTN_SCAN.Enabled = true;
                setWaitCursor(false);
                this.BTN_SCAN.Click += new System.EventHandler(this.BTN_SCAN_Click);
            }
        }

        private void IssueTicket_SingleReceipt(int nIndex)
        {
            try
            {
                Transaction tran = new Transaction();

                //MessageBox.Show(GRD_ITEMS[2, nIndex].Value.ToString());

                string strReq = string.Empty;
                string strRes = string.Empty;

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                jsonReq.Add("status", "Issue");
                jsonReq.Add("tid", GRD_ITEMS.Rows[nIndex].Cells["TID"].Value.ToString());
                jsonReq.Add("mid", GRD_ITEMS.Rows[nIndex].Cells["MID"].Value.ToString());
                jsonReq.Add("userId", Constants.USER_ID);
                if (!txt_PassportNo.Text.Equals(""))
                {
                    jsonReq.Add("passport_number", txt_PassportNo.Text);
                }

                if (!txt_CountryCode.Text.Equals(""))
                {
                    jsonReq.Add("country_code", txt_CountryCode.Text);
                }

                if (!txt_LastName.Text.Equals(""))
                {
                    jsonReq.Add("last_name", txt_LastName.Text);
                }

                if (!txt_FirstName.Text.Equals(""))
                {
                    jsonReq.Add("first_name", txt_FirstName.Text);
                }

                if (!expiry_date.Equals(""))
                {
                    jsonReq.Add("expiry_date", expiry_date);
                }

                if (!date_of_birth.Equals(""))
                {
                    jsonReq.Add("date_of_birth", date_of_birth);
                }

                if (!gender.Equals(""))
                {
                    jsonReq.Add("gender", gender);
                }

                //////////////////////////////////////////////////////////////////////////////////////////////
                JArray jsonArrary = new JArray();
                JObject jsonReceipt = new JObject();

                jsonReceipt.Add("description", GRD_ITEMS.Rows[nIndex].Cells["PUrchaseItem"].Value.ToString());

                string gross_amount = GRD_ITEMS.Rows[nIndex].Cells["PurchaseAmount"].Value.ToString().Replace("$", "").Replace(",", "");

                jsonReceipt.Add("gross_amount", gross_amount);
                jsonReceipt.Add("quantity", GRD_ITEMS.Rows[nIndex].Cells["Quantity"].Value.ToString());

                string receipt_date = GRD_ITEMS.Rows[nIndex].Cells["PurchaseDate"].Value.ToString().Replace("/", "");
                receipt_date = Util.Utils.FormatConvertDate(receipt_date);

                jsonReceipt.Add("receipt_date", receipt_date);
                jsonReceipt.Add("receipt_number", GRD_ITEMS.Rows[nIndex].Cells["ReceiptNumber"].Value.ToString());
                //////////////////////////////////////////////////////////////////////////////////////////////
                jsonArrary.Add(jsonReceipt);

                jsonReq.Add("purchase_list", jsonArrary.ToString());

                jsonReq.Add("outlet", Constants.OUTLET_TYPE);

                // Token
                jsonReq = MakeTokenData(jsonReq);

                strRes = tran.issueTicket(jsonReq.ToString());

                jsonRes = JObject.Parse(strRes);

                if (jsonRes["code"].ToString().Equals("00"))
                {
                    GRD_ITEMS.Rows[nIndex].Cells["Approved"].Value = StatusImgs[0];

                    Constants.LOGGER_DOC.Info("Start Print(Single) --> nIndex : " + nIndex);
                    PrintTicket(jsonRes);

                    GRD_ITEMS.Rows[nIndex].Cells["Reason"].Value = jsonRes["message"].ToString();
                    GRD_ITEMS.Rows[nIndex].Cells["ResCode"].Value = jsonRes["code"].ToString();
                }
                else
                {
                    GRD_ITEMS.Rows[nIndex].Cells["Approved"].Value = StatusImgs[1];

                    if (jsonRes["code"].ToString().Equals("duplicated receipt number!") || jsonRes["code"].ToString().Equals("unregistered terminal!"))
                    {
                        GRD_ITEMS.Rows[nIndex].Cells["Reason"].Value = jsonRes["message"].ToString();
                    }
                    else
                    {
                        GRD_ITEMS.Rows[nIndex].Cells["Reason"].Value = "Failed";
                    }
                    Constants.LOGGER_MAIN.Error(jsonRes["message"].ToString());
                    GRD_ITEMS.Rows[nIndex].Cells["ResCode"].Value = jsonRes["code"].ToString();
                }

            }
            catch (Exception ex)
            {
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
                //MessageBox.Show(ex.Message);
            }
        }

        private void IssueTicket_MutipleReceipt(ArrayList arrIndex)
        {
            try
            {
                Transaction tran = new Transaction();

                //MessageBox.Show(GRD_ITEMS[2, (int)arrIndex[0]].Value.ToString());

                string strReq = string.Empty;
                string strRes = string.Empty;

                JObject jsonReq = new JObject();
                JObject jsonRes = null;

                jsonReq.Add("status", "Issue");
                jsonReq.Add("tid", GRD_ITEMS.Rows[(int)arrIndex[0]].Cells["TID"].Value.ToString());
                jsonReq.Add("mid", GRD_ITEMS.Rows[(int)arrIndex[0]].Cells["MID"].Value.ToString());
                jsonReq.Add("userId", Constants.USER_ID);
                if (!txt_PassportNo.Text.Equals(""))
                {
                    jsonReq.Add("passport_number", txt_PassportNo.Text);
                }

                if (!txt_CountryCode.Text.Equals(""))
                {
                    jsonReq.Add("country_code", txt_CountryCode.Text);
                }

                if (!txt_LastName.Text.Equals(""))
                {
                    jsonReq.Add("last_name", txt_LastName.Text);
                }

                if (!txt_FirstName.Text.Equals(""))
                {
                    jsonReq.Add("first_name", txt_FirstName.Text);
                }

                if (!expiry_date.Equals(""))
                {
                    jsonReq.Add("expiry_date", expiry_date);
                }

                if (!date_of_birth.Equals(""))
                {
                    jsonReq.Add("date_of_birth", date_of_birth);
                }

                if (!gender.Equals(""))
                {
                    jsonReq.Add("gender", gender);
                }
                //////////////////////////////////////////////////////////////////////////////////////////////
                JArray jsonArrary = new JArray();
                for (int i = 0; i < arrIndex.Count; i++)
                {
                    int nRow = (int)arrIndex[i];

                    JObject jsonReceipt = new JObject();

                    jsonReceipt.Add("description", GRD_ITEMS.Rows[nRow].Cells["PUrchaseItem"].Value.ToString());

                    string gross_amount = GRD_ITEMS.Rows[nRow].Cells["PurchaseAmount"].Value.ToString().Replace("$", "").Replace(",", "");

                    jsonReceipt.Add("gross_amount", gross_amount);
                    jsonReceipt.Add("quantity", GRD_ITEMS.Rows[nRow].Cells["Quantity"].Value.ToString().Replace(",", ""));

                    string receipt_date = GRD_ITEMS.Rows[nRow].Cells["PurchaseDate"].Value.ToString().Replace("/", "");
                    receipt_date = Util.Utils.FormatConvertDate(receipt_date);

                    jsonReceipt.Add("receipt_date", receipt_date);
                    jsonReceipt.Add("receipt_number", GRD_ITEMS.Rows[nRow].Cells["ReceiptNumber"].Value.ToString());
                    //////////////////////////////////////////////////////////////////////////////////////////////
                    jsonArrary.Add(jsonReceipt);
                }

                jsonReq.Add("purchase_list", jsonArrary.ToString());

                jsonReq.Add("outlet", Constants.OUTLET_TYPE);

                // Token
                jsonReq = MakeTokenData(jsonReq);

                strRes = tran.issueTicket(jsonReq.ToString());

                jsonRes = JObject.Parse(strRes);

                for (int i = 0; i < arrIndex.Count; i++)
                {
                    int nRow = (int)arrIndex[i];
                    Constants.LOGGER_DOC.Info("Start Print(Multiple) --> nIndex : " + nRow);

                    if (jsonRes["code"].ToString().Equals("00"))
                    {
                        GRD_ITEMS.Rows[nRow].Cells["Approved"].Value = StatusImgs[0];

                        GRD_ITEMS.Rows[nRow].Cells["Reason"].Value = jsonRes["message"].ToString();
                        GRD_ITEMS.Rows[nRow].Cells["ResCode"].Value = jsonRes["code"].ToString();
                    }
                    else
                    {
                        GRD_ITEMS.Rows[nRow].Cells["Approved"].Value = StatusImgs[1];
                        if(jsonRes["code"].ToString().Equals("duplicated receipt number!") || jsonRes["code"].ToString().Equals("unregistered terminal!"))
                        {
                            GRD_ITEMS.Rows[nRow].Cells["Reason"].Value = jsonRes["message"].ToString();
                        }
                        else
                        {
                            GRD_ITEMS.Rows[nRow].Cells["Reason"].Value = "Failed";
                        }
                        
                        Constants.LOGGER_MAIN.Error(jsonRes["message"].ToString());
                        GRD_ITEMS.Rows[nRow].Cells["ResCode"].Value = jsonRes["code"].ToString();
                    }

                }

                if (jsonRes["code"].ToString().Equals("00"))
                    PrintTicket(jsonRes);
            }
            catch (Exception ex)
            {
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
                //MessageBox.Show(ex.Message);
            }
        }

        private JObject MakeTokenData(JObject jsonReq)
        {
            JObject json = jsonReq;

            try
            {
                //////////////////////////////////////////////////////////////////////////////////////////////
                // Token
                //////////////////////////////////////////////////////////////////////////////////////////////
                if (!txt_CardNo.Text.Equals(""))
                {
                    string card_no = txt_CardNo.Text;

                    string token_type = "";
                    string token_display = "";
                    string token_encrypted = "";
                    string token_hashed = "";
                    string token_maked = "";
                    string token_key_id = "";
                    string token_lookup = "";

                    EncryptUtil encUtil = new EncryptUtil();

                    int check_token_type = encUtil.checkCardBIN(long.Parse(card_no));
                    if (check_token_type > 0)
                    {
                        switch (check_token_type)
                        {
                            case 1:
                                token_type = "C";
                                break;
                            case 2:
                                token_type = "B";
                                break;
                            default:
                                token_type = "O";
                                break;
                        }

                        if (token_type.Equals("C"))
                        {
                            X509Certificate2 CERT_GTF_CC = encUtil.GetCertificateFromStore("GTF_CAT_AUTH");
                            Org.BouncyCastle.X509.X509Certificate cert_cch_cc = DotNetUtilities.FromX509Certificate(CERT_GTF_CC);

                            byte[] cipherData = encUtil.encryptRsa(Encoding.UTF8.GetBytes(card_no), cert_cch_cc);

                            token_encrypted = Convert.ToBase64String(cipherData);
                            token_key_id = encUtil.getSKID(cert_cch_cc);
                            token_hashed = Convert.ToBase64String(encUtil.hashData(Encoding.UTF8.GetBytes(card_no)));
                            token_maked = txt_DisplayCardNo.Text.Replace("-", "");
                            token_display = txt_DisplayCardNo.Text.Replace("-", "");
                        }

                        if (token_type.Equals("C") || token_type.Equals("B"))
                        {
                            token_lookup = token_type + "+" + Convert.ToBase64String(encUtil.hashData(Encoding.UTF8.GetBytes(card_no)));
                        }
                        else if (token_type.Equals("O"))
                        {
                            token_lookup = "O" + card_no;
                            token_display = txt_DisplayCardNo.Text.Replace("-", "");
                        }

                        ///////////////////////////////////////////////////////////////

                        jsonReq.Add("token_type", token_type);
                        jsonReq.Add("token_lookup", token_lookup);
                        jsonReq.Add("token_display", token_display);
                        jsonReq.Add("token_encrypted", token_encrypted);
                        jsonReq.Add("token_hashed", token_hashed);
                        jsonReq.Add("token_maked", token_maked);
                        jsonReq.Add("token_key_id", token_key_id);
                    }
                }
            }
            catch (Exception ex)
            {
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
                //MessageBox.Show(ex.Message);
            }
            finally
            {

            }

            return json;
        }

        private void PrintTicket(JObject jsonRes)
        {
            try
            {
                setWaitCursor(true);

                if (Constants.PRINTER_OPOS_TYPE != null)
                {
                    JObject json = new JObject();
                    json.Add("retailer_name", jsonRes["retailer_name"].ToString());
                    json.Add("gst_no", jsonRes["retailer_gstno"].ToString());
                    json.Add("doc_id", jsonRes["formatted_docid"].ToString());

                    string issue_date = Utils.FormatDate(jsonRes["date_of_issue"].ToString()) + " " + Utils.FormatTime(jsonRes["time_of_issue"].ToString());

                    json.Add("issue_date", issue_date);

                    if(jsonRes["passport_number"] != null)
                        json.Add("passport_number", jsonRes["passport_number"].ToString());
                    else
                        json.Add("passport_number", "");

                    if (jsonRes["country_code"] != null)
                        json.Add("country_code", jsonRes["country_code"].ToString());
                    else
                        json.Add("country_code", "");

                    JArray jsonArrary = new JArray();

                    JArray tmp_arr = JArray.Parse(jsonRes["purchase_list"].ToString());

                    int i = 0;
                    foreach (JObject tmp_obj in tmp_arr.Children<JObject>())
                    {
                        i++;
                        JObject jsonReceipt = new JObject();

                        jsonReceipt.Add("number", i);
                        jsonReceipt.Add("receipt_number", tmp_obj["receipt_number"].ToString());
                        jsonReceipt.Add("receipt_date", Utils.FormatDate(tmp_obj["receipt_date"].ToString()));
                        jsonReceipt.Add("gross_amount", tmp_obj["gross_amount"].ToString());
                        jsonReceipt.Add("quantity", tmp_obj["quantity"].ToString());
                        jsonReceipt.Add("description", tmp_obj["description"].ToString());
                        jsonArrary.Add(jsonReceipt);
                    }

                    json.Add("purchase_list", jsonArrary.ToString());

                    json.Add("sales_amt", jsonRes["sales_amount"].ToString());
                    json.Add("gst_amt", jsonRes["gst_amount"].ToString());
                    json.Add("service_amt", jsonRes["service_amount"].ToString());
                    json.Add("refund_amt", jsonRes["refund_amount"].ToString());

                    if (jsonRes["token_type"] != null)
                    {
                        json.Add("token_type", jsonRes["token_type"].ToString());
                    }

                    if (jsonRes["token_display"] != null)
                    {
                        if (jsonRes["token_type"].ToString().Equals("C"))
                        {
                            String[] token_text = jsonRes["token_display"].ToString().Split(new String[]{"****"}, StringSplitOptions.RemoveEmptyEntries);
                            json.Add("token_display", "****-****-****-"  + token_text[token_text.Length-1].ToString()) ; 
                        }
                        else
                        {
                            json.Add("token_display", jsonRes["token_display"].ToString());
                        }
                    }
                        

                    BixolonPrinterUtil printer = new BixolonPrinterUtil();

                    printer.PrintOPOS(Constants.PRINTER_OPOS_TYPE, json.ToString(), 1);
                }

            }
            catch (Exception ex)
            {
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
                //MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                setWaitCursor(false);
            }
        }

        private void IssuePanel_SizeChanged(object sender, EventArgs e)
        {
            if (m_CtlSizeManager != null)
            {
                m_CtlSizeManager.MoveControls();
                this.Refresh();
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

        private void BTN_ITEM_DEL_Click(object sender, EventArgs e)
        {
            int nRow = GRD_ITEMS.RowCount;
            for (int i = nRow - 1; i >= 0; i--)
            {
                if (GRD_ITEMS[0, i].Value != null && "True".Equals(GRD_ITEMS[0, i].Value.ToString()))
                {
                    GRD_ITEMS.Rows.RemoveAt(i);
                }
            }
        }

        private void BTN_ITEM_ADD_Click(object sender, EventArgs e)
        {
            if (txt_PassportNo.Text.Equals("") || txt_CountryCode.Text.Equals(""))
            {
                MessageBox.Show(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/ValidatePassportInfo"));
                return;
            }
            itemForm.Show();
            //itemForm.ShowDialog();
            itemForm.initialize();
        }

        private void BTN_ISSUE_Click(object sender, EventArgs e)
        {
            try
            {
                BTN_ISSUE.Enabled = false;
                setWaitCursor(true);

                ArrayList arrPrint = new ArrayList();

                ArrayList arrPreparation = new ArrayList();

                ArrayList arrGstNo = new ArrayList();

                int nTotalRow = GRD_ITEMS.RowCount;

                //Constants.LOGGER_MAIN.Info("nTotalRow : " + nTotalRow);

                for (int i = nTotalRow - 1; i >= 0; i--)
                {
                    if (GRD_ITEMS.Rows[i].Cells["ResCode"].Value.ToString().Equals("00"))
                    {
                        GRD_ITEMS.Rows.RemoveAt(i);
                    }
                }

                GRD_ITEMS.Refresh();

                nTotalRow = GRD_ITEMS.RowCount;

                //Constants.LOGGER_MAIN.Info("nTotalRow : " + nTotalRow);

                for (int nRow = 0; nRow < nTotalRow; nRow++)
                {
                    if (!GRD_ITEMS.Rows[nRow].Cells["ResCode"].Value.ToString().Equals("00"))
                    {
                        bool exist = false;

                        Hashtable ht = new Hashtable();

                        for (int j = 0; j < arrPreparation.Count; j++)
                        {
                            ht = (Hashtable)arrPreparation[j];

                            if (ht["gst_no"].ToString().Equals(GRD_ITEMS.Rows[nRow].Cells["GSTNo"].Value.ToString()) &&
                                ht["purchase_date"].ToString().Equals(GRD_ITEMS.Rows[nRow].Cells["PurchaseDate"].Value.ToString())
                                )
                            {
                                exist = true;
                                break;
                            }
                        }

                        if (!exist)
                        {
                            ht = new Hashtable();
                            ht.Add("gst_no", GRD_ITEMS.Rows[nRow].Cells["GSTNo"].Value.ToString());
                            ht.Add("purchase_date", GRD_ITEMS.Rows[nRow].Cells["PurchaseDate"].Value.ToString());

                            float rowPurchaseAmt = float.Parse(GRD_ITEMS.Rows[nRow].Cells["PurchaseAmount"].Value.ToString());
                            ht.Add("purchase_amt", rowPurchaseAmt.ToString());
                            ht.Add("receipt_count", "1");

                            ht.Add("top1", rowPurchaseAmt.ToString());
                            ht.Add("top2", "0");
                            ht.Add("top3", "0");

                            float top3Total = float.Parse(ht["top1"].ToString()) + float.Parse(ht["top2"].ToString()) + float.Parse(ht["top3"].ToString());
                            ht.Add("top3Total", top3Total.ToString());

                            arrPreparation.Add(ht);
                        }
                        else
                        {
                            Hashtable tmp_ht = new Hashtable();
                            tmp_ht.Add("gst_no", ht["gst_no"].ToString());
                            tmp_ht.Add("purchase_date", ht["purchase_date"].ToString());

                            float purchase_amt = float.Parse(ht["purchase_amt"].ToString());
                            float rowPurchaseAmt = float.Parse(GRD_ITEMS.Rows[nRow].Cells["PurchaseAmount"].Value.ToString());
                            purchase_amt += rowPurchaseAmt;
                            tmp_ht.Add("purchase_amt", purchase_amt);

                            int receipt_count = int.Parse(ht["receipt_count"].ToString()) + 1;
                            tmp_ht.Add("receipt_count", receipt_count);

                            float top1 = float.Parse(ht["top1"].ToString());
                            float top2 = float.Parse(ht["top2"].ToString());
                            float top3 = float.Parse(ht["top3"].ToString());

                            if (rowPurchaseAmt >= top1)
                            {
                                tmp_ht.Add("top1", rowPurchaseAmt.ToString());
                                tmp_ht.Add("top2", top1.ToString());
                                tmp_ht.Add("top3", top2.ToString());
                            }
                            else if (rowPurchaseAmt >= top2 && rowPurchaseAmt < top1)
                            {
                                tmp_ht.Add("top1", top1.ToString());
                                tmp_ht.Add("top2", rowPurchaseAmt.ToString());
                                tmp_ht.Add("top3", top2.ToString());
                            }
                            else if (rowPurchaseAmt >= top3 && rowPurchaseAmt < top2)
                            {
                                tmp_ht.Add("top1", top1.ToString());
                                tmp_ht.Add("top2", top2.ToString());
                                tmp_ht.Add("top3", rowPurchaseAmt.ToString());
                            }
                            else
                            {
                                tmp_ht.Add("top1", top1.ToString());
                                tmp_ht.Add("top2", top2.ToString());
                                tmp_ht.Add("top3", top3.ToString());
                            }

                            float top3Total = float.Parse(tmp_ht["top1"].ToString()) + float.Parse(tmp_ht["top2"].ToString()) + float.Parse(tmp_ht["top3"].ToString());
                            tmp_ht.Add("top3Total", top3Total.ToString());

                            arrPreparation.Remove(ht);
                            arrPreparation.Add(tmp_ht);
                        }
                    }
                } // RespCode 체크

                //Constants.LOGGER_MAIN.Info(" $$$$$$$$ arrPreparation.Count : " + arrPreparation.Count.ToString());

                // arrPreparation : gst_no, purchase_date 기준의 그룹
                ArrayList arrGst = new ArrayList();
                ArrayList arrSummury = new ArrayList();
                Hashtable htSub = null;
                Hashtable htTmp = null;
                

                bool isQualified = false;
                string message = "";
                string gridMessage = "";
                ArrayList arrException = new ArrayList();

                for (int i = 0; i < arrPreparation.Count; i++)
                {
                    //Constants.LOGGER_MAIN.Info(" $$$$$$$$ arrPreparation : " + i);
                    htSub = new Hashtable();
                    htSub = (Hashtable)arrPreparation[i];

                    //Constants.LOGGER_MAIN.Info(" $$$$$$$$ GSTNO : " + htSub["gst_no"].ToString());
                    //Constants.LOGGER_MAIN.Info(" $$$$$$$$ PURCHASE DATE : " + htSub["purchase_date"].ToString());
                    //Constants.LOGGER_MAIN.Info(" $$$$$$$$ TOTAL AMT : " + htSub["top3Total"].ToString());

                    float top3Total = float.Parse(htSub["top3Total"].ToString());

                    if (top3Total >= (float)100.00)
                    {
                        for (int j = 0; j < nTotalRow; j++)
                        {
                            if (htSub["gst_no"].ToString().Equals(GRD_ITEMS.Rows[j].Cells["GSTNo"].Value.ToString()) &&
                                htSub["purchase_date"].ToString().Equals(GRD_ITEMS.Rows[j].Cells["PurchaseDate"].Value.ToString()) &&
                                !GRD_ITEMS.Rows[j].Cells["ResCode"].Value.ToString().Equals("00"))
                            {
                                htTmp = new Hashtable();

                                //Constants.LOGGER_MAIN.Info(" @@@ Gst : " + htSub["gst_no"].ToString());
                                //Constants.LOGGER_MAIN.Info(" @@@ idx : " + j);

                                htTmp.Add(htSub["gst_no"].ToString(), j.ToString());

                                arrSummury.Add(htTmp);

                                htTmp = null;

                                bool isContains = false;

                                if (arrGst.Count > 0)
                                {
                                    for (int k = 0; k < arrGst.Count; k++)
                                    {
                                        //Constants.LOGGER_MAIN.Info(" @@@ For ArrGst : [" + k + "]" + htSub["gst_no"].ToString() + " | " + arrGst[k].ToString());

                                        if (arrGst[k].ToString().Equals(htSub["gst_no"].ToString()))
                                        {
                                            isContains = true;
                                            break;
                                        }
                                    }

                                    //Constants.LOGGER_MAIN.Info(" @@@ isContains : " + isContains.ToString()); 

                                    if (!isContains)
                                    {
                                        arrGst.Add(htSub["gst_no"].ToString());
                                        isContains = false;

                                        //Constants.LOGGER_MAIN.Info(" @@@ Added GST Number : " + htSub["gst_no"].ToString());
                                    }
                                }
                                else
                                {
                                    arrGst.Add(htSub["gst_no"].ToString());

                                    //Constants.LOGGER_MAIN.Info(" @@@ Added GST Number : " + htSub["gst_no"].ToString());
                                }
                            }
                        }
                    }
                    else
                    {
                        if (!isQualified)
                        {
                            isQualified = true;
                        }

                        for (int j = 0; j < nTotalRow; j++)
                        {
                            if (htSub["gst_no"].ToString().Equals(GRD_ITEMS.Rows[j].Cells["GSTNo"].Value.ToString()) &&
                                htSub["purchase_date"].ToString().Equals(GRD_ITEMS.Rows[j].Cells["PurchaseDate"].Value.ToString()) &&
                                !GRD_ITEMS.Rows[j].Cells["ResCode"].Value.ToString().Equals("00"))
                            {
                                arrException.Add(j);
                            }
                        }
                    }
                }

                if (isQualified)
                {
                    message = string.Format(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/CheckIssueConditions"), Environment.NewLine);
                    MessageBox.Show(message);

                    gridMessage = string.Format(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/CheckIssueConditionsFail"), Environment.NewLine);
                    for (int l = 0; l < arrException.Count; l++)
                    {
                        GRD_ITEMS.Rows[(int)arrException[l]].Cells["Approved"].Value = StatusImgs[1];
                        GRD_ITEMS.Rows[(int)arrException[l]].Cells["Reason"].Value = gridMessage;
                        GRD_ITEMS.Rows[(int)arrException[l]].Cells["ResCode"].Value = "99";
                    }

                }

                //Constants.LOGGER_MAIN.Info(" ##### arrGst.Count : " + arrGst.Count);
                //Constants.LOGGER_MAIN.Info(" ##### arrSummury.Count : " + arrSummury.Count);

                ArrayList arrExecution = new ArrayList();
                Hashtable htSummury = null;
                string gst_no;
                for (int n = 0; n < arrGst.Count; n++)
                {
                    gst_no = "";
                    gst_no = arrGst[n].ToString();

                    for (int l = 0; l < arrSummury.Count; l++)
                    {
                        int gridRowIdx = 0;
                        htSummury = new Hashtable();
                        htSummury = (Hashtable)arrSummury[l];

                        //Constants.LOGGER_MAIN.Info(" ##### htSummury.Contains(" + gst_no + ") : " + htSummury.ContainsKey(gst_no).ToString());

                        if (htSummury.ContainsKey(gst_no))
                        {
                            gridRowIdx = int.Parse(htSummury[gst_no].ToString());
                            //Constants.LOGGER_MAIN.Info(" ##### gridRowIdx : " + gridRowIdx);
                            arrExecution.Add(gridRowIdx);
                        }

                        //Constants.LOGGER_MAIN.Info(" ##### arrSummury loop Count : " + l);

                        htSummury = null;
                    }

                    if (arrExecution.Count > 0)
                    {
                        IssueTicket_MutipleReceipt(arrExecution);
                        arrExecution.Clear();
                    }
                }

                GRD_ITEMS.Refresh();
            }
            catch (Exception ex)
            {
                Constants.LOGGER_MAIN.Error(ex.StackTrace);
            }
            finally
            {
                BTN_ISSUE.Enabled = true;
                setWaitCursor(false);
            }
        }

        private void BTN_CLEAR_Click(object sender, EventArgs e)
        {
            int nRow = GRD_ITEMS.RowCount;
            for (int i = nRow - 1; i >= 0; i--)
            { 
                GRD_ITEMS.Rows.RemoveAt(i);
            }
            GRD_ITEMS.Refresh();

            txt_PassportNo.Text = "";
            txt_CountryCode.Text = "";
            txt_FirstName.Text = "";
            txt_LastName.Text = "";
            gender = "";
            date_of_birth = "";
            expiry_date = "";

            cmbbox_Token.SelectedIndex = 0;
            txt_DisplayCardNo.Visible = false;
            txt_DisplayCardNo.Text = "";
            txt_CardNo.Text = "";
            txt_CountryCode.Enabled = false;
            txt_PassportNo.Enabled = false;
            BTN_SCAN.Enabled = true;
        }

        private void GRD_ITEMS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                return;
            }

            if (e.RowIndex < 0)
            {
                return;
            }

            int nRow = e.RowIndex;

            if (!GRD_ITEMS.Rows[nRow].Cells["ResCode"].Value.Equals("00"))
            {

                JObject json = new JObject();

                itemForm.setReceiptDetail();

                itemForm.Controls["LAY_SHOP"].Controls["txt_GroupName"].Text = GRD_ITEMS.Rows[nRow].Cells["Outlet"].Value.ToString();
                itemForm.Controls["LAY_SHOP"].Controls["txt_StoreName"].Text = GRD_ITEMS.Rows[nRow].Cells["StoreName"].Value.ToString();
                itemForm.Controls["LAY_SHOP"].Controls["txt_GSTNo"].Text = GRD_ITEMS.Rows[nRow].Cells["GSTNo"].Value.ToString();
                itemForm.Controls["LAY_ITEM"].Controls["txt_ReceiptNo"].Text = GRD_ITEMS.Rows[nRow].Cells["ReceiptNumber"].Value.ToString();

                /*
                itemForm.Controls["LAY_ITEM"].Controls["txt_PurchaseDate"].Value = new DateTime(int.Parse(DateTime.Now.ToString("yyyy")),
                                     int.Parse(DateTime.Now.ToString("MM")),
                                     int.Parse(DateTime.Now.ToString("dd")));
                */

                itemForm.Controls["LAY_ITEM"].Controls["txt_PurchaseAmt"].Text = GRD_ITEMS.Rows[nRow].Cells["PurchaseAmount"].Value.ToString();
                itemForm.Controls["LAY_ITEM"].Controls["txt_Quantity"].Text = GRD_ITEMS.Rows[nRow].Cells["Quantity"].Value.ToString();
                itemForm.Controls["LAY_ITEM"].Controls["cmbbox_PurchateItem"].Text = GRD_ITEMS.Rows[nRow].Cells["PurchaseItem"].Value.ToString();
                // Hidden
                itemForm.Controls["LAY_SHOP"].Controls["txt_TID"].Text = GRD_ITEMS.Rows[nRow].Cells["TID"].Value.ToString();
                itemForm.Controls["LAY_SHOP"].Controls["txt_MID"].Text = GRD_ITEMS.Rows[nRow].Cells["MID"].Value.ToString();

                itemForm.issue_index = nRow;
                itemForm.Show();
                //itemForm.ShowDialog();
            }
        }

        private void cmbbox_Token_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbbox_Token.SelectedIndex == 1)     // Card
            {
                txt_DisplayCardNo.Visible = true;
                txt_DisplayCardNo.Text = "";
                txt_CardNo.Text = "";

                cardForm.ShowDialog();
                cardForm.initialize();
                cardForm.Controls["LAY_CARD"].Controls["txt_Track2"].Focus();
            }
            else
            {
                txt_DisplayCardNo.Visible = false;
                txt_DisplayCardNo.Text = "";
                txt_CardNo.Text = "";
            }
        }

        private void BTN_INPUT_Click(object sender, EventArgs e)
        {
            if(BTN_SCAN.Enabled)
            {
                txt_CountryCode.Enabled = true;
                txt_PassportNo.Enabled = true;
                BTN_SCAN.Enabled = false;
                txt_PassportNo.Focus();
            }
            else
            {
                txt_CountryCode.Enabled = false;
                txt_PassportNo.Enabled = false;

                BTN_SCAN.Enabled = true;
                BTN_SCAN.Focus();
            }
        }

        public void AutoCompleteCountry()
        {


            txt_CountryCode.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_CountryCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
            AutoCompleteStringCollection storeAcsCollection = new AutoCompleteStringCollection();

            Transaction tran = new Transaction();
            string strRsult = tran.searchCountryCode(txt_CountryCode.Text);

            if (!strRsult.Equals(""))
            {

                JArray a = JArray.Parse(strRsult);

                int i = 0;
                foreach (JObject json in a.Children<JObject>())
                {
                    storeAcsCollection.Add(json["country_code"].ToString());
                }

            }
            else
            {
                storeAcsCollection = null;

            }
            txt_CountryCode.AutoCompleteCustomSource = storeAcsCollection;
        }

        private void txt_CountryCode_Leave(object sender, EventArgs e)
        {
            if(txt_CountryCode.Text.Length >3 )
                txt_CountryCode.Text = txt_CountryCode.Text.Substring(0, 3);
        }

        private void txt_PassportNo_Leave(object sender, EventArgs e)
        {
            if(txt_PassportNo.Text.Equals(""))
            {
                if(txt_PassportNo.Text.Length > 10)
                {
                    MessageBox.Show(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/ValidatePassportNo"));
                }
                else if (txt_PassportNo.Text.Length < 6)
                {
                    MessageBox.Show(Constants.CONF_MANAGER.getCustomValue("Message", Constants.SYSTEM_LANGUAGE + "/ValidatePassportNo"));
                }
            }
        }

        private void txt_PassportNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txt_PassportNo.Text.Length > 10)
            {
                e.Handled = true;
            }
        }
    }
}
