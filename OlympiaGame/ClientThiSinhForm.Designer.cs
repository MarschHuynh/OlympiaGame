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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(624, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "6/12";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(296, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 116);
            this.label2.TabIndex = 2;
            this.label2.Text = "120";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Salmon;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 58);
            this.label3.TabIndex = 3;
            this.label3.Text = "Khởi Động";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(502, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 45);
            this.label4.TabIndex = 4;
            this.label4.Text = "Huỳnh Tú Thiên";
            // 
            // ClientThiSinhForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.Turquoise;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 479);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_CauHoi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientThiSinhForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thí Sinh";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientThiSinhForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_CauHoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}