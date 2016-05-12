namespace OlympiaGame
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
            this.components = new System.ComponentModel.Container();
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
            this.label5 = new System.Windows.Forms.Label();
            this.tb_ten = new System.Windows.Forms.TextBox();
            this.errorProvider_ten = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_cauhoi = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_dapan = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_gch = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ten)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_cauhoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_dapan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_gch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Câu hỏi: ";
            // 
            // rtb_CauHoi
            // 
            this.rtb_CauHoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_CauHoi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_CauHoi.Location = new System.Drawing.Point(75, 68);
            this.rtb_CauHoi.Name = "rtb_CauHoi";
            this.rtb_CauHoi.Size = new System.Drawing.Size(514, 53);
            this.rtb_CauHoi.TabIndex = 1;
            this.rtb_CauHoi.Text = "";
            this.rtb_CauHoi.Validating += new System.ComponentModel.CancelEventHandler(this.rtb_CauHoi_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đáp án:";
            // 
            // tb_DapAn
            // 
            this.tb_DapAn.Location = new System.Drawing.Point(75, 142);
            this.tb_DapAn.Name = "tb_DapAn";
            this.tb_DapAn.Size = new System.Drawing.Size(514, 21);
            this.tb_DapAn.TabIndex = 3;
            this.tb_DapAn.Validating += new System.ComponentModel.CancelEventHandler(this.tb_DapAn_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lĩnh Vực:";
            // 
            // comboBox_linhVuc
            // 
            this.comboBox_linhVuc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_linhVuc.FormattingEnabled = true;
            this.comboBox_linhVuc.Location = new System.Drawing.Point(79, 192);
            this.comboBox_linhVuc.Name = "comboBox_linhVuc";
            this.comboBox_linhVuc.Size = new System.Drawing.Size(181, 21);
            this.comboBox_linhVuc.TabIndex = 5;
            // 
            // comboBox_GoiCauHoi
            // 
            this.comboBox_GoiCauHoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_GoiCauHoi.FormattingEnabled = true;
            this.comboBox_GoiCauHoi.Location = new System.Drawing.Point(355, 192);
            this.comboBox_GoiCauHoi.Name = "comboBox_GoiCauHoi";
            this.comboBox_GoiCauHoi.Size = new System.Drawing.Size(234, 21);
            this.comboBox_GoiCauHoi.TabIndex = 7;
            this.comboBox_GoiCauHoi.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_GoiCauHoi_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(266, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Gói Câu Hỏi:";
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(431, 225);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 8;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.btn_OK_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(514, 225);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_Thoat.TabIndex = 9;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tên:";
            // 
            // tb_ten
            // 
            this.tb_ten.Location = new System.Drawing.Point(75, 20);
            this.tb_ten.Name = "tb_ten";
            this.tb_ten.Size = new System.Drawing.Size(514, 21);
            this.tb_ten.TabIndex = 11;
            this.tb_ten.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ten_Validating);
            // 
            // errorProvider_ten
            // 
            this.errorProvider_ten.ContainerControl = this;
            // 
            // errorProvider_cauhoi
            // 
            this.errorProvider_cauhoi.ContainerControl = this;
            // 
            // errorProvider_dapan
            // 
            this.errorProvider_dapan.ContainerControl = this;
            // 
            // errorProvider_gch
            // 
            this.errorProvider_gch.ContainerControl = this;
            // 
            // SuaCauHoiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 260);
            this.Controls.Add(this.tb_ten);
            this.Controls.Add(this.label5);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SuaCauHoiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sửa Câu Hỏi";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_ten)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_cauhoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_dapan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_gch)).EndInit();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_ten;
        private System.Windows.Forms.ErrorProvider errorProvider_ten;
        private System.Windows.Forms.ErrorProvider errorProvider_cauhoi;
        private System.Windows.Forms.ErrorProvider errorProvider_dapan;
        private System.Windows.Forms.ErrorProvider errorProvider_gch;
    }
}