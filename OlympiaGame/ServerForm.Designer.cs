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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tab_KhoiDong = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.btn_BatDau_KD = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BatDau_VCNV = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BatDau_TangToc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_BatDau_VeDich = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.tabNavigationPage2.SuspendLayout();
            this.tabNavigationPage3.SuspendLayout();
            this.tabNavigationPage4.SuspendLayout();
            this.tabNavigationPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.AutoSize = true;
            this.groupControl1.Location = new System.Drawing.Point(510, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(252, 364);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "Chat Box";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupControl2.Controls.Add(this.tabPane1);
            this.groupControl2.Location = new System.Drawing.Point(12, 12);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(492, 364);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "Control Client";
            // 
            // tabPane1
            // 
            this.tabPane1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPane1.Controls.Add(this.tab_KhoiDong);
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Location = new System.Drawing.Point(6, 24);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tab_KhoiDong,
            this.tabNavigationPage2,
            this.tabNavigationPage3,
            this.tabNavigationPage4,
            this.tabNavigationPage5});
            this.tabPane1.RegularSize = new System.Drawing.Size(481, 335);
            this.tabPane1.SelectedPage = this.tab_KhoiDong;
            this.tabPane1.Size = new System.Drawing.Size(481, 335);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "Khởi Động";
            this.tabPane1.TransitionType = DevExpress.Utils.Animation.Transitions.Clock;
            // 
            // tab_KhoiDong
            // 
            this.tab_KhoiDong.Caption = "tabNavigationPage1";
            this.tab_KhoiDong.Name = "tab_KhoiDong";
            this.tab_KhoiDong.Size = new System.Drawing.Size(463, 290);
            this.tab_KhoiDong.Paint += new System.Windows.Forms.PaintEventHandler(this.tabNavigationPage1_Paint);
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "tabNavigationPage2";
            this.tabNavigationPage2.Controls.Add(this.btn_BatDau_VeDich);
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(463, 290);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "tabNavigationPage3";
            this.tabNavigationPage3.Controls.Add(this.btn_BatDau_TangToc);
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(463, 290);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "tabNavigationPage4";
            this.tabNavigationPage4.Controls.Add(this.btn_BatDau_VCNV);
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(463, 290);
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.Caption = "tabNavigationPage5";
            this.tabNavigationPage5.Controls.Add(this.btn_BatDau_KD);
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.Size = new System.Drawing.Size(463, 290);
            // 
            // btn_BatDau_KD
            // 
            this.btn_BatDau_KD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_KD.Location = new System.Drawing.Point(3, 264);
            this.btn_BatDau_KD.Name = "btn_BatDau_KD";
            this.btn_BatDau_KD.Size = new System.Drawing.Size(457, 23);
            this.btn_BatDau_KD.TabIndex = 0;
            this.btn_BatDau_KD.Text = "Bắt Đầu";
            // 
            // btn_BatDau_VCNV
            // 
            this.btn_BatDau_VCNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_VCNV.Location = new System.Drawing.Point(3, 264);
            this.btn_BatDau_VCNV.Name = "btn_BatDau_VCNV";
            this.btn_BatDau_VCNV.Size = new System.Drawing.Size(457, 23);
            this.btn_BatDau_VCNV.TabIndex = 1;
            this.btn_BatDau_VCNV.Text = "Bắt Đầu";
            // 
            // btn_BatDau_TangToc
            // 
            this.btn_BatDau_TangToc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_TangToc.Location = new System.Drawing.Point(3, 264);
            this.btn_BatDau_TangToc.Name = "btn_BatDau_TangToc";
            this.btn_BatDau_TangToc.Size = new System.Drawing.Size(457, 23);
            this.btn_BatDau_TangToc.TabIndex = 2;
            this.btn_BatDau_TangToc.Text = "Bắt Đầu";
            // 
            // btn_BatDau_VeDich
            // 
            this.btn_BatDau_VeDich.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_BatDau_VeDich.Location = new System.Drawing.Point(3, 264);
            this.btn_BatDau_VeDich.Name = "btn_BatDau_VeDich";
            this.btn_BatDau_VeDich.Size = new System.Drawing.Size(457, 23);
            this.btn_BatDau_VeDich.TabIndex = 2;
            this.btn_BatDau_VeDich.Text = "Bắt Đầu";
            // 
            // OlympiaGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 388);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "OlympiaGame";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.tabNavigationPage2.ResumeLayout(false);
            this.tabNavigationPage3.ResumeLayout(false);
            this.tabNavigationPage4.ResumeLayout(false);
            this.tabNavigationPage5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tab_KhoiDong;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
        private DevExpress.XtraEditors.SimpleButton btn_BatDau_KD;
        private DevExpress.XtraEditors.SimpleButton btn_BatDau_VCNV;
        private DevExpress.XtraEditors.SimpleButton btn_BatDau_TangToc;
        private DevExpress.XtraEditors.SimpleButton btn_BatDau_VeDich;
    }
}

