namespace GTF_STFM.Screen
{
    partial class SearchPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TIL_2 = new MetroFramework.Controls.MetroTile();
            this.GRD_SLIP = new MetroFramework.Controls.MetroGrid();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Outlet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GSTNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReceiptNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIL_1 = new MetroFramework.Controls.MetroTile();
            this.BTN_SEARCH = new MetroFramework.Controls.MetroButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.LAY_SEARCH = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_RESET = new MetroFramework.Controls.MetroButton();
            this.lbl_GSTNo = new MetroFramework.Controls.MetroLabel();
            this.lbl_Date = new MetroFramework.Controls.MetroLabel();
            this.metroLbl_DocId = new MetroFramework.Controls.MetroLabel();
            this.txt_StartDate = new MetroFramework.Controls.MetroDateTime();
            this.txt_EndDate = new MetroFramework.Controls.MetroDateTime();
            this.lbl_Delimiter = new MetroFramework.Controls.MetroLabel();
            this.lbl_InvoiceNo = new MetroFramework.Controls.MetroLabel();
            this.lbl_PurchaseAmt = new MetroFramework.Controls.MetroLabel();
            this.txt_InvoiceNo = new System.Windows.Forms.TextBox();
            this.txt_DocId = new System.Windows.Forms.MaskedTextBox();
            this.txt_GSTNo = new System.Windows.Forms.TextBox();
            this.txt_Company_Name = new MetroFramework.Controls.MetroLabel();
            this.txt_CompanyName = new System.Windows.Forms.TextBox();
            this.txt_PurchaseAmt = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txt_StoreName = new System.Windows.Forms.TextBox();
            this.LAY_PAGE = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Page = new MetroFramework.Controls.MetroLabel();
            this.cmbbox_Page = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_SLIP)).BeginInit();
            this.LAY_SEARCH.SuspendLayout();
            this.LAY_PAGE.SuspendLayout();
            this.SuspendLayout();
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
            this.TIL_2.TabIndex = 105;
            this.TIL_2.TabStop = false;
            this.TIL_2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_2.UseSelectable = true;
            // 
            // GRD_SLIP
            // 
            this.GRD_SLIP.AllowUserToAddRows = false;
            this.GRD_SLIP.AllowUserToDeleteRows = false;
            this.GRD_SLIP.AllowUserToResizeRows = false;
            this.GRD_SLIP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRD_SLIP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.GRD_SLIP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRD_SLIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GRD_SLIP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.GRD_SLIP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD_SLIP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.GRD_SLIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GRD_SLIP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Outlet,
            this.StoreName,
            this.GSTNo,
            this.ReceiptNo,
            this.PurchaseDate,
            this.PurchaseAmt,
            this.PurchaseItem,
            this.IssueDate,
            this.DocID,
            this.Status,
            this.StatusCode});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD_SLIP.DefaultCellStyle = dataGridViewCellStyle20;
            this.GRD_SLIP.EnableHeadersVisualStyles = false;
            this.GRD_SLIP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GRD_SLIP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.GRD_SLIP.Location = new System.Drawing.Point(10, 209);
            this.GRD_SLIP.Name = "GRD_SLIP";
            this.GRD_SLIP.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GRD_SLIP.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.GRD_SLIP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRD_SLIP.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.GRD_SLIP.RowTemplate.Height = 23;
            this.GRD_SLIP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GRD_SLIP.Size = new System.Drawing.Size(767, 460);
            this.GRD_SLIP.Style = MetroFramework.MetroColorStyle.Orange;
            this.GRD_SLIP.TabIndex = 106;
            this.GRD_SLIP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GRD_SLIP_CellClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.No.Frozen = true;
            this.No.HeaderText = "No.";
            this.No.Name = "No";
            this.No.Width = 33;
            // 
            // Outlet
            // 
            this.Outlet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Outlet.DefaultCellStyle = dataGridViewCellStyle13;
            this.Outlet.Frozen = true;
            this.Outlet.HeaderText = "Outlet";
            this.Outlet.Name = "Outlet";
            this.Outlet.ReadOnly = true;
            this.Outlet.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Outlet.Width = 40;
            // 
            // StoreName
            // 
            this.StoreName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.Format = "0";
            this.StoreName.DefaultCellStyle = dataGridViewCellStyle14;
            this.StoreName.HeaderText = "Store Name";
            this.StoreName.Name = "StoreName";
            this.StoreName.Width = 200;
            // 
            // GSTNo
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Format = "C0";
            this.GSTNo.DefaultCellStyle = dataGridViewCellStyle15;
            this.GSTNo.HeaderText = "GST No";
            this.GSTNo.Name = "GSTNo";
            this.GSTNo.ReadOnly = true;
            // 
            // ReceiptNo
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.ReceiptNo.DefaultCellStyle = dataGridViewCellStyle16;
            this.ReceiptNo.HeaderText = "Receipt Number";
            this.ReceiptNo.Name = "ReceiptNo";
            // 
            // PurchaseDate
            // 
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PurchaseDate.DefaultCellStyle = dataGridViewCellStyle17;
            this.PurchaseDate.HeaderText = "Purchase Date";
            this.PurchaseDate.Name = "PurchaseDate";
            // 
            // PurchaseAmt
            // 
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle18.NullValue = "0";
            this.PurchaseAmt.DefaultCellStyle = dataGridViewCellStyle18;
            this.PurchaseAmt.HeaderText = "Purchase Amount";
            this.PurchaseAmt.Name = "PurchaseAmt";
            // 
            // PurchaseItem
            // 
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.PurchaseItem.DefaultCellStyle = dataGridViewCellStyle19;
            this.PurchaseItem.HeaderText = "Purchase Item";
            this.PurchaseItem.Name = "PurchaseItem";
            // 
            // IssueDate
            // 
            this.IssueDate.HeaderText = "IssueDate";
            this.IssueDate.Name = "IssueDate";
            // 
            // DocID
            // 
            this.DocID.HeaderText = "Doc ID";
            this.DocID.Name = "DocID";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // StatusCode
            // 
            this.StatusCode.HeaderText = "Status Code";
            this.StatusCode.Name = "StatusCode";
            this.StatusCode.Visible = false;
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
            this.TIL_1.TabIndex = 107;
            this.TIL_1.TabStop = false;
            this.TIL_1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_1.UseSelectable = true;
            // 
            // BTN_SEARCH
            // 
            this.BTN_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_SEARCH.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_SEARCH.Location = new System.Drawing.Point(668, 3);
            this.BTN_SEARCH.Name = "BTN_SEARCH";
            this.BTN_SEARCH.Size = new System.Drawing.Size(102, 28);
            this.BTN_SEARCH.TabIndex = 108;
            this.BTN_SEARCH.Text = "Search";
            this.BTN_SEARCH.UseSelectable = true;
            this.BTN_SEARCH.Click += new System.EventHandler(this.BTN_SEARCH_Click);
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
            this.lbl_Title.Size = new System.Drawing.Size(215, 23);
            this.lbl_Title.TabIndex = 109;
            this.lbl_Title.Text = "e-TRS Ticket Status Search";
            // 
            // LAY_SEARCH
            // 
            this.LAY_SEARCH.ColumnCount = 8;
            this.LAY_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.LAY_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.LAY_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.LAY_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.LAY_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.LAY_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.LAY_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.LAY_SEARCH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.LAY_SEARCH.Controls.Add(this.BTN_RESET, 7, 1);
            this.LAY_SEARCH.Controls.Add(this.lbl_GSTNo, 0, 2);
            this.LAY_SEARCH.Controls.Add(this.lbl_Date, 0, 0);
            this.LAY_SEARCH.Controls.Add(this.metroLbl_DocId, 4, 0);
            this.LAY_SEARCH.Controls.Add(this.txt_StartDate, 1, 0);
            this.LAY_SEARCH.Controls.Add(this.txt_EndDate, 3, 0);
            this.LAY_SEARCH.Controls.Add(this.lbl_Delimiter, 2, 0);
            this.LAY_SEARCH.Controls.Add(this.lbl_InvoiceNo, 0, 1);
            this.LAY_SEARCH.Controls.Add(this.lbl_PurchaseAmt, 4, 1);
            this.LAY_SEARCH.Controls.Add(this.txt_InvoiceNo, 1, 1);
            this.LAY_SEARCH.Controls.Add(this.txt_DocId, 5, 0);
            this.LAY_SEARCH.Controls.Add(this.txt_GSTNo, 1, 2);
            this.LAY_SEARCH.Controls.Add(this.txt_Company_Name, 3, 2);
            this.LAY_SEARCH.Controls.Add(this.txt_CompanyName, 4, 2);
            this.LAY_SEARCH.Controls.Add(this.BTN_SEARCH, 7, 0);
            this.LAY_SEARCH.Controls.Add(this.txt_PurchaseAmt, 5, 1);
            this.LAY_SEARCH.Controls.Add(this.metroLabel1, 5, 2);
            this.LAY_SEARCH.Controls.Add(this.txt_StoreName, 6, 2);
            this.LAY_SEARCH.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAY_SEARCH.Location = new System.Drawing.Point(11, 46);
            this.LAY_SEARCH.Name = "LAY_SEARCH";
            this.LAY_SEARCH.RowCount = 3;
            this.LAY_SEARCH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.16196F));
            this.LAY_SEARCH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.16196F));
            this.LAY_SEARCH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.67609F));
            this.LAY_SEARCH.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAY_SEARCH.Size = new System.Drawing.Size(765, 105);
            this.LAY_SEARCH.TabIndex = 110;
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_RESET.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BTN_RESET.Location = new System.Drawing.Point(668, 37);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(102, 28);
            this.BTN_RESET.TabIndex = 115;
            this.BTN_RESET.Text = "Reset";
            this.BTN_RESET.UseSelectable = true;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // lbl_GSTNo
            // 
            this.lbl_GSTNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_GSTNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_GSTNo.Location = new System.Drawing.Point(3, 75);
            this.lbl_GSTNo.Name = "lbl_GSTNo";
            this.lbl_GSTNo.Size = new System.Drawing.Size(99, 23);
            this.lbl_GSTNo.TabIndex = 112;
            this.lbl_GSTNo.Text = "GST No. :";
            this.lbl_GSTNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_Date
            // 
            this.lbl_Date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Date.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_Date.Location = new System.Drawing.Point(3, 5);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(99, 23);
            this.lbl_Date.TabIndex = 100;
            this.lbl_Date.Text = "Issue Date :";
            this.lbl_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // metroLbl_DocId
            // 
            this.metroLbl_DocId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLbl_DocId.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLbl_DocId.Location = new System.Drawing.Point(336, 6);
            this.metroLbl_DocId.Name = "metroLbl_DocId";
            this.metroLbl_DocId.Size = new System.Drawing.Size(134, 21);
            this.metroLbl_DocId.TabIndex = 102;
            this.metroLbl_DocId.Text = "Doc ID :";
            this.metroLbl_DocId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_StartDate
            // 
            this.txt_StartDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_StartDate.CalendarFont = new System.Drawing.Font("Calibri Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StartDate.CustomFormat = "dd/MM/yyyy";
            this.txt_StartDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.txt_StartDate.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.txt_StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_StartDate.Location = new System.Drawing.Point(108, 3);
            this.txt_StartDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.txt_StartDate.Name = "txt_StartDate";
            this.txt_StartDate.Size = new System.Drawing.Size(95, 27);
            this.txt_StartDate.TabIndex = 0;
            // 
            // txt_EndDate
            // 
            this.txt_EndDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_EndDate.CalendarFont = new System.Drawing.Font("Calibri Light", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EndDate.CustomFormat = "dd/MM/yyyy";
            this.txt_EndDate.FontSize = MetroFramework.MetroDateTimeSize.Small;
            this.txt_EndDate.FontWeight = MetroFramework.MetroDateTimeWeight.Light;
            this.txt_EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txt_EndDate.Location = new System.Drawing.Point(235, 3);
            this.txt_EndDate.MinimumSize = new System.Drawing.Size(0, 25);
            this.txt_EndDate.Name = "txt_EndDate";
            this.txt_EndDate.Size = new System.Drawing.Size(95, 27);
            this.txt_EndDate.TabIndex = 106;
            // 
            // lbl_Delimiter
            // 
            this.lbl_Delimiter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Delimiter.Location = new System.Drawing.Point(209, 5);
            this.lbl_Delimiter.Name = "lbl_Delimiter";
            this.lbl_Delimiter.Size = new System.Drawing.Size(20, 23);
            this.lbl_Delimiter.TabIndex = 107;
            this.lbl_Delimiter.Text = "~";
            this.lbl_Delimiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_InvoiceNo
            // 
            this.lbl_InvoiceNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_InvoiceNo.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_InvoiceNo.Location = new System.Drawing.Point(3, 39);
            this.lbl_InvoiceNo.Name = "lbl_InvoiceNo";
            this.lbl_InvoiceNo.Size = new System.Drawing.Size(99, 23);
            this.lbl_InvoiceNo.TabIndex = 108;
            this.lbl_InvoiceNo.Text = "Invoice No. :";
            this.lbl_InvoiceNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_PurchaseAmt
            // 
            this.lbl_PurchaseAmt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PurchaseAmt.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lbl_PurchaseAmt.Location = new System.Drawing.Point(336, 39);
            this.lbl_PurchaseAmt.Name = "lbl_PurchaseAmt";
            this.lbl_PurchaseAmt.Size = new System.Drawing.Size(134, 23);
            this.lbl_PurchaseAmt.TabIndex = 109;
            this.lbl_PurchaseAmt.Text = "Purchase Amount :";
            this.lbl_PurchaseAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_InvoiceNo
            // 
            this.txt_InvoiceNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LAY_SEARCH.SetColumnSpan(this.txt_InvoiceNo, 3);
            this.txt_InvoiceNo.Location = new System.Drawing.Point(108, 36);
            this.txt_InvoiceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_InvoiceNo.MaxLength = 25;
            this.txt_InvoiceNo.Name = "txt_InvoiceNo";
            this.txt_InvoiceNo.Size = new System.Drawing.Size(222, 27);
            this.txt_InvoiceNo.TabIndex = 110;
            // 
            // txt_DocId
            // 
            this.txt_DocId.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LAY_SEARCH.SetColumnSpan(this.txt_DocId, 2);
            this.txt_DocId.Location = new System.Drawing.Point(476, 3);
            this.txt_DocId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_DocId.Mask = "000000.00000.0000.00000";
            this.txt_DocId.Name = "txt_DocId";
            this.txt_DocId.Size = new System.Drawing.Size(186, 27);
            this.txt_DocId.TabIndex = 104;
            // 
            // txt_GSTNo
            // 
            this.txt_GSTNo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_GSTNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LAY_SEARCH.SetColumnSpan(this.txt_GSTNo, 2);
            this.txt_GSTNo.Location = new System.Drawing.Point(108, 73);
            this.txt_GSTNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_GSTNo.MaxLength = 12;
            this.txt_GSTNo.Name = "txt_GSTNo";
            this.txt_GSTNo.Size = new System.Drawing.Size(121, 27);
            this.txt_GSTNo.TabIndex = 113;
            // 
            // txt_Company_Name
            // 
            this.txt_Company_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Company_Name.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.txt_Company_Name.Location = new System.Drawing.Point(235, 75);
            this.txt_Company_Name.Name = "txt_Company_Name";
            this.txt_Company_Name.Size = new System.Drawing.Size(95, 23);
            this.txt_Company_Name.TabIndex = 115;
            this.txt_Company_Name.Text = "Company :";
            this.txt_Company_Name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_CompanyName
            // 
            this.txt_CompanyName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_CompanyName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_CompanyName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_CompanyName.Location = new System.Drawing.Point(336, 73);
            this.txt_CompanyName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_CompanyName.Name = "txt_CompanyName";
            this.txt_CompanyName.Size = new System.Drawing.Size(134, 27);
            this.txt_CompanyName.TabIndex = 116;
            // 
            // txt_PurchaseAmt
            // 
            this.txt_PurchaseAmt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LAY_SEARCH.SetColumnSpan(this.txt_PurchaseAmt, 2);
            this.txt_PurchaseAmt.Location = new System.Drawing.Point(476, 37);
            this.txt_PurchaseAmt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PurchaseAmt.MaxLength = 13;
            this.txt_PurchaseAmt.Name = "txt_PurchaseAmt";
            this.txt_PurchaseAmt.Size = new System.Drawing.Size(186, 27);
            this.txt_PurchaseAmt.TabIndex = 114;
            this.txt_PurchaseAmt.TextChanged += new System.EventHandler(this.txt_PurchaseAmt_TextChanged);
            this.txt_PurchaseAmt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PurchaseAmt_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(476, 75);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 23);
            this.metroLabel1.TabIndex = 117;
            this.metroLabel1.Text = "Store :";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_StoreName
            // 
            this.txt_StoreName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_StoreName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.LAY_SEARCH.SetColumnSpan(this.txt_StoreName, 2);
            this.txt_StoreName.Location = new System.Drawing.Point(572, 71);
            this.txt_StoreName.Name = "txt_StoreName";
            this.txt_StoreName.Size = new System.Drawing.Size(193, 27);
            this.txt_StoreName.TabIndex = 118;
            // 
            // LAY_PAGE
            // 
            this.LAY_PAGE.ColumnCount = 2;
            this.LAY_PAGE.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.54244F));
            this.LAY_PAGE.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.45756F));
            this.LAY_PAGE.Controls.Add(this.lbl_Page, 0, 0);
            this.LAY_PAGE.Controls.Add(this.cmbbox_Page, 1, 0);
            this.LAY_PAGE.Location = new System.Drawing.Point(10, 170);
            this.LAY_PAGE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LAY_PAGE.Name = "LAY_PAGE";
            this.LAY_PAGE.RowCount = 1;
            this.LAY_PAGE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAY_PAGE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.LAY_PAGE.Size = new System.Drawing.Size(767, 33);
            this.LAY_PAGE.TabIndex = 114;
            // 
            // lbl_Page
            // 
            this.lbl_Page.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbl_Page.Location = new System.Drawing.Point(573, 6);
            this.lbl_Page.Name = "lbl_Page";
            this.lbl_Page.Size = new System.Drawing.Size(87, 21);
            this.lbl_Page.TabIndex = 112;
            this.lbl_Page.Text = "Page :";
            this.lbl_Page.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbbox_Page
            // 
            this.cmbbox_Page.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbbox_Page.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbox_Page.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbox_Page.FormattingEnabled = true;
            this.cmbbox_Page.Location = new System.Drawing.Point(666, 4);
            this.cmbbox_Page.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbbox_Page.Name = "cmbbox_Page";
            this.cmbbox_Page.Size = new System.Drawing.Size(78, 25);
            this.cmbbox_Page.TabIndex = 111;
            this.cmbbox_Page.SelectedIndexChanged += new System.EventHandler(this.cmbbox_Page_SelectedIndexChanged);
            // 
            // SearchPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LAY_PAGE);
            this.Controls.Add(this.LAY_SEARCH);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.TIL_1);
            this.Controls.Add(this.GRD_SLIP);
            this.Controls.Add(this.TIL_2);
            this.Name = "SearchPanel";
            this.Size = new System.Drawing.Size(788, 706);
            this.Load += new System.EventHandler(this.SearchPanel_Load);
            this.SizeChanged += new System.EventHandler(this.SearchPanel_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.GRD_SLIP)).EndInit();
            this.LAY_SEARCH.ResumeLayout(false);
            this.LAY_SEARCH.PerformLayout();
            this.LAY_PAGE.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTile TIL_2;
        private MetroFramework.Controls.MetroGrid GRD_SLIP;
        private MetroFramework.Controls.MetroTile TIL_1;
        private MetroFramework.Controls.MetroButton BTN_SEARCH;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TableLayoutPanel LAY_SEARCH;
        private MetroFramework.Controls.MetroLabel lbl_Date;
        private MetroFramework.Controls.MetroLabel metroLbl_DocId;
        private System.Windows.Forms.MaskedTextBox txt_DocId;
        private MetroFramework.Controls.MetroDateTime txt_StartDate;
        private MetroFramework.Controls.MetroDateTime txt_EndDate;
        private MetroFramework.Controls.MetroLabel lbl_Delimiter;
        private System.Windows.Forms.TableLayoutPanel LAY_PAGE;
        private MetroFramework.Controls.MetroLabel lbl_Page;
        private System.Windows.Forms.ComboBox cmbbox_Page;
        private MetroFramework.Controls.MetroLabel lbl_InvoiceNo;
        private MetroFramework.Controls.MetroLabel lbl_PurchaseAmt;
        private System.Windows.Forms.TextBox txt_InvoiceNo;
        private MetroFramework.Controls.MetroLabel lbl_GSTNo;
        private System.Windows.Forms.TextBox txt_GSTNo;
        private System.Windows.Forms.TextBox txt_PurchaseAmt;
        private MetroFramework.Controls.MetroLabel txt_Company_Name;
        private System.Windows.Forms.TextBox txt_CompanyName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox txt_StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Outlet;
        private System.Windows.Forms.DataGridViewTextBoxColumn StoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GSTNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReceiptNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusCode;
        private MetroFramework.Controls.MetroButton BTN_RESET;
    }
}
