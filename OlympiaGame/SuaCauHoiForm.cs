using BusinessLogic;
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
    public partial class SuaCauHoiForm : DevExpress.XtraEditors.XtraForm
    {
        int idCauHoi;
        int id_goiCH;
        public SuaCauHoiForm(DataGridViewRow row)
        {
            InitializeComponent();
            idCauHoi = Convert.ToInt32( row.Cells[0].Value.ToString());
            rtb_CauHoi.Text = row.Cells[2].Value.ToString();
            comboBox_linhVuc.Text = row.Cells[3].Value.ToString();
            tb_DapAn.Text = row.Cells[4].Value.ToString();

            id_goiCH = Convert.ToInt32( row.Cells[5].Value.ToString());

            GoiCauHoiBUS gchBUS = new GoiCauHoiBUS();
            
            foreach (var item in gchBUS.GetALLGoiCauHoi())
            {
                if (item.ID_Goi == id_goiCH)
                    comboBox_GoiCauHoi.Text = item.Ten;
                comboBox_GoiCauHoi.Items.Add(item.Ten);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            new CauHoiBUS().CapNhatCauHoi(idCauHoi, rtb_CauHoi.Text, comboBox_linhVuc.Text, new GoiCauHoiBUS().GetGoiCauHoiByTen(comboBox_GoiCauHoi.Text).ID_Goi,tb_DapAn.Text);
        }
    }
}
