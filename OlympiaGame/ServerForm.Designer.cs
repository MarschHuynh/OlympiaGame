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
            this.btn_BatDau_KD = new DevExpress.XtraEditors.SimpleButton();
            this.groupThongTin = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxEdit2 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.group_Control)).BeginInit();
            this.group_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Game)).BeginInit();
            this.tab_Game.SuspendLayout();
            this.tab_VeDich.SuspendLayout();
            this.tab_TangToc.SuspendLayout();
            this.tab_VuotChuongNgaiVat.SuspendLayout();
            this.tab_KhoiDong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
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
            this.group_Control.Size = new System.Drawing.Size(637, 464);
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
            this.tab_Game.RegularSize = new System.Drawing.Size(626, 435);
            this.tab_Game.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_Game.SelectedPage = this.tab_KhoiDong;
            this.tab_Game.Size = new System.Drawing.Size(626, 435);
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
            this.tab_KhoiDong.Size = new System.Drawing.Size(608, 390);
            // 
            // btn_BatDau_KD
            // 
            this.btn_BatDau_KD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_KD.Location = new System.Drawing.Point(3, 364);
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
            this.groupThongTin.Size = new System.Drawing.Size(248, 463);
            this.groupThongTin.TabIndex = 7;
            this.groupThongTin.Text = "Thông tin thí sinh";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.button3);
            this.groupControl1.Controls.Add(this.button2);
            this.groupControl1.Controls.Add(this.button1);
            this.groupControl1.Controls.Add(this.richTextBox1);
            this.groupControl1.Controls.Add(this.comboBoxEdit2);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.comboBoxEdit1);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(4, 204);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(601, 154);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "groupControl1";
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
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(60, 24);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(244, 20);
            this.comboBoxEdit1.TabIndex = 1;
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
            // comboBoxEdit2
            // 
            this.comboBoxEdit2.Location = new System.Drawing.Point(379, 24);
            this.comboBoxEdit2.Name = "comboBoxEdit2";
            this.comboBoxEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit2.Size = new System.Drawing.Size(217, 20);
            this.comboBoxEdit2.TabIndex = 3;
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
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(488, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đúng";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(488, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sai";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(488, 110);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Bỏ qua";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.listView2);
            this.groupControl2.Controls.Add(this.listView1);
            this.groupControl2.Location = new System.Drawing.Point(4, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(601, 194);
            this.groupControl2.TabIndex = 4;
            this.groupControl2.Text = "Câu hỏi";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.Location = new System.Drawing.Point(6, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(171, 165);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView2.Location = new System.Drawing.Point(184, 24);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(412, 165);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 488);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.group_Control);
            this.Name = "ServerForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.groupThongTin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
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
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
    }
}

