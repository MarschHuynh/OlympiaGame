using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OlympiaGame
{
    public partial class StartForm : DevExpress.XtraEditors.XtraForm
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadServer()
        {
            Hide();
            ServerForm server = new ServerForm();
            server.Show();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            if (tb_password.Text == "s" && tb_password.Text == "s"){
                loadServer();
            }
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (tb_password.Text == "s" && tb_password.Text == "s")
                {
                    loadServer();
                }
            }
        }
    }
}