using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OlympiaGame
{
    public partial class ServerForm : DevExpress.XtraEditors.XtraForm
    {
        public ServerForm()
        {
            InitializeComponent();
        }


        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabNavigationPage1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            GoiCauHoiBUS gchBUS = new GoiCauHoiBUS();
            foreach(var item in gchBUS.GetALLGoiCauHoi())
            {
                listView_GoiCauHoi.Items.Add(item.Ten);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listView_GoiCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView_CauHoi.Clear();
            CauHoiBUS chBUS = new CauHoiBUS();
            foreach (var item in chBUS.GetCauHoiByIdGoi(1))
            {
                listView_CauHoi.Items.Add(item.Ten+":"+item.NoiDung);
            }
            
        }


    }
}
