namespace ScrapingTest
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSerachKW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnAscendingOrder = new System.Windows.Forms.Button();
            this.btnDescendingOrder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.chkKanrenKWClear = new System.Windows.Forms.CheckBox();
            this.btnBuy = new System.Windows.Forms.Button();
            this.lblMsg = new System.Windows.Forms.Label();
            this.btnGetPassword = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnKW = new System.Windows.Forms.Button();
            this.chkJufukuChk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdKaisou = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.操作マニュアルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.パスワードToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKensu = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKW = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblKWCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(422, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSerachKW
            // 
            this.txtSerachKW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtSerachKW.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSerachKW.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtSerachKW.Location = new System.Drawing.Point(161, 33);
            this.txtSerachKW.Name = "txtSerachKW";
            this.txtSerachKW.Size = new System.Drawing.Size(240, 26);
            this.txtSerachKW.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "キーワードを入力";
            // 
            // txtList
            // 
            this.txtList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtList.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtList.Location = new System.Drawing.Point(0, 109);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtList.Size = new System.Drawing.Size(679, 330);
            this.txtList.TabIndex = 7;
            // 
            // btnAscendingOrder
            // 
            this.btnAscendingOrder.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnAscendingOrder.Location = new System.Drawing.Point(3, 46);
            this.btnAscendingOrder.Name = "btnAscendingOrder";
            this.btnAscendingOrder.Size = new System.Drawing.Size(75, 27);
            this.btnAscendingOrder.TabIndex = 8;
            this.btnAscendingOrder.Text = "昇順";
            this.btnAscendingOrder.UseVisualStyleBackColor = true;
            this.btnAscendingOrder.Click += new System.EventHandler(this.btnAscendingOrder_Click);
            // 
            // btnDescendingOrder
            // 
            this.btnDescendingOrder.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnDescendingOrder.Location = new System.Drawing.Point(84, 47);
            this.btnDescendingOrder.Name = "btnDescendingOrder";
            this.btnDescendingOrder.Size = new System.Drawing.Size(75, 27);
            this.btnDescendingOrder.TabIndex = 9;
            this.btnDescendingOrder.Text = "降順";
            this.btnDescendingOrder.UseVisualStyleBackColor = true;
            this.btnDescendingOrder.Click += new System.EventHandler(this.btnDescendingOrder_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.chkKanrenKWClear);
            this.panel1.Controls.Add(this.btnBuy);
            this.panel1.Controls.Add(this.lblMsg);
            this.panel1.Controls.Add(this.btnGetPassword);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnKW);
            this.panel1.Controls.Add(this.chkJufukuChk);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmdKaisou);
            this.panel1.Controls.Add(this.txtSerachKW);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 150);
            this.panel1.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(531, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Q&Aリサーチ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkKanrenKWClear
            // 
            this.chkKanrenKWClear.AutoSize = true;
            this.chkKanrenKWClear.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkKanrenKWClear.Location = new System.Drawing.Point(22, 115);
            this.chkKanrenKWClear.Name = "chkKanrenKWClear";
            this.chkKanrenKWClear.Size = new System.Drawing.Size(247, 23);
            this.chkKanrenKWClear.TabIndex = 20;
            this.chkKanrenKWClear.Text = "検索結果を消して検索する。";
            this.chkKanrenKWClear.UseVisualStyleBackColor = true;
            // 
            // btnBuy
            // 
            this.btnBuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuy.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBuy.Location = new System.Drawing.Point(845, 101);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(141, 29);
            this.btnBuy.TabIndex = 19;
            this.btnBuy.Text = "購入はコチラ";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // lblMsg
            // 
            this.lblMsg.Font = new System.Drawing.Font("MS UI Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(500, 76);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(479, 57);
            this.lblMsg.TabIndex = 18;
            this.lblMsg.Text = "トライアル版は、ソフトを起動後、検索回数は1回のみと制限しております。制限を解除する場合は、購入をご検討ください。";
            // 
            // btnGetPassword
            // 
            this.btnGetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGetPassword.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnGetPassword.Location = new System.Drawing.Point(633, 47);
            this.btnGetPassword.Name = "btnGetPassword";
            this.btnGetPassword.Size = new System.Drawing.Size(144, 35);
            this.btnGetPassword.TabIndex = 17;
            this.btnGetPassword.Text = "パスワード取得";
            this.btnGetPassword.UseVisualStyleBackColor = true;
            this.btnGetPassword.Visible = false;
            this.btnGetPassword.Click += new System.EventHandler(this.btnGetPassword_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnExit.Location = new System.Drawing.Point(911, 29);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "終了";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnStop.Location = new System.Drawing.Point(422, 70);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 35);
            this.btnStop.TabIndex = 14;
            this.btnStop.Text = "中止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnKW
            // 
            this.btnKW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKW.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKW.Location = new System.Drawing.Point(801, 28);
            this.btnKW.Name = "btnKW";
            this.btnKW.Size = new System.Drawing.Size(75, 35);
            this.btnKW.TabIndex = 13;
            this.btnKW.Text = "単語を抽出";
            this.btnKW.UseVisualStyleBackColor = true;
            this.btnKW.Visible = false;
            this.btnKW.Click += new System.EventHandler(this.btnKW_Click);
            // 
            // chkJufukuChk
            // 
            this.chkJufukuChk.AutoSize = true;
            this.chkJufukuChk.Checked = true;
            this.chkJufukuChk.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkJufukuChk.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.chkJufukuChk.Location = new System.Drawing.Point(614, 27);
            this.chkJufukuChk.Name = "chkJufukuChk";
            this.chkJufukuChk.Size = new System.Drawing.Size(314, 23);
            this.chkJufukuChk.TabIndex = 12;
            this.chkJufukuChk.Text = "重複しているキーワードは表示しない。";
            this.chkJufukuChk.UseVisualStyleBackColor = true;
            this.chkJufukuChk.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(18, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "階層";
            // 
            // cmdKaisou
            // 
            this.cmdKaisou.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmdKaisou.FormattingEnabled = true;
            this.cmdKaisou.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cmdKaisou.Location = new System.Drawing.Point(161, 71);
            this.cmdKaisou.Name = "cmdKaisou";
            this.cmdKaisou.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmdKaisou.Size = new System.Drawing.Size(50, 27);
            this.cmdKaisou.TabIndex = 11;
            this.cmdKaisou.Text = "3";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.操作マニュアルToolStripMenuItem,
            this.パスワードToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // 操作マニュアルToolStripMenuItem
            // 
            this.操作マニュアルToolStripMenuItem.Name = "操作マニュアルToolStripMenuItem";
            this.操作マニュアルToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.操作マニュアルToolStripMenuItem.Text = "操作マニュアル";
            this.操作マニュアルToolStripMenuItem.Click += new System.EventHandler(this.操作マニュアルToolStripMenuItem_Click);
            // 
            // パスワードToolStripMenuItem
            // 
            this.パスワードToolStripMenuItem.Name = "パスワードToolStripMenuItem";
            this.パスワードToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.パスワードToolStripMenuItem.Text = "パスワード";
            this.パスワードToolStripMenuItem.Click += new System.EventHandler(this.パスワードToolStripMenuItem_Click);
            // 
            // lblKensu
            // 
            this.lblKensu.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKensu.Location = new System.Drawing.Point(3, 11);
            this.lblKensu.Name = "lblKensu";
            this.lblKensu.Size = new System.Drawing.Size(644, 19);
            this.lblKensu.TabIndex = 10;
            this.lblKensu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(998, 471);
            this.panel2.TabIndex = 11;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(998, 471);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(990, 445);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "関連キーワード";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtList);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtKW);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(984, 439);
            this.splitContainer1.SplitterDistance = 679;
            this.splitContainer1.TabIndex = 9;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.lblKensu);
            this.panel3.Controls.Add(this.btnAscendingOrder);
            this.panel3.Controls.Add(this.btnDescendingOrder);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(679, 109);
            this.panel3.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(679, 28);
            this.panel5.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "関連キーワード";
            // 
            // txtKW
            // 
            this.txtKW.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKW.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtKW.Location = new System.Drawing.Point(0, 109);
            this.txtKW.Multiline = true;
            this.txtKW.Name = "txtKW";
            this.txtKW.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtKW.Size = new System.Drawing.Size(301, 330);
            this.txtKW.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.lblTime);
            this.panel4.Controls.Add(this.lblKWCount);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(301, 109);
            this.panel4.TabIndex = 9;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 81);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(301, 28);
            this.panel6.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "単体キーワード";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTime.Location = new System.Drawing.Point(3, 11);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 19);
            this.lblTime.TabIndex = 11;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblKWCount
            // 
            this.lblKWCount.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKWCount.Location = new System.Drawing.Point(3, 54);
            this.lblKWCount.Name = "lblKWCount";
            this.lblKWCount.Size = new System.Drawing.Size(262, 19);
            this.lblKWCount.TabIndex = 11;
            this.lblKWCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(25, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 11;
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(990, 445);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ブラウザ";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.webView2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(984, 439);
            this.panel7.TabIndex = 23;
            // 
            // webView2
            // 
            this.webView2.AllowExternalDrop = true;
            this.webView2.CreationProperties = null;
            this.webView2.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView2.Location = new System.Drawing.Point(0, 0);
            this.webView2.Name = "webView2";
            this.webView2.Size = new System.Drawing.Size(984, 439);
            this.webView2.TabIndex = 22;
            this.webView2.ZoomFactor = 1D;
            this.webView2.Click += new System.EventHandler(this.webView2_Click_1);
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 621);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GK-Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSerachKW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnAscendingOrder;
        private System.Windows.Forms.Button btnDescendingOrder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmdKaisou;
        private System.Windows.Forms.Label lblKensu;
        private System.Windows.Forms.CheckBox chkJufukuChk;
        private System.Windows.Forms.TextBox txtKW;
        private System.Windows.Forms.Button btnKW;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblKWCount;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem パスワードToolStripMenuItem;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ToolStripMenuItem 操作マニュアルToolStripMenuItem;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.CheckBox chkKanrenKWClear;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}