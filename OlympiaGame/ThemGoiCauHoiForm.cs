using BusinessLogic;
using DataTableObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympiaGame
{
    public partial class ThemGoiCauHoiForm : Form
    {
        public ThemGoiCauHoiForm()
        {
            InitializeComponent();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            GoiCauHoi gch = new GoiCauHoiBUS().GetGoiCauHoiByTen(tb_TenGoiCauHoi.Text);
           
            if (gch == null)
            {
                new GoiCauHoiBUS().TaoGoiCauHoi(tb_TenGoiCauHoi.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Tên gói câu hỏi đã trùng. Bạn vui lòng chọn tên khác");
            }

        }
    }
}
