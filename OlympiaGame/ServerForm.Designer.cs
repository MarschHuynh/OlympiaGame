namespace OlympiaGame
{
    partial class ServerForm
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
            this.group_Control = new DevExpress.XtraEditors.GroupControl();
            this.tab_Game = new DevExpress.XtraBars.Navigation.TabPane();
            this.tab_VeDich = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_BatDau_VeDich = new DevExpress.XtraEditors.SimpleButton();
            this.tab_TangToc = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_BatDau_TangToc = new DevExpress.XtraEditors.SimpleButton();
            this.tab_VuotChuongNgaiVat = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_BatDau_VCNV = new DevExpress.XtraEditors.SimpleButton();
            this.tab_KhoiDong = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView_GoiCauHoi = new System.Windows.Forms.DataGridView();
            this.btn_addCauHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_deleteCauHoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_deleteNhom = new DevExpress.XtraEditors.SimpleButton();
            this.btn_addNhom = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView_CauHoi = new System.Windows.Forms.DataGridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox_GoiCauHoi = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BatDau_KD = new DevExpress.XtraEditors.SimpleButton();
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.group_Control)).BeginInit();
            this.group_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Game)).BeginInit();
            this.tab_Game.SuspendLayout();
            this.tab_VeDich.SuspendLayout();
            this.tab_TangToc.SuspendLayout();
            this.tab_VuotChuongNgaiVat.SuspendLayout();
            this.tab_KhoiDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GoiCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            this.SuspendLayout();
            // 
            // group_Control
            // 
            this.group_Control.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_Control.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.group_Control.Controls.Add(this.tab_Game);
            this.group_Control.Location = new System.Drawing.Point(12, 12);
            this.group_Control.Name = "group_Control";
            this.group_Control.Size = new System.Drawing.Size(637, 610);
            this.group_Control.TabIndex = 6;
            this.group_Control.Text = "Control Client";
            // 
            // tab_Game
            // 
            this.tab_Game.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_Game.Controls.Add(this.tab_VeDich);
            this.tab_Game.Controls.Add(this.tab_TangToc);
            this.tab_Game.Controls.Add(this.tab_VuotChuongNgaiVat);
            this.tab_Game.Controls.Add(this.tab_KhoiDong);
            this.tab_Game.Location = new System.Drawing.Point(6, 24);
            this.tab_Game.Name = "tab_Game";
            this.tab_Game.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tab_VeDich,
            this.tab_TangToc,
            this.tab_VuotChuongNgaiVat,
            this.tab_KhoiDong});
            this.tab_Game.RegularSize = new System.Drawing.Size(626, 581);
            this.tab_Game.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_Game.SelectedPage = this.tab_KhoiDong;
            this.tab_Game.Size = new System.Drawing.Size(626, 581);
            this.tab_Game.TabIndex = 0;
            this.tab_Game.Text = "Khởi Động";
            this.tab_Game.TransitionType = DevExpress.Utils.Animation.Transitions.Fade;
            // 
            // tab_VeDich
            // 
            this.tab_VeDich.Caption = "Về đích";
            this.tab_VeDich.Controls.Add(this.btn_BatDau_VeDich);
            this.tab_VeDich.Name = "tab_VeDich";
            this.tab_VeDich.Size = new System.Drawing.Size(467, 290);
            // 
            // btn_BatDau_VeDich
            // 
            this.btn_BatDau_VeDich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_VeDich.Location = new System.Drawing.Point(3, 264);
            this.btn_BatDau_VeDich.Name = "btn_BatDau_VeDich";
            this.btn_BatDau_VeDich.Size = new System.Drawing.Size(461, 23);
            this.btn_BatDau_VeDich.TabIndex = 2;
            this.btn_BatDau_VeDich.Text = "Bắt Đầu";
            // 
            // tab_TangToc
            // 
            this.tab_TangToc.Caption = "Tăng tốc";
            this.tab_TangToc.Controls.Add(this.btn_BatDau_TangToc);
            this.tab_TangToc.Name = "tab_TangToc";
            this.tab_TangToc.Size = new System.Drawing.Size(467, 290);
            // 
            // btn_BatDau_TangToc
            // 
            this.btn_BatDau_TangToc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_TangToc.Location = new System.Drawing.Point(3, 264);
            this.btn_BatDau_TangToc.Name = "btn_BatDau_TangToc";
            this.btn_BatDau_TangToc.Size = new System.Drawing.Size(461, 23);
            this.btn_BatDau_TangToc.TabIndex = 2;
            this.btn_BatDau_TangToc.Text = "Bắt Đầu";
            // 
            // tab_VuotChuongNgaiVat
            // 
            this.tab_VuotChuongNgaiVat.Caption = "Vượt chướng ngại vật";
            this.tab_VuotChuongNgaiVat.Controls.Add(this.btn_BatDau_VCNV);
            this.tab_VuotChuongNgaiVat.Name = "tab_VuotChuongNgaiVat";
            this.tab_VuotChuongNgaiVat.Size = new System.Drawing.Size(608, 390);
            // 
            // btn_BatDau_VCNV
            // 
            this.btn_BatDau_VCNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_VCNV.Location = new System.Drawing.Point(3, 364);
            this.btn_BatDau_VCNV.Name = "btn_BatDau_VCNV";
            this.btn_BatDau_VCNV.Size = new System.Drawing.Size(602, 23);
            this.btn_BatDau_VCNV.TabIndex = 1;
            this.btn_BatDau_VCNV.Text = "Bắt Đầu";
            // 
            // tab_KhoiDong
            // 
            this.tab_KhoiDong.Caption = "Khởi động";
            this.tab_KhoiDong.CausesValidation = false;
            this.tab_KhoiDong.Controls.Add(this.groupControl2);
            this.tab_KhoiDong.Controls.Add(this.groupControl1);
            this.tab_KhoiDong.Controls.Add(this.btn_BatDau_KD);
            this.tab_KhoiDong.Name = "tab_KhoiDong";
            this.tab_KhoiDong.Size = new System.Drawing.Size(608, 536);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.dataGridView_GoiCauHoi);
            this.groupControl2.Controls.Add(this.btn_addCauHoi);
            this.groupControl2.Controls.Add(this.btn_deleteCauHoi);
            this.groupControl2.Controls.Add(this.btn_deleteNhom);
            this.groupControl2.Controls.Add(this.btn_addNhom);
            this.groupControl2.Controls.Add(this.dataGridView_CauHoi);
            this.groupControl2.Location = new System.Drawing.Point(4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(601, 340);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Câu hỏi";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(369, 311);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(70, 23);
            this.simpleButton1.TabIndex = 7;
            this.simpleButton1.Text = "Sửa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dataGridView_GoiCauHoi
            // 
            this.dataGridView_GoiCauHoi.AllowUserToAddRows = false;
            this.dataGridView_GoiCauHoi.AllowUserToDeleteRows = false;
            this.dataGridView_GoiCauHoi.AllowUserToResizeColumns = false;
            this.dataGridView_GoiCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView_GoiCauHoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_GoiCauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GoiCauHoi.Location = new System.Drawing.Point(6, 24);
            this.dataGridView_GoiCauHoi.Name = "dataGridView_GoiCauHoi";
            this.dataGridView_GoiCauHoi.RowHeadersVisible = false;
            this.dataGridView_GoiCauHoi.RowTemplate.ReadOnly = true;
            this.dataGridView_GoiCauHoi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_GoiCauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_GoiCauHoi.Size = new System.Drawing.Size(171, 281);
            this.dataGridView_GoiCauHoi.TabIndex = 6;
            this.dataGridView_GoiCauHoi.SelectionChanged += new System.EventHandler(this.dataGridView_GoiCauHoi_SelectionChanged);
            // 
            // btn_addCauHoi
            // 
            this.btn_addCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addCauHoi.Location = new System.Drawing.Point(445, 311);
            this.btn_addCauHoi.Name = "btn_addCauHoi";
            this.btn_addCauHoi.Size = new System.Drawing.Size(70, 23);
            this.btn_addCauHoi.TabIndex = 5;
            this.btn_addCauHoi.Text = "Thêm";
            this.btn_addCauHoi.Click += new System.EventHandler(this.btn_addCauHoi_Click);
            // 
            // btn_deleteCauHoi
            // 
            this.btn_deleteCauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deleteCauHoi.Location = new System.Drawing.Point(521, 311);
            this.btn_deleteCauHoi.Name = "btn_deleteCauHoi";
            this.btn_deleteCauHoi.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteCauHoi.TabIndex = 4;
            this.btn_deleteCauHoi.Text = "Xóa";
            this.btn_deleteCauHoi.Click += new System.EventHandler(this.btn_deleteCauHoi_Click);
            // 
            // btn_deleteNhom
            // 
            this.btn_deleteNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_deleteNhom.Location = new System.Drawing.Point(102, 311);
            this.btn_deleteNhom.Name = "btn_deleteNhom";
            this.btn_deleteNhom.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteNhom.TabIndex = 3;
            this.btn_deleteNhom.Text = "Xóa";
            this.btn_deleteNhom.Click += new System.EventHandler(this.btn_deleteNhom_Click);
            // 
            // btn_addNhom
            // 
            this.btn_addNhom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_addNhom.Location = new System.Drawing.Point(6, 311);
            this.btn_addNhom.Name = "btn_addNhom";
            this.btn_addNhom.Size = new System.Drawing.Size(70, 23);
            this.btn_addNhom.TabIndex = 2;
            this.btn_addNhom.Text = "Thêm";
            this.btn_addNhom.Click += new System.EventHandler(this.btn_addNhom_Click);
            // 
            // dataGridView_CauHoi
            // 
            this.dataGridView_CauHoi.AllowUserToAddRows = false;
            this.dataGridView_CauHoi.AllowUserToResizeRows = false;
            this.dataGridView_CauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_CauHoi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_CauHoi.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView_CauHoi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_CauHoi.Location = new System.Drawing.Point(183, 23);
            this.dataGridView_CauHoi.Name = "dataGridView_CauHoi";
            this.dataGridView_CauHoi.RowHeadersVisible = false;
            this.dataGridView_CauHoi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView_CauHoi.RowTemplate.ReadOnly = true;
            this.dataGridView_CauHoi.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_CauHoi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_CauHoi.Size = new System.Drawing.Size(412, 281);
            this.dataGridView_CauHoi.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.comboBox1);
            this.groupControl1.Controls.Add(this.comboBox_GoiCauHoi);
            this.groupControl1.Controls.Add(this.button3);
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(4, 350);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 154);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(246, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox_GoiCauHoi
            // 
            this.comboBox_GoiCauHoi.FormattingEnabled = true;
            this.comboBox_GoiCauHoi.Location = new System.Drawing.Point(379, 24);
            this.comboBox_GoiCauHoi.Name = "comboBox_GoiCauHoi";
            this.comboBox_GoiCauHoi.Size = new System.Drawing.Size(216, 21);
            this.comboBox_GoiCauHoi.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(488, 117);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Bỏ qua";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(488, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sai";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(488, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đúng";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(6, 50);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(475, 99);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gói câu hỏi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thí sinh:";
            // 
            // btn_BatDau_KD
            // 
            this.btn_BatDau_KD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_KD.Location = new System.Drawing.Point(3, 510);
            this.btn_BatDau_KD.Name = "btn_BatDau_KD";
            this.btn_BatDau_KD.Size = new System.Drawing.Size(602, 23);
            this.btn_BatDau_KD.TabIndex = 0;
            this.btn_BatDau_KD.Text = "Bắt Đầu";
            // 
            // groupThongTin
            // 
            this.groupThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupThongTin.AutoSize = true;
            this.groupThongTin.Location = new System.Drawing.Point(655, 13);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(248, 609);
            this.groupThongTin.TabIndex = 7;
            this.groupThongTin.Text = "Thông tin thí sinh";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 634);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.group_Control);
            this.Name = "ServerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Olympia";
            this.Load += new System.EventHandler(this.ServerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.group_Control)).EndInit();
            this.group_Control.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab_Game)).EndInit();
            this.tab_Game.ResumeLayout(false);
            this.tab_VeDich.ResumeLayout(false);
            this.tab_TangToc.ResumeLayout(false);
            this.tab_VuotChuongNgaiVat.ResumeLayout(false);
            this.tab_KhoiDong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GoiCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_CauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl group_Control;
        private DevExpress.XtraBars.Navigation.TabPane tab_Game;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab_VeDich;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab_TangToc;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab_VuotChuongNgaiVat;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab_KhoiDong;
        private DevExpress.XtraEditors.SimpleButton btn_BatDau_KD;
        private DevExpress.XtraEditors.SimpleButton btn_BatDau_VCNV;
        private DevExpress.XtraEditors.SimpleButton btn_BatDau_TangToc;
        private DevExpress.XtraEditors.SimpleButton btn_BatDau_VeDich;
        private DevExpress.XtraEditors.GroupControl groupThongTin;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataGridView_CauHoi;
        private DevExpress.XtraEditors.SimpleButton btn_deleteNhom;
        private DevExpress.XtraEditors.SimpleButton btn_addNhom;
        private DevExpress.XtraEditors.SimpleButton btn_addCauHoi;
        private DevExpress.XtraEditors.SimpleButton btn_deleteCauHoi;
        private System.Windows.Forms.DataGridView dataGridView_GoiCauHoi;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox comboBox_GoiCauHoi;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

