﻿namespace OlympiaGame
{
    partial class SuaCauHoiForm
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
            this.rtb_CauHoi = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_DapAn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_linhVuc = new System.Windows.Forms.ComboBox();
            this.comboBox_GoiCauHoi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_OK = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Câu hỏi: ";
            // 
            // rtb_CauHoi
            // 
            this.rtb_CauHoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_CauHoi.Location = new System.Drawing.Point(75, 13);
            this.rtb_CauHoi.Name = "rtb_CauHoi";
            this.rtb_CauHoi.Size = new System.Drawing.Size(514, 53);
            this.rtb_CauHoi.TabIndex = 1;
            this.rtb_CauHoi.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đáp án:";
            // 
            // tb_DapAn
            // 
            this.tb_DapAn.Location = new System.Drawing.Point(75, 87);
            this.tb_DapAn.Name = "tb_DapAn";
            this.tb_DapAn.Size = new System.Drawing.Size(514, 21);
            this.tb_DapAn.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lĩnh Vực:";
            // 
            // comboBox_linhVuc
            // 
            this.comboBox_linhVuc.FormattingEnabled = true;
            this.comboBox_linhVuc.Location = new System.Drawing.Point(79, 137);
            this.comboBox_linhVuc.Name = "comboBox_linhVuc";
            this.comboBox_linhVuc.Size = new System.Drawing.Size(181, 21);
            this.comboBox_linhVuc.TabIndex = 5;
            // 
            // comboBox_GoiCauHoi
            // 
            this.comboBox_GoiCauHoi.FormattingEnabled = true;
            this.comboBox_GoiCauHoi.Location = new System.Drawing.Point(355, 137);
            this.comboBox_GoiCauHoi.Name = "comboBox_GoiCauHoi";
            this.comboBox_GoiCauHoi.Size = new System.Drawing.Size(234, 21);
            this.comboBox_GoiCauHoi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gói Câu Hỏi:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(433, 188);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(514, 188);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // SuaCauHoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 223);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.comboBox_GoiCauHoi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_linhVuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_DapAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_CauHoi);
            this.Controls.Add(this.label1);
            this.Name = "SuaCauHoiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa Câu Hỏi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtb_CauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_DapAn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_linhVuc;
        private System.Windows.Forms.ComboBox comboBox_GoiCauHoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.Button btn_Thoat;
    }
}