﻿namespace GTF_STFM.Screen
{
    partial class IssuePanel_SG
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssuePanel_SG));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BTN_SCAN = new MetroFramework.Controls.MetroButton();
            this.GRD_ITEMS = new MetroFramework.Controls.MetroGrid();
            this.BTN_ITEM_DEL = new MetroFramework.Controls.MetroButton();
            this.BTN_ITEM_ADD = new MetroFramework.Controls.MetroButton();
            this.txt_PassportNo = new MetroFramework.Controls.MetroTextBox();
            this.LAY_PASSPORT = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_PassportNo = new MetroFramework.Controls.MetroLabel();
            this.lbl_Nationality = new MetroFramework.Controls.MetroLabel();
            this.txt_CountryCode = new MetroFramework.Controls.MetroTextBox();
            this.lbl_FirstName = new MetroFramework.Controls.MetroLabel();
            this.lbl_LastName = new MetroFramework.Controls.MetroLabel();
            this.txt_FirstName = new MetroFramework.Controls.MetroTextBox();
            this.txt_LastName = new MetroFramework.Controls.MetroTextBox();
            this.cmbbox_Token = new System.Windows.Forms.ComboBox();
            this.metroLbl_Token = new MetroFramework.Controls.MetroLabel();
            this.txt_DisplayCardNo = new System.Windows.Forms.TextBox();
            this.txt_Dummy = new System.Windows.Forms.TextBox();
            this.BTN_ISSUE = new MetroFramework.Controls.MetroButton();
            this.BTN_CLEAR = new MetroFramework.Controls.MetroButton();
            this.txt_CardNo = new System.Windows.Forms.TextBox();
            this.BTN_INPUT = new MetroFramework.Controls.MetroButton();
            this.TIL_1 = new MetroFramework.Controls.MetroTile();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.LAY_COMMAND = new System.Windows.Forms.TableLayoutPanel();
            this.TIL_2 = new MetroFramework.Controls.MetroTile();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Outlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSTNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Approved = new System.Windows.Forms.DataGridViewImageColumn();
            this.Reason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_ITEMS)).BeginInit();
            this.LAY_PASSPORT.SuspendLayout();
            this.LAY_COMMAND.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTN_SCAN
            // 
            this.BTN_SCAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SCAN.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_SCAN.Location = new System.Drawing.Point(493, 3);
            this.BTN_SCAN.Name = "BTN_SCAN";
            this.BTN_SCAN.Size = new System.Drawing.Size(99, 28);
            this.BTN_SCAN.TabIndex = 0;
            this.BTN_SCAN.Text = "Read Passport";
            this.BTN_SCAN.UseSelectable = true;
            // 
            // GRD_ITEMS
            // 
            this.GRD_ITEMS.AllowUserToAddRows = false;
            this.GRD_ITEMS.AllowUserToDeleteRows = false;
            this.GRD_ITEMS.AllowUserToResizeRows = false;
            this.GRD_ITEMS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRD_ITEMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRD_ITEMS.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRD_ITEMS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD_ITEMS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.GRD_ITEMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_ITEMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Outlet,
            this.StoreName,
            this.GSTNo,
            this.ReceiptNumber,
            this.PurchaseDate,
            this.PurchaseAmount,
            this.Quantity,
            this.PurchaseItem,
            this.TID,
            this.MID,
            this.Approved,
            this.Reason,
            this.ResCode});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD_ITEMS.DefaultCellStyle = dataGridViewCellStyle11;
            this.GRD_ITEMS.EnableHeadersVisualStyles = false;
            this.GRD_ITEMS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GRD_ITEMS.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRD_ITEMS.Location = new System.Drawing.Point(10, 209);
            this.GRD_ITEMS.Name = "GRD_ITEMS";
            this.GRD_ITEMS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD_ITEMS.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GRD_ITEMS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRD_ITEMS.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.GRD_ITEMS.RowTemplate.Height = 23;
            this.GRD_ITEMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRD_ITEMS.Size = new System.Drawing.Size(767, 476);
            this.GRD_ITEMS.Style = MetroFramework.MetroColorStyle.Orange;
            this.GRD_ITEMS.TabIndex = 7;
            this.GRD_ITEMS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_ITEMS_CellClick);
            // 
            // BTN_ITEM_DEL
            // 
            this.BTN_ITEM_DEL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_ITEM_DEL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ITEM_DEL.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_ITEM_DEL.Location = new System.Drawing.Point(119, 3);
            this.BTN_ITEM_DEL.Name = "BTN_ITEM_DEL";
            this.BTN_ITEM_DEL.Size = new System.Drawing.Size(106, 26);
            this.BTN_ITEM_DEL.TabIndex = 99;
            this.BTN_ITEM_DEL.Text = "Remove Receipt";
            this.BTN_ITEM_DEL.UseSelectable = true;
            this.BTN_ITEM_DEL.Click += new System.EventHandler(this.BTN_ITEM_DEL_Click);
            // 
            // BTN_ITEM_ADD
            // 
            this.BTN_ITEM_ADD.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BTN_ITEM_ADD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ITEM_ADD.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_ITEM_ADD.Location = new System.Drawing.Point(5, 3);
            this.BTN_ITEM_ADD.Name = "BTN_ITEM_ADD";
            this.BTN_ITEM_ADD.Size = new System.Drawing.Size(106, 26);
            this.BTN_ITEM_ADD.TabIndex = 4;
            this.BTN_ITEM_ADD.Text = "Add Receipt";
            this.BTN_ITEM_ADD.UseSelectable = true;
            this.BTN_ITEM_ADD.Click += new System.EventHandler(this.BTN_ITEM_ADD_Click);
            // 
            // txt_PassportNo
            // 
            this.txt_PassportNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_PassportNo.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_PassportNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_PassportNo.CustomButton.Image = null;
            this.txt_PassportNo.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.txt_PassportNo.CustomButton.Name = "";
            this.txt_PassportNo.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_PassportNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_PassportNo.CustomButton.TabIndex = 1;
            this.txt_PassportNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_PassportNo.CustomButton.UseSelectable = true;
            this.txt_PassportNo.CustomButton.Visible = false;
            this.txt_PassportNo.Enabled = false;
            this.txt_PassportNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_PassportNo.Lines = new string[0];
            this.txt_PassportNo.Location = new System.Drawing.Point(108, 3);
            this.txt_PassportNo.MaxLength = 32767;
            this.txt_PassportNo.Name = "txt_PassportNo";
            this.txt_PassportNo.PasswordChar = '\0';
            this.txt_PassportNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_PassportNo.SelectedText = "";
            this.txt_PassportNo.SelectionLength = 0;
            this.txt_PassportNo.SelectionStart = 0;
            this.txt_PassportNo.ShortcutsEnabled = true;
            this.txt_PassportNo.Size = new System.Drawing.Size(120, 28);
            this.txt_PassportNo.Style = MetroFramework.MetroColorStyle.Orange;
            this.txt_PassportNo.TabIndex = 1;
            this.txt_PassportNo.UseSelectable = true;
            this.txt_PassportNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_PassportNo.WaterMarkFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PassportNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PassportNo_KeyPress);
            this.txt_PassportNo.Leave += new System.EventHandler(this.txt_PassportNo_Leave);
            // 
            // LAY_PASSPORT
            // 
            this.LAY_PASSPORT.ColumnCount = 7;
            this.LAY_PASSPORT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.LAY_PASSPORT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.LAY_PASSPORT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.LAY_PASSPORT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.LAY_PASSPORT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.LAY_PASSPORT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.LAY_PASSPORT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.LAY_PASSPORT.Controls.Add(this.lbl_PassportNo, 0, 0);
            this.LAY_PASSPORT.Controls.Add(this.lbl_Nationality, 0, 1);
            this.LAY_PASSPORT.Controls.Add(this.txt_PassportNo, 1, 0);
            this.LAY_PASSPORT.Controls.Add(this.txt_CountryCode, 1, 1);
            this.LAY_PASSPORT.Controls.Add(this.lbl_FirstName, 2, 0);
            this.LAY_PASSPORT.Controls.Add(this.lbl_LastName, 2, 1);
            this.LAY_PASSPORT.Controls.Add(this.txt_FirstName, 3, 0);
            this.LAY_PASSPORT.Controls.Add(this.txt_LastName, 3, 1);
            this.LAY_PASSPORT.Controls.Add(this.cmbbox_Token, 1, 2);
            this.LAY_PASSPORT.Controls.Add(this.metroLbl_Token, 0, 2);
            this.LAY_PASSPORT.Controls.Add(this.txt_DisplayCardNo, 2, 2);
            this.LAY_PASSPORT.Controls.Add(this.txt_Dummy, 6, 2);
            this.LAY_PASSPORT.Controls.Add(this.BTN_SCAN, 4, 0);
            this.LAY_PASSPORT.Controls.Add(this.BTN_ISSUE, 6, 0);
            this.LAY_PASSPORT.Controls.Add(this.BTN_CLEAR, 6, 1);
            this.LAY_PASSPORT.Controls.Add(this.txt_CardNo, 4, 2);
            this.LAY_PASSPORT.Controls.Add(this.BTN_INPUT, 4, 1);
            this.LAY_PASSPORT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAY_PASSPORT.Location = new System.Drawing.Point(11, 46);
            this.LAY_PASSPORT.Name = "LAY_PASSPORT";
            this.LAY_PASSPORT.RowCount = 3;
            this.LAY_PASSPORT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.16196F));
            this.LAY_PASSPORT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.16196F));
            this.LAY_PASSPORT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.67609F));
            this.LAY_PASSPORT.Size = new System.Drawing.Size(765, 105);
            this.LAY_PASSPORT.TabIndex = 7;
            // 
            // lbl_PassportNo
            // 
            this.lbl_PassportNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PassportNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_PassportNo.Location = new System.Drawing.Point(3, 5);
            this.lbl_PassportNo.Name = "lbl_PassportNo";
            this.lbl_PassportNo.Size = new System.Drawing.Size(99, 23);
            this.lbl_PassportNo.TabIndex = 0;
            this.lbl_PassportNo.Text = "Passport No :";
            this.lbl_PassportNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Nationality
            // 
            this.lbl_Nationality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Nationality.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Nationality.Location = new System.Drawing.Point(3, 40);
            this.lbl_Nationality.Name = "lbl_Nationality";
            this.lbl_Nationality.Size = new System.Drawing.Size(99, 21);
            this.lbl_Nationality.TabIndex = 5;
            this.lbl_Nationality.Text = "Nationality :";
            this.lbl_Nationality.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CountryCode
            // 
            this.txt_CountryCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CountryCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_CountryCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_CountryCode.BackColor = System.Drawing.Color.Gainsboro;
            this.txt_CountryCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // 
            // 
            this.txt_CountryCode.CustomButton.Image = null;
            this.txt_CountryCode.CustomButton.Location = new System.Drawing.Point(94, 2);
            this.txt_CountryCode.CustomButton.Name = "";
            this.txt_CountryCode.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_CountryCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_CountryCode.CustomButton.TabIndex = 1;
            this.txt_CountryCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_CountryCode.CustomButton.UseSelectable = true;
            this.txt_CountryCode.CustomButton.Visible = false;
            this.txt_CountryCode.Enabled = false;
            this.txt_CountryCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_CountryCode.Lines = new string[0];
            this.txt_CountryCode.Location = new System.Drawing.Point(108, 37);
            this.txt_CountryCode.MaxLength = 32767;
            this.txt_CountryCode.Name = "txt_CountryCode";
            this.txt_CountryCode.PasswordChar = '\0';
            this.txt_CountryCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_CountryCode.SelectedText = "";
            this.txt_CountryCode.SelectionLength = 0;
            this.txt_CountryCode.SelectionStart = 0;
            this.txt_CountryCode.ShortcutsEnabled = true;
            this.txt_CountryCode.Size = new System.Drawing.Size(120, 28);
            this.txt_CountryCode.Style = MetroFramework.MetroColorStyle.Orange;
            this.txt_CountryCode.TabIndex = 2;
            this.txt_CountryCode.UseSelectable = true;
            this.txt_CountryCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_CountryCode.WaterMarkFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CountryCode.Leave += new System.EventHandler(this.txt_CountryCode_Leave);
            // 
            // lbl_FirstName
            // 
            this.lbl_FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_FirstName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_FirstName.Location = new System.Drawing.Point(239, 5);
            this.lbl_FirstName.Name = "lbl_FirstName";
            this.lbl_FirstName.Size = new System.Drawing.Size(99, 23);
            this.lbl_FirstName.TabIndex = 99;
            this.lbl_FirstName.Text = "First Name :";
            this.lbl_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_LastName
            // 
            this.lbl_LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_LastName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_LastName.Location = new System.Drawing.Point(239, 39);
            this.lbl_LastName.Name = "lbl_LastName";
            this.lbl_LastName.Size = new System.Drawing.Size(99, 23);
            this.lbl_LastName.TabIndex = 99;
            this.lbl_LastName.Text = "Last Name :";
            this.lbl_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_FirstName.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txt_FirstName.CustomButton.Image = null;
            this.txt_FirstName.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.txt_FirstName.CustomButton.Name = "";
            this.txt_FirstName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_FirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_FirstName.CustomButton.TabIndex = 1;
            this.txt_FirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_FirstName.CustomButton.UseSelectable = true;
            this.txt_FirstName.CustomButton.Visible = false;
            this.txt_FirstName.Enabled = false;
            this.txt_FirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_FirstName.Lines = new string[0];
            this.txt_FirstName.Location = new System.Drawing.Point(344, 3);
            this.txt_FirstName.MaxLength = 32767;
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.PasswordChar = '\0';
            this.txt_FirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_FirstName.SelectedText = "";
            this.txt_FirstName.SelectionLength = 0;
            this.txt_FirstName.SelectionStart = 0;
            this.txt_FirstName.ShortcutsEnabled = true;
            this.txt_FirstName.Size = new System.Drawing.Size(143, 28);
            this.txt_FirstName.Style = MetroFramework.MetroColorStyle.Orange;
            this.txt_FirstName.TabIndex = 99;
            this.txt_FirstName.UseSelectable = true;
            this.txt_FirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_FirstName.WaterMarkFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_LastName
            // 
            this.txt_LastName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_LastName.BackColor = System.Drawing.Color.Gainsboro;
            // 
            // 
            // 
            this.txt_LastName.CustomButton.Image = null;
            this.txt_LastName.CustomButton.Location = new System.Drawing.Point(117, 2);
            this.txt_LastName.CustomButton.Name = "";
            this.txt_LastName.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.txt_LastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txt_LastName.CustomButton.TabIndex = 1;
            this.txt_LastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txt_LastName.CustomButton.UseSelectable = true;
            this.txt_LastName.CustomButton.Visible = false;
            this.txt_LastName.Enabled = false;
            this.txt_LastName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txt_LastName.Lines = new string[0];
            this.txt_LastName.Location = new System.Drawing.Point(344, 37);
            this.txt_LastName.MaxLength = 32767;
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.PasswordChar = '\0';
            this.txt_LastName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txt_LastName.SelectedText = "";
            this.txt_LastName.SelectionLength = 0;
            this.txt_LastName.SelectionStart = 0;
            this.txt_LastName.ShortcutsEnabled = true;
            this.txt_LastName.Size = new System.Drawing.Size(143, 28);
            this.txt_LastName.Style = MetroFramework.MetroColorStyle.Orange;
            this.txt_LastName.TabIndex = 99;
            this.txt_LastName.UseSelectable = true;
            this.txt_LastName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txt_LastName.WaterMarkFont = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // cmbbox_Token
            // 
            this.cmbbox_Token.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbbox_Token.FormattingEnabled = true;
            this.cmbbox_Token.Location = new System.Drawing.Point(108, 76);
            this.cmbbox_Token.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbox_Token.Name = "cmbbox_Token";
            this.cmbbox_Token.Size = new System.Drawing.Size(120, 27);
            this.cmbbox_Token.TabIndex = 3;
            this.cmbbox_Token.SelectedIndexChanged += new System.EventHandler(this.cmbbox_Token_SelectedIndexChanged);
            // 
            // metroLbl_Token
            // 
            this.metroLbl_Token.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLbl_Token.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLbl_Token.Location = new System.Drawing.Point(3, 76);
            this.metroLbl_Token.Name = "metroLbl_Token";
            this.metroLbl_Token.Size = new System.Drawing.Size(99, 21);
            this.metroLbl_Token.TabIndex = 10;
            this.metroLbl_Token.Text = "Token :";
            this.metroLbl_Token.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_DisplayCardNo
            // 
            this.txt_DisplayCardNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LAY_PASSPORT.SetColumnSpan(this.txt_DisplayCardNo, 2);
            this.txt_DisplayCardNo.Location = new System.Drawing.Point(239, 73);
            this.txt_DisplayCardNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DisplayCardNo.Name = "txt_DisplayCardNo";
            this.txt_DisplayCardNo.ReadOnly = true;
            this.txt_DisplayCardNo.Size = new System.Drawing.Size(233, 27);
            this.txt_DisplayCardNo.TabIndex = 100;
            // 
            // txt_Dummy
            // 
            this.txt_Dummy.Location = new System.Drawing.Point(642, 70);
            this.txt_Dummy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Dummy.Name = "txt_Dummy";
            this.txt_Dummy.Size = new System.Drawing.Size(1, 27);
            this.txt_Dummy.TabIndex = 112;
            // 
            // BTN_ISSUE
            // 
            this.BTN_ISSUE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BTN_ISSUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ISSUE.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_ISSUE.Location = new System.Drawing.Point(642, 4);
            this.BTN_ISSUE.Name = "BTN_ISSUE";
            this.BTN_ISSUE.Size = new System.Drawing.Size(106, 26);
            this.BTN_ISSUE.TabIndex = 5;
            this.BTN_ISSUE.Text = "Issue All";
            this.BTN_ISSUE.UseSelectable = true;
            this.BTN_ISSUE.Click += new System.EventHandler(this.BTN_ISSUE_Click);
            // 
            // BTN_CLEAR
            // 
            this.BTN_CLEAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_CLEAR.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_CLEAR.Location = new System.Drawing.Point(642, 37);
            this.BTN_CLEAR.Name = "BTN_CLEAR";
            this.BTN_CLEAR.Size = new System.Drawing.Size(106, 26);
            this.BTN_CLEAR.TabIndex = 99;
            this.BTN_CLEAR.Text = "Reset";
            this.BTN_CLEAR.UseSelectable = true;
            this.BTN_CLEAR.Click += new System.EventHandler(this.BTN_CLEAR_Click);
            // 
            // txt_CardNo
            // 
            this.txt_CardNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CardNo.Location = new System.Drawing.Point(493, 73);
            this.txt_CardNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CardNo.Name = "txt_CardNo";
            this.txt_CardNo.ReadOnly = true;
            this.txt_CardNo.Size = new System.Drawing.Size(99, 27);
            this.txt_CardNo.TabIndex = 100;
            this.txt_CardNo.Visible = false;
            // 
            // BTN_INPUT
            // 
            this.BTN_INPUT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_INPUT.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_INPUT.Location = new System.Drawing.Point(493, 37);
            this.BTN_INPUT.Name = "BTN_INPUT";
            this.BTN_INPUT.Size = new System.Drawing.Size(99, 28);
            this.BTN_INPUT.TabIndex = 113;
            this.BTN_INPUT.Text = "Input Passport";
            this.BTN_INPUT.UseSelectable = true;
            this.BTN_INPUT.Click += new System.EventHandler(this.BTN_INPUT_Click);
            // 
            // TIL_1
            // 
            this.TIL_1.ActiveControl = null;
            this.TIL_1.Enabled = false;
            this.TIL_1.Location = new System.Drawing.Point(10, 34);
            this.TIL_1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_1.Name = "TIL_1";
            this.TIL_1.Size = new System.Drawing.Size(766, 2);
            this.TIL_1.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_1.TabIndex = 0;
            this.TIL_1.TabStop = false;
            this.TIL_1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_1.UseSelectable = true;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Approved";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Calibri", 13.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(13, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(182, 23);
            this.lbl_Title.TabIndex = 104;
            this.lbl_Title.Text = "Mutiple-MID Issuance";
            // 
            // LAY_COMMAND
            // 
            this.LAY_COMMAND.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LAY_COMMAND.ColumnCount = 5;
            this.LAY_COMMAND.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.LAY_COMMAND.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.LAY_COMMAND.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.LAY_COMMAND.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.LAY_COMMAND.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.LAY_COMMAND.Controls.Add(this.BTN_ITEM_ADD, 0, 0);
            this.LAY_COMMAND.Controls.Add(this.BTN_ITEM_DEL, 1, 0);
            this.LAY_COMMAND.Location = new System.Drawing.Point(10, 168);
            this.LAY_COMMAND.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LAY_COMMAND.Name = "LAY_COMMAND";
            this.LAY_COMMAND.RowCount = 1;
            this.LAY_COMMAND.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAY_COMMAND.Size = new System.Drawing.Size(767, 33);
            this.LAY_COMMAND.TabIndex = 1;
            // 
            // TIL_2
            // 
            this.TIL_2.ActiveControl = null;
            this.TIL_2.Enabled = false;
            this.TIL_2.Location = new System.Drawing.Point(11, 160);
            this.TIL_2.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_2.Name = "TIL_2";
            this.TIL_2.Size = new System.Drawing.Size(766, 2);
            this.TIL_2.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_2.TabIndex = 103;
            this.TIL_2.TabStop = false;
            this.TIL_2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_2.UseSelectable = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Selected";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Column1.Width = 81;
            // 
            // Outlet
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outlet.DefaultCellStyle = dataGridViewCellStyle2;
            this.Outlet.HeaderText = "Outlet";
            this.Outlet.Name = "Outlet";
            this.Outlet.ReadOnly = true;
            this.Outlet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Outlet.Width = 80;
            // 
            // StoreName
            // 
            this.StoreName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "0";
            this.StoreName.DefaultCellStyle = dataGridViewCellStyle3;
            this.StoreName.HeaderText = "Store Name";
            this.StoreName.Name = "StoreName";
            this.StoreName.ReadOnly = true;
            // 
            // GSTNo
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Format = "C0";
            this.GSTNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.GSTNo.HeaderText = "GST No";
            this.GSTNo.Name = "GSTNo";
            this.GSTNo.ReadOnly = true;
            this.GSTNo.Width = 90;
            // 
            // ReceiptNumber
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ReceiptNumber.DefaultCellStyle = dataGridViewCellStyle5;
            this.ReceiptNumber.HeaderText = "Receipt Number";
            this.ReceiptNumber.Name = "ReceiptNumber";
            this.ReceiptNumber.ReadOnly = true;
            this.ReceiptNumber.Width = 150;
            // 
            // PurchaseDate
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PurchaseDate.DefaultCellStyle = dataGridViewCellStyle6;
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            // 
            // PurchaseAmount
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle7.Format = "N0";
            dataGridViewCellStyle7.NullValue = "0";
            this.PurchaseAmount.DefaultCellStyle = dataGridViewCellStyle7;
            this.PurchaseAmount.HeaderText = "Purchase Amount(SGD)";
            this.PurchaseAmount.Name = "PurchaseAmount";
            this.PurchaseAmount.ReadOnly = true;
            // 
            // Quantity
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Quantity.DefaultCellStyle = dataGridViewCellStyle8;
            this.Quantity.HeaderText = "Qty";
            this.Quantity.Name = "Quantity";
            this.Quantity.Visible = false;
            // 
            // PurchaseItem
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PurchaseItem.DefaultCellStyle = dataGridViewCellStyle9;
            this.PurchaseItem.HeaderText = "Purchase Item";
            this.PurchaseItem.Name = "PurchaseItem";
            this.PurchaseItem.Visible = false;
            // 
            // TID
            // 
            this.TID.HeaderText = "TID";
            this.TID.Name = "TID";
            this.TID.Visible = false;
            // 
            // MID
            // 
            this.MID.HeaderText = "MID";
            this.MID.Name = "MID";
            this.MID.Visible = false;
            // 
            // Approved
            // 
            this.Approved.HeaderText = "Approved";
            this.Approved.Image = ((System.Drawing.Image)(resources.GetObject("Approved.Image")));
            this.Approved.Name = "Approved";
            this.Approved.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Approved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Approved.Width = 80;
            // 
            // Reason
            // 
            this.Reason.HeaderText = "Reason";
            this.Reason.Name = "Reason";
            this.Reason.Width = 170;
            // 
            // ResCode
            // 
            dataGridViewCellStyle10.NullValue = "99";
            this.ResCode.DefaultCellStyle = dataGridViewCellStyle10;
            this.ResCode.HeaderText = "Response Code";
            this.ResCode.Name = "ResCode";
            this.ResCode.Visible = false;
            // 
            // IssuePanel_SG
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LAY_COMMAND);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.TIL_2);
            this.Controls.Add(this.TIL_1);
            this.Controls.Add(this.LAY_PASSPORT);
            this.Controls.Add(this.GRD_ITEMS);
            this.Name = "IssuePanel_SG";
            this.Size = new System.Drawing.Size(788, 706);
            this.Load += new System.EventHandler(this.IssuePanel_Load);
            this.SizeChanged += new System.EventHandler(this.IssuePanel_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_ITEMS)).EndInit();
            this.LAY_PASSPORT.ResumeLayout(false);
            this.LAY_PASSPORT.PerformLayout();
            this.LAY_COMMAND.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroGrid GRD_ITEMS;
        private MetroFramework.Controls.MetroButton BTN_ITEM_DEL;
        private MetroFramework.Controls.MetroButton BTN_ITEM_ADD;
        private MetroFramework.Controls.MetroTextBox txt_PassportNo;
        private System.Windows.Forms.TableLayoutPanel LAY_PASSPORT;
        private MetroFramework.Controls.MetroTextBox txt_CountryCode;
        private MetroFramework.Controls.MetroTile TIL_1;
        private MetroFramework.Controls.MetroButton BTN_SCAN;
        private MetroFramework.Controls.MetroLabel lbl_Nationality;
        private MetroFramework.Controls.MetroLabel lbl_PassportNo;
        private MetroFramework.Controls.MetroLabel metroLbl_Token;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lbl_Title;
        private MetroFramework.Controls.MetroLabel lbl_FirstName;
        private MetroFramework.Controls.MetroLabel lbl_LastName;
        private MetroFramework.Controls.MetroTextBox txt_FirstName;
        private MetroFramework.Controls.MetroTextBox txt_LastName;
        private System.Windows.Forms.ComboBox cmbbox_Token;
        private System.Windows.Forms.TextBox txt_Track2;
        private System.Windows.Forms.TextBox txt_DisplayCardNo;
        private System.Windows.Forms.TextBox txt_CardNo;
        private System.Windows.Forms.TextBox txt_Dummy;
        private System.Windows.Forms.TableLayoutPanel LAY_COMMAND;
        private MetroFramework.Controls.MetroTile TIL_2;
        private MetroFramework.Controls.MetroButton BTN_CLEAR;
        private MetroFramework.Controls.MetroButton BTN_ISSUE;
        private MetroFramework.Controls.MetroButton BTN_INPUT;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn TID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MID;
        private System.Windows.Forms.DataGridViewImageColumn Approved;
        private System.Windows.Forms.DataGridViewTextBoxColumn Reason;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResCode;
    }
}
