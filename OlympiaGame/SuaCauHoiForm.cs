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
        public delegate void Finish();
        public Finish reload;
        private Boolean validate = true;
        public SuaCauHoiForm(DataGridViewRow row)
        {
            InitializeComponent();
            idCauHoi = Convert.ToInt32( row.Cells[0].Value.ToString());
            tb_ten.Text = row.Cells[2].Value.ToString();
            rtb_CauHoi.Text = row.Cells[3].Value.ToString();
            comboBox_linhVuc.Text = row.Cells[4].Value.ToString();
            tb_DapAn.Text = row.Cells[5].Value.ToString();

            id_goiCH = Convert.ToInt32( row.Cells[6].Value.ToString());

            GoiCauHoiBUS gchBUS = new GoiCauHoiBUS();
            int index = 0;
            foreach (var item in gchBUS.GetALLGoiCauHoi())
            {
                comboBox_GoiCauHoi.Items.Add(item.Ten);
                if (item.ID_Goi == id_goiCH)
                    comboBox_GoiCauHoi.SelectedIndex = index;
                index++;
            }
        }

        public SuaCauHoiForm()
        {
            InitializeComponent();
            foreach (var item in new GoiCauHoiBUS().GetALLGoiCauHoi())
            {
                if (item.ID_Goi == id_goiCH)
                    comboBox_GoiCauHoi.Text = item.Ten;
                comboBox_GoiCauHoi.Items.Add(item.Ten);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            reload.Invoke();
            this.Close();
        }

        public Boolean validation()
        {
            validate = true;
            tb_ten_Validating(tb_ten, new CancelEventArgs());
            rtb_CauHoi_Validating(rtb_CauHoi, new CancelEventArgs());
            tb_DapAn_Validating(tb_DapAn, new CancelEventArgs());
            comboBox_GoiCauHoi_Validating(comboBox_GoiCauHoi, new CancelEventArgs());
            return validate;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            Console.Write("Ngoai BUTTON");
            if (validation())
            {
                Console.Write("Trong BUTTON");
                new CauHoiBUS().CapNhatOrThemCauHoi(idCauHoi, tb_ten.Text, rtb_CauHoi.Text, comboBox_linhVuc.Text, new GoiCauHoiBUS().GetGoiCauHoiByTen(comboBox_GoiCauHoi.Text).ID_Goi, tb_DapAn.Text);
                reload.Invoke();
                this.Close();
            }
        }

        private void tb_ten_Validating(object sender, CancelEventArgs e)
        {
            if (tb_ten.Text == string.Empty || tb_ten.Text.Equals("This field is required"))
            {
                errorProvider_ten.Icon = Properties.Resources.err;
                errorProvider_ten.SetError(tb_ten, "This field is required");
                validate = false;
            }
            else
            {
                errorProvider_ten.Icon = Properties.Resources.ok;
                errorProvider_ten.SetError(tb_ten, "Ok");
            }
                
        }

        private void rtb_CauHoi_Validating(object sender, CancelEventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (rtb.Text == string.Empty || rtb.Text.Equals("This field is required"))
            {
                errorProvider_cauhoi.Icon = Properties.Resources.err;
                errorProvider_cauhoi.SetError(rtb, "This field is required");
                validate = false;
            }
            else
            {
                errorProvider_cauhoi.Icon = Properties.Resources.ok;
                errorProvider_cauhoi.SetError(rtb, "Ok");
            }
        }

        private void tb_DapAn_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == string.Empty || tb.Text.Equals("This field is required"))
            {
                errorProvider_dapan.Icon = Properties.Resources.err;
                errorProvider_dapan.SetError(tb, "This field is required");
                validate = false;
            }
            else
            {
                errorProvider_dapan.Icon = Properties.Resources.ok;
                errorProvider_dapan.SetError(tb, "Ok");
            }
        }

        private void comboBox_GoiCauHoi_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cmb = (ComboBox) sender;
            if (cmb.Text == string.Empty || cmb.Text.Equals("This field is required"))
            {
                errorProvider_gch.Icon = Properties.Resources.err;
                errorProvider_gch.SetError(cmb, "This field is required");
                validate = false;
            }
            else
            {
                errorProvider_gch.Icon = Properties.Resources.ok;
                errorProvider_gch.SetError(cmb, "Ok");
            }
        }
    }
}
