namespace OlympiaGame
{
    partial class ThemGoiCauHoiForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_TenGoiCauHoi = new System.Windows.Forms.TextBox();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // tb_TenGoiCauHoi
            // 
            this.tb_TenGoiCauHoi.Location = new System.Drawing.Point(49, 13);
            this.tb_TenGoiCauHoi.Name = "tb_TenGoiCauHoi";
            this.tb_TenGoiCauHoi.Size = new System.Drawing.Size(223, 20);
            this.tb_TenGoiCauHoi.TabIndex = 1;
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(197, 40);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 2;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(116, 40);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 3;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // ThemGoiCauHoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.tb_TenGoiCauHoi);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemGoiCauHoiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm gói câu hỏi";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TenGoiCauHoi;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_OK;
    }
}