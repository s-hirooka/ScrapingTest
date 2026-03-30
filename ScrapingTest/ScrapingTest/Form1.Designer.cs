namespace GKSearch
{
    partial class frmQASerach
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
            this.chkYahoo = new System.Windows.Forms.CheckBox();
            this.chkGoo = new System.Windows.Forms.CheckBox();
            this.chkOKWAVE = new System.Windows.Forms.CheckBox();
            this.chkHatugenkomati = new System.Windows.Forms.CheckBox();
            this.chkGirlsChannel = new System.Windows.Forms.CheckBox();
            this.cboGCSort = new System.Windows.Forms.ComboBox();
            this.cboYahooHyouji = new System.Windows.Forms.ComboBox();
            this.cboOshieteGooSort = new System.Windows.Forms.ComboBox();
            this.cboOKWave = new System.Windows.Forms.ComboBox();
            this.cboHatugenKomatiSort = new System.Windows.Forms.ComboBox();
            this.txtSerachKW = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblKensu = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.grdList = new System.Windows.Forms.DataGridView();
            this.タイトル = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QAサイト = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.質問 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.URL = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnKeyWordGet = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkYahoo
            // 
            this.chkYahoo.AutoSize = true;
            this.chkYahoo.Checked = true;
            this.chkYahoo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkYahoo.Location = new System.Drawing.Point(56, 69);
            this.chkYahoo.Name = "chkYahoo";
            this.chkYahoo.Size = new System.Drawing.Size(91, 16);
            this.chkYahoo.TabIndex = 0;
            this.chkYahoo.Text = "Yahoo知恵袋";
            this.chkYahoo.UseVisualStyleBackColor = true;
            this.chkYahoo.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // chkGoo
            // 
            this.chkGoo.AutoSize = true;
            this.chkGoo.Checked = true;
            this.chkGoo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGoo.Location = new System.Drawing.Point(56, 108);
            this.chkGoo.Name = "chkGoo";
            this.chkGoo.Size = new System.Drawing.Size(84, 16);
            this.chkGoo.TabIndex = 1;
            this.chkGoo.Text = "教えて！goo";
            this.chkGoo.UseVisualStyleBackColor = true;
            // 
            // chkOKWAVE
            // 
            this.chkOKWAVE.AutoSize = true;
            this.chkOKWAVE.Checked = true;
            this.chkOKWAVE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOKWAVE.Location = new System.Drawing.Point(56, 148);
            this.chkOKWAVE.Name = "chkOKWAVE";
            this.chkOKWAVE.Size = new System.Drawing.Size(71, 16);
            this.chkOKWAVE.TabIndex = 2;
            this.chkOKWAVE.Text = "OKWAVE";
            this.chkOKWAVE.UseVisualStyleBackColor = true;
            // 
            // chkHatugenkomati
            // 
            this.chkHatugenkomati.AutoSize = true;
            this.chkHatugenkomati.Checked = true;
            this.chkHatugenkomati.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHatugenkomati.Location = new System.Drawing.Point(55, 187);
            this.chkHatugenkomati.Name = "chkHatugenkomati";
            this.chkHatugenkomati.Size = new System.Drawing.Size(72, 16);
            this.chkHatugenkomati.TabIndex = 3;
            this.chkHatugenkomati.Text = "発言小町";
            this.chkHatugenkomati.UseVisualStyleBackColor = true;
            // 
            // chkGirlsChannel
            // 
            this.chkGirlsChannel.AutoSize = true;
            this.chkGirlsChannel.Checked = true;
            this.chkGirlsChannel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGirlsChannel.Location = new System.Drawing.Point(55, 222);
            this.chkGirlsChannel.Name = "chkGirlsChannel";
            this.chkGirlsChannel.Size = new System.Drawing.Size(111, 16);
            this.chkGirlsChannel.TabIndex = 4;
            this.chkGirlsChannel.Text = "ガールズちゃんねる";
            this.chkGirlsChannel.UseVisualStyleBackColor = true;
            // 
            // cboGCSort
            // 
            this.cboGCSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGCSort.FormattingEnabled = true;
            this.cboGCSort.Items.AddRange(new object[] {
            "新着順",
            "コメント数順"});
            this.cboGCSort.Location = new System.Drawing.Point(191, 222);
            this.cboGCSort.Name = "cboGCSort";
            this.cboGCSort.Size = new System.Drawing.Size(138, 20);
            this.cboGCSort.TabIndex = 5;
            // 
            // cboYahooHyouji
            // 
            this.cboYahooHyouji.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYahooHyouji.FormattingEnabled = true;
            this.cboYahooHyouji.Items.AddRange(new object[] {
            "関連度順",
            "質問日時の新しい順",
            "質問日時の古い順",
            "更新日時の新しい順",
            "更新日時の古い順",
            "回答数の多い順",
            "回答数の少ない順",
            "閲覧数の多い順",
            "閲覧数の少ない順",
            "お礼の多い順",
            "お礼の少ない順",
            "",
            "",
            ""});
            this.cboYahooHyouji.Location = new System.Drawing.Point(191, 65);
            this.cboYahooHyouji.Name = "cboYahooHyouji";
            this.cboYahooHyouji.Size = new System.Drawing.Size(138, 20);
            this.cboYahooHyouji.TabIndex = 7;
            // 
            // cboOshieteGooSort
            // 
            this.cboOshieteGooSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOshieteGooSort.FormattingEnabled = true;
            this.cboOshieteGooSort.Items.AddRange(new object[] {
            "適合度順",
            "質問日時順",
            "回答数順",
            "気になる順",
            "",
            ""});
            this.cboOshieteGooSort.Location = new System.Drawing.Point(191, 104);
            this.cboOshieteGooSort.Name = "cboOshieteGooSort";
            this.cboOshieteGooSort.Size = new System.Drawing.Size(138, 20);
            this.cboOshieteGooSort.TabIndex = 8;
            // 
            // cboOKWave
            // 
            this.cboOKWave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOKWave.FormattingEnabled = true;
            this.cboOKWave.Items.AddRange(new object[] {
            "おすすめ",
            "新着"});
            this.cboOKWave.Location = new System.Drawing.Point(191, 148);
            this.cboOKWave.Name = "cboOKWave";
            this.cboOKWave.Size = new System.Drawing.Size(138, 20);
            this.cboOKWave.TabIndex = 9;
            // 
            // cboHatugenKomatiSort
            // 
            this.cboHatugenKomatiSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHatugenKomatiSort.FormattingEnabled = true;
            this.cboHatugenKomatiSort.Items.AddRange(new object[] {
            "新着順",
            "関連順"});
            this.cboHatugenKomatiSort.Location = new System.Drawing.Point(191, 187);
            this.cboHatugenKomatiSort.Name = "cboHatugenKomatiSort";
            this.cboHatugenKomatiSort.Size = new System.Drawing.Size(138, 20);
            this.cboHatugenKomatiSort.TabIndex = 10;
            // 
            // txtSerachKW
            // 
            this.txtSerachKW.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtSerachKW.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.txtSerachKW.ImeMode = System.Windows.Forms.ImeMode.Hiragana;
            this.txtSerachKW.Location = new System.Drawing.Point(191, 21);
            this.txtSerachKW.Name = "txtSerachKW";
            this.txtSerachKW.Size = new System.Drawing.Size(240, 26);
            this.txtSerachKW.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnSearch.Location = new System.Drawing.Point(452, 17);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 35);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "キーワードを入力";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(43, 258);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(577, 143);
            this.listView1.TabIndex = 14;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblKensu
            // 
            this.lblKensu.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblKensu.Location = new System.Drawing.Point(575, 21);
            this.lblKensu.Name = "lblKensu";
            this.lblKensu.Size = new System.Drawing.Size(383, 19);
            this.lblKensu.TabIndex = 15;
            this.lblKensu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTime.Location = new System.Drawing.Point(602, 62);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 19);
            this.lblTime.TabIndex = 16;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grdList
            // 
            this.grdList.AllowUserToAddRows = false;
            this.grdList.AllowUserToDeleteRows = false;
            this.grdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.タイトル,
            this.QAサイト,
            this.質問,
            this.URL});
            this.grdList.Location = new System.Drawing.Point(46, 407);
            this.grdList.Name = "grdList";
            this.grdList.RowTemplate.Height = 21;
            this.grdList.Size = new System.Drawing.Size(574, 391);
            this.grdList.TabIndex = 17;
            this.grdList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdList_CellContentClick);
            // 
            // タイトル
            // 
            this.タイトル.HeaderText = "タイトル";
            this.タイトル.Name = "タイトル";
            // 
            // QAサイト
            // 
            this.QAサイト.HeaderText = "Q＆Aサイト";
            this.QAサイト.Name = "QAサイト";
            // 
            // 質問
            // 
            this.質問.HeaderText = "質問";
            this.質問.Name = "質問";
            // 
            // URL
            // 
            this.URL.HeaderText = "開く";
            this.URL.Name = "URL";
            this.URL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.URL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnKeyWordGet
            // 
            this.btnKeyWordGet.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btnKeyWordGet.Location = new System.Drawing.Point(565, 187);
            this.btnKeyWordGet.Name = "btnKeyWordGet";
            this.btnKeyWordGet.Size = new System.Drawing.Size(226, 35);
            this.btnKeyWordGet.TabIndex = 18;
            this.btnKeyWordGet.Text = "すべての単語を取得する";
            this.btnKeyWordGet.UseVisualStyleBackColor = true;
            this.btnKeyWordGet.Click += new System.EventHandler(this.btnKeyWordGet_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.dataGridView1.Location = new System.Drawing.Point(669, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(219, 540);
            this.dataGridView1.TabIndex = 19;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "単語";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(833, 46);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(20, 20);
            this.webBrowser2.TabIndex = 21;
            // 
            // frmQASerach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 810);
            this.Controls.Add(this.webBrowser2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnKeyWordGet);
            this.Controls.Add(this.grdList);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblKensu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txtSerachKW);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboHatugenKomatiSort);
            this.Controls.Add(this.cboOKWave);
            this.Controls.Add(this.cboOshieteGooSort);
            this.Controls.Add(this.cboYahooHyouji);
            this.Controls.Add(this.cboGCSort);
            this.Controls.Add(this.chkGirlsChannel);
            this.Controls.Add(this.chkHatugenkomati);
            this.Controls.Add(this.chkOKWAVE);
            this.Controls.Add(this.chkGoo);
            this.Controls.Add(this.chkYahoo);
            this.Name = "frmQASerach";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkYahoo;
        private System.Windows.Forms.CheckBox chkGoo;
        private System.Windows.Forms.CheckBox chkOKWAVE;
        private System.Windows.Forms.CheckBox chkHatugenkomati;
        private System.Windows.Forms.CheckBox chkGirlsChannel;
        private System.Windows.Forms.ComboBox cboGCSort;
        private System.Windows.Forms.ComboBox cboYahooHyouji;
        private System.Windows.Forms.ComboBox cboOshieteGooSort;
        private System.Windows.Forms.ComboBox cboOKWave;
        private System.Windows.Forms.ComboBox cboHatugenKomatiSort;
        private System.Windows.Forms.TextBox txtSerachKW;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblKensu;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DataGridView grdList;
        private System.Windows.Forms.DataGridViewTextBoxColumn タイトル;
        private System.Windows.Forms.DataGridViewTextBoxColumn QAサイト;
        private System.Windows.Forms.DataGridViewTextBoxColumn 質問;
        private System.Windows.Forms.DataGridViewButtonColumn URL;
        private System.Windows.Forms.Button btnKeyWordGet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.WebBrowser webBrowser2;
    }
}