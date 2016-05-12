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
using BusinessLogic;

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

        public void DangNhap()
        {
            int status = new UserBUS().Authentication(tb_username.Text, tb_password.Text);
            if (status == 0)
            {
                MessageBox.Show("Tài khoản này không tồn tại", "Lỗi");
            } 
            else if (status==1){
                MessageBox.Show("Mật khẩu sai, vui lòng thử lại", "Lỗi");
            } else if (status == 2)
            {
                loadServer();
            } else if (status == 4)
            {
                loadClientThiSinh();
            }
        }

        public void loadClientThiSinh()
        {
            Hide();
            ClientThiSinhForm thisinhForm = new ClientThiSinhForm(tb_username.Text);
            thisinhForm.Show();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void tb_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                DangNhap();
            }
        }
    }
}