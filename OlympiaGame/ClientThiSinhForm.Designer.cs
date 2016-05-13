namespace OlympiaGame
{
    partial class ClientThiSinhForm
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
            this.rtb_CauHoi = new System.Windows.Forms.RichTextBox();
            this.lb_soCauDung = new System.Windows.Forms.Label();
            this.lb_Diem = new System.Windows.Forms.Label();
            this.lb_tenGame = new System.Windows.Forms.Label();
            this.lb_ten = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_CauHoi
            // 
            this.rtb_CauHoi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtb_CauHoi.BackColor = System.Drawing.Color.DodgerBlue;
            this.rtb_CauHoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_CauHoi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_CauHoi.Location = new System.Drawing.Point(13, 340);
            this.rtb_CauHoi.Name = "rtb_CauHoi";
            this.rtb_CauHoi.ReadOnly = true;
            this.rtb_CauHoi.Size = new System.Drawing.Size(605, 127);
            this.rtb_CauHoi.TabIndex = 0;
            this.rtb_CauHoi.Text = "Đỉnh núi cao nhất Đông Nam Á là đỉnh núi nào ?";
            // 
            // lb_soCauDung
            // 
            this.lb_soCauDung.AutoSize = true;
            this.lb_soCauDung.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_soCauDung.ForeColor = System.Drawing.Color.Crimson;
            this.lb_soCauDung.Location = new System.Drawing.Point(618, 364);
            this.lb_soCauDung.Name = "lb_soCauDung";
            this.lb_soCauDung.Size = new System.Drawing.Size(197, 77);
            this.lb_soCauDung.TabIndex = 1;
            this.lb_soCauDung.Text = "12/12";
            // 
            // lb_Diem
            // 
            this.lb_Diem.AutoSize = true;
            this.lb_Diem.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Diem.ForeColor = System.Drawing.Color.Lime;
            this.lb_Diem.Location = new System.Drawing.Point(296, 149);
            this.lb_Diem.Name = "lb_Diem";
            this.lb_Diem.Size = new System.Drawing.Size(206, 116);
            this.lb_Diem.TabIndex = 2;
            this.lb_Diem.Text = "120";
            // 
            // lb_tenGame
            // 
            this.lb_tenGame.AutoSize = true;
            this.lb_tenGame.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tenGame.ForeColor = System.Drawing.Color.Salmon;
            this.lb_tenGame.Location = new System.Drawing.Point(12, 9);
            this.lb_tenGame.Name = "lb_tenGame";
            this.lb_tenGame.Size = new System.Drawing.Size(247, 58);
            this.lb_tenGame.TabIndex = 3;
            this.lb_tenGame.Text = "Khởi Động";
            // 
            // lb_ten
            // 
            this.lb_ten.AutoSize = true;
            this.lb_ten.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ten.ForeColor = System.Drawing.Color.White;
            this.lb_ten.Location = new System.Drawing.Point(502, 20);
            this.lb_ten.Name = "lb_ten";
            this.lb_ten.Size = new System.Drawing.Size(284, 45);
            this.lb_ten.TabIndex = 4;
            this.lb_ten.Text = "Huỳnh Tú Thiên";
            // 
            // ClientThiSinhForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 479);
            this.Controls.Add(this.lb_ten);
            this.Controls.Add(this.lb_tenGame);
            this.Controls.Add(this.lb_Diem);
            this.Controls.Add(this.lb_soCauDung);
            this.Controls.Add(this.rtb_CauHoi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientThiSinhForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thí Sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientThiSinhForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_CauHoi;
        private System.Windows.Forms.Label lb_soCauDung;
        private System.Windows.Forms.Label lb_Diem;
        private System.Windows.Forms.Label lb_tenGame;
        private System.Windows.Forms.Label lb_ten;
    }
}