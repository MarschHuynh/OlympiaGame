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
            ((System.ComponentModel.ISupportInitialize)(this.group_Control)).BeginInit();
            this.group_Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab_Game)).BeginInit();
            this.tab_Game.SuspendLayout();
            this.tab_VeDich.SuspendLayout();
            this.tab_TangToc.SuspendLayout();
            this.tab_VuotChuongNgaiVat.SuspendLayout();
            this.tab_KhoiDong.SuspendLayout();
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
            this.group_Control.Size = new System.Drawing.Size(496, 364);
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
            this.tab_Game.RegularSize = new System.Drawing.Size(485, 335);
            this.tab_Game.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tab_Game.SelectedPage = this.tab_KhoiDong;
            this.tab_Game.Size = new System.Drawing.Size(485, 335);
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
            this.tab_VuotChuongNgaiVat.Size = new System.Drawing.Size(467, 290);
            // 
            // btn_BatDau_VCNV
            // 
            this.btn_BatDau_VCNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_VCNV.Location = new System.Drawing.Point(3, 264);
            this.btn_BatDau_VCNV.Name = "btn_BatDau_VCNV";
            this.btn_BatDau_VCNV.Size = new System.Drawing.Size(461, 23);
            this.btn_BatDau_VCNV.TabIndex = 1;
            this.btn_BatDau_VCNV.Text = "Bắt Đầu";
            // 
            // tab_KhoiDong
            // 
            this.tab_KhoiDong.Caption = "Khởi động";
            this.tab_KhoiDong.CausesValidation = false;
            this.tab_KhoiDong.Controls.Add(this.btn_BatDau_KD);
            this.tab_KhoiDong.Name = "tab_KhoiDong";
            this.tab_KhoiDong.Size = new System.Drawing.Size(467, 290);
            // 
            // btn_BatDau_KD
            // 
            this.btn_BatDau_KD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_KD.Location = new System.Drawing.Point(3, 264);
            this.btn_BatDau_KD.Name = "btn_BatDau_KD";
            this.btn_BatDau_KD.Size = new System.Drawing.Size(461, 23);
            this.btn_BatDau_KD.TabIndex = 0;
            this.btn_BatDau_KD.Text = "Bắt Đầu";
            // 
            // groupThongTin
            // 
            this.groupThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupThongTin.AutoSize = true;
            this.groupThongTin.Location = new System.Drawing.Point(514, 13);
            this.groupThongTin.Name = "groupThongTin";
            this.groupThongTin.Size = new System.Drawing.Size(248, 363);
            this.groupThongTin.TabIndex = 7;
            this.groupThongTin.Text = "Thông tin thí sinh";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 388);
            this.Controls.Add(this.groupThongTin);
            this.Controls.Add(this.group_Control);
            this.Name = "ServerForm";
            this.Text = "Form1";
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
    }
}

