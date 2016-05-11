using BusinessLogic;
using DataTableObject;
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

        private void FillDataGridViewCauHoi(List<CauHoi> listCauHoi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT");
            dt.Columns.Add("Câu hỏi");
            dt.Columns.Add("Lĩnh vực");

            foreach(var item in listCauHoi)
            {
                dt.Rows.Add(item.ID_CauHoi, item.NoiDung);
            }

            dataGridView_CauHoi.DataSource = dt;

            dataGridView_CauHoi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_CauHoi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        private void listView_GoiCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dataGridView_CauHoi.Rows.Clear();
            CauHoiBUS chBUS = new CauHoiBUS();
            //FillDataGridViewCauHoi(chBUS.GetCauHoiByIdGoi(1));
        }


    }
}
