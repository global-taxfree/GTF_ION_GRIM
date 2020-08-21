namespace GTF_STFM.Screen
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.TIL_NETWORK = new MetroFramework.Controls.MetroTile();
            this.TIL_USERNAME = new MetroFramework.Controls.MetroTile();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.TIL_VOID = new MetroFramework.Controls.MetroTile();
            this.TIL_ISSUE = new MetroFramework.Controls.MetroTile();
            this.TIL_PRE = new MetroFramework.Controls.MetroTile();
            this.TIL_SEARCH = new MetroFramework.Controls.MetroTile();
            this.TIL_LINE_1 = new MetroFramework.Controls.MetroTile();
            this.pictureBox_Outlet = new System.Windows.Forms.PictureBox();
            this.label_Copyright = new System.Windows.Forms.Label();
            this.TIL_EMPTY_2 = new MetroFramework.Controls.MetroTile();
            this.TIL_EMPTY_1 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Outlet)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(122, 100);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(428, 80);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroPanel2.TabIndex = 0;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(122, 186);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(430, 75);
            this.metroPanel3.TabIndex = 0;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // TIL_NETWORK
            // 
            this.TIL_NETWORK.ActiveControl = null;
            this.TIL_NETWORK.Location = new System.Drawing.Point(0, 605);
            this.TIL_NETWORK.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_NETWORK.Name = "TIL_NETWORK";
            this.TIL_NETWORK.Size = new System.Drawing.Size(112, 54);
            this.TIL_NETWORK.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_NETWORK.TabIndex = 44;
            this.TIL_NETWORK.TabStop = false;
            this.TIL_NETWORK.Text = "Online";
            this.TIL_NETWORK.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TIL_NETWORK.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_NETWORK.UseSelectable = true;
            this.TIL_NETWORK.UseTileImage = true;
            this.TIL_NETWORK.Click += new System.EventHandler(this.TIL_NETWORK_Click);
            // 
            // TIL_USERNAME
            // 
            this.TIL_USERNAME.ActiveControl = null;
            this.TIL_USERNAME.Enabled = false;
            this.TIL_USERNAME.Location = new System.Drawing.Point(0, 551);
            this.TIL_USERNAME.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_USERNAME.Name = "TIL_USERNAME";
            this.TIL_USERNAME.Size = new System.Drawing.Size(112, 54);
            this.TIL_USERNAME.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_USERNAME.TabIndex = 3;
            this.TIL_USERNAME.TabStop = false;
            this.TIL_USERNAME.Text = "User Name";
            this.TIL_USERNAME.TileImage = ((System.Drawing.Image)(resources.GetObject("TIL_USERNAME.TileImage")));
            this.TIL_USERNAME.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TIL_USERNAME.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_USERNAME.UseSelectable = true;
            this.TIL_USERNAME.Click += new System.EventHandler(this.TIL_USERNAME_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(122, 7);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(428, 86);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(122, 268);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(430, 75);
            this.metroPanel4.TabIndex = 2;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // TIL_VOID
            // 
            this.TIL_VOID.ActiveControl = null;
            this.TIL_VOID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIL_VOID.Location = new System.Drawing.Point(0, 60);
            this.TIL_VOID.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_VOID.Name = "TIL_VOID";
            this.TIL_VOID.Size = new System.Drawing.Size(112, 54);
            this.TIL_VOID.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_VOID.TabIndex = 47;
            this.TIL_VOID.TabStop = false;
            this.TIL_VOID.Text = "Void";
            this.TIL_VOID.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TIL_VOID.TileImage = ((System.Drawing.Image)(resources.GetObject("TIL_VOID.TileImage")));
            this.TIL_VOID.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TIL_VOID.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_VOID.UseSelectable = true;
            this.TIL_VOID.UseTileImage = true;
            this.TIL_VOID.Click += new System.EventHandler(this.TIL_VOID_Click);
            // 
            // TIL_ISSUE
            // 
            this.TIL_ISSUE.ActiveControl = null;
            this.TIL_ISSUE.BackColor = System.Drawing.Color.LightSalmon;
            this.TIL_ISSUE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIL_ISSUE.Location = new System.Drawing.Point(0, 5);
            this.TIL_ISSUE.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_ISSUE.Name = "TIL_ISSUE";
            this.TIL_ISSUE.PaintTileCount = false;
            this.TIL_ISSUE.Size = new System.Drawing.Size(112, 54);
            this.TIL_ISSUE.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_ISSUE.TabIndex = 40;
            this.TIL_ISSUE.TabStop = false;
            this.TIL_ISSUE.Text = "Issue";
            this.TIL_ISSUE.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TIL_ISSUE.TileImage = ((System.Drawing.Image)(resources.GetObject("TIL_ISSUE.TileImage")));
            this.TIL_ISSUE.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TIL_ISSUE.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_ISSUE.UseSelectable = true;
            this.TIL_ISSUE.UseTileImage = true;
            this.TIL_ISSUE.Click += new System.EventHandler(this.TIL_ISSUE_Click);
            // 
            // TIL_PRE
            // 
            this.TIL_PRE.ActiveControl = null;
            this.TIL_PRE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIL_PRE.Location = new System.Drawing.Point(0, 170);
            this.TIL_PRE.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_PRE.Name = "TIL_PRE";
            this.TIL_PRE.Size = new System.Drawing.Size(112, 54);
            this.TIL_PRE.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_PRE.TabIndex = 42;
            this.TIL_PRE.TabStop = false;
            this.TIL_PRE.Text = "Setup";
            this.TIL_PRE.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TIL_PRE.TileImage = ((System.Drawing.Image)(resources.GetObject("TIL_PRE.TileImage")));
            this.TIL_PRE.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TIL_PRE.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_PRE.UseSelectable = true;
            this.TIL_PRE.UseTileImage = true;
            this.TIL_PRE.Click += new System.EventHandler(this.TIL_PRE_Click);
            // 
            // TIL_SEARCH
            // 
            this.TIL_SEARCH.ActiveControl = null;
            this.TIL_SEARCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TIL_SEARCH.Location = new System.Drawing.Point(0, 115);
            this.TIL_SEARCH.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_SEARCH.Name = "TIL_SEARCH";
            this.TIL_SEARCH.Size = new System.Drawing.Size(112, 54);
            this.TIL_SEARCH.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_SEARCH.TabIndex = 41;
            this.TIL_SEARCH.TabStop = false;
            this.TIL_SEARCH.Text = "Search";
            this.TIL_SEARCH.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.TIL_SEARCH.TileImage = ((System.Drawing.Image)(resources.GetObject("TIL_SEARCH.TileImage")));
            this.TIL_SEARCH.TileImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TIL_SEARCH.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_SEARCH.UseSelectable = true;
            this.TIL_SEARCH.UseTileImage = true;
            this.TIL_SEARCH.Click += new System.EventHandler(this.TIL_SEARCH_Click);
            // 
            // TIL_LINE_1
            // 
            this.TIL_LINE_1.ActiveControl = null;
            this.TIL_LINE_1.Enabled = false;
            this.TIL_LINE_1.Location = new System.Drawing.Point(113, 5);
            this.TIL_LINE_1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_LINE_1.Name = "TIL_LINE_1";
            this.TIL_LINE_1.Size = new System.Drawing.Size(5, 728);
            this.TIL_LINE_1.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_LINE_1.TabIndex = 45;
            this.TIL_LINE_1.TabStop = false;
            this.TIL_LINE_1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_LINE_1.UseSelectable = true;
            // 
            // pictureBox_Outlet
            // 
            this.pictureBox_Outlet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox_Outlet.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_Outlet.Image")));
            this.pictureBox_Outlet.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Outlet.InitialImage")));
            this.pictureBox_Outlet.Location = new System.Drawing.Point(20, 675);
            this.pictureBox_Outlet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_Outlet.Name = "pictureBox_Outlet";
            this.pictureBox_Outlet.Size = new System.Drawing.Size(71, 43);
            this.pictureBox_Outlet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox_Outlet.TabIndex = 0;
            this.pictureBox_Outlet.TabStop = false;
            // 
            // label_Copyright
            // 
            this.label_Copyright.AutoSize = true;
            this.label_Copyright.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Copyright.Location = new System.Drawing.Point(282, 704);
            this.label_Copyright.Name = "label_Copyright";
            this.label_Copyright.Size = new System.Drawing.Size(717, 14);
            this.label_Copyright.TabIndex = 48;
            this.label_Copyright.Text = "© 2017 GLOBAL TAXFREE PTE LTD. All Rights Reserved. 541 Orchard Road #17-01 Liat " +
    "Towers, Singapore 238881   TEL:+65-6221-7058";
            // 
            // TIL_EMPTY_2
            // 
            this.TIL_EMPTY_2.ActiveControl = null;
            this.TIL_EMPTY_2.Enabled = false;
            this.TIL_EMPTY_2.Location = new System.Drawing.Point(0, 659);
            this.TIL_EMPTY_2.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_EMPTY_2.Name = "TIL_EMPTY_2";
            this.TIL_EMPTY_2.Size = new System.Drawing.Size(112, 69);
            this.TIL_EMPTY_2.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_EMPTY_2.TabIndex = 7;
            this.TIL_EMPTY_2.TabStop = false;
            this.TIL_EMPTY_2.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_EMPTY_2.UseSelectable = true;
            this.TIL_EMPTY_2.Click += new System.EventHandler(this.TIL_EMPTY_1_Click);
            // 
            // TIL_EMPTY_1
            // 
            this.TIL_EMPTY_1.ActiveControl = null;
            this.TIL_EMPTY_1.Enabled = false;
            this.TIL_EMPTY_1.Location = new System.Drawing.Point(0, 223);
            this.TIL_EMPTY_1.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.TIL_EMPTY_1.Name = "TIL_EMPTY_1";
            this.TIL_EMPTY_1.Size = new System.Drawing.Size(112, 330);
            this.TIL_EMPTY_1.Style = MetroFramework.MetroColorStyle.Orange;
            this.TIL_EMPTY_1.TabIndex = 49;
            this.TIL_EMPTY_1.TabStop = false;
            this.TIL_EMPTY_1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.TIL_EMPTY_1.UseSelectable = true;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1195, 728);
            this.Controls.Add(this.TIL_EMPTY_1);
            this.Controls.Add(this.label_Copyright);
            this.Controls.Add(this.pictureBox_Outlet);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.TIL_VOID);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.TIL_LINE_1);
            this.Controls.Add(this.TIL_ISSUE);
            this.Controls.Add(this.TIL_NETWORK);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.TIL_PRE);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.TIL_SEARCH);
            this.Controls.Add(this.TIL_USERNAME);
            this.Controls.Add(this.TIL_EMPTY_2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(896, 560);
            this.Name = "Main";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.SizeChanged += new System.EventHandler(this.Main_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Outlet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroTile TIL_ISSUE;
        private MetroFramework.Controls.MetroTile TIL_NETWORK;
        private MetroFramework.Controls.MetroTile TIL_USERNAME;
        private MetroFramework.Controls.MetroTile TIL_PRE;
        private MetroFramework.Controls.MetroTile TIL_SEARCH;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTile TIL_VOID;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroTile TIL_LINE_1;
        private System.Windows.Forms.PictureBox pictureBox_Outlet;
        private System.Windows.Forms.Label label_Copyright;
        private MetroFramework.Controls.MetroTile TIL_EMPTY_2;
        private MetroFramework.Controls.MetroTile TIL_EMPTY_1;
    }
}