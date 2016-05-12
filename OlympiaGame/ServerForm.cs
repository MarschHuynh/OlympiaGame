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
            PleaseWaitForm pleaseWait = new PleaseWaitForm();
            pleaseWait.Show();
            pleaseWait.Refresh();
            GoiCauHoiBUS gchBUS = new GoiCauHoiBUS();
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("Gói câu hỏi");
            
            foreach (var item in gchBUS.GetALLGoiCauHoi())
            {
                dt.Rows.Add(item.ID_Goi, item.Ten);
                comboBox_GoiCauHoi.Items.Add(item.Ten);
            }

            dataGridView_GoiCauHoi.DataSource = dt;
            dataGridView_GoiCauHoi.Columns[0].Visible = false;
            dataGridView_GoiCauHoi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            pleaseWait.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FillDataGridViewCauHoi(List<CauHoi> listCauHoi)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("STT");
            dt.Columns.Add("Tên");
            dt.Columns.Add("Câu hỏi");
            dt.Columns.Add("Lĩnh vực");
            dt.Columns.Add("Đáp án");
            dt.Columns.Add("id_goiCauHoi");
            int i = 0;
            foreach(var item in listCauHoi)
            {
                dt.Rows.Add(item.ID_CauHoi,++i,item.Ten, item.NoiDung,item.LinhVuc,item.DapAn,item.ID_Goi);
            }

            dataGridView_CauHoi.DataSource = dt;

            dataGridView_CauHoi.Columns[0].Visible = false;
            dataGridView_CauHoi.Columns[1].Visible = false;
            dataGridView_CauHoi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_CauHoi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridView_CauHoi.Columns[5].Visible = false;
            dataGridView_CauHoi.Columns[6].Visible = false;
        }

        private void dataGridView_GoiCauHoi_SelectionChanged(object sender, EventArgs e)
        {
            loadDataGrid();
        }

        private void loadDataGrid()
        {
            CauHoiBUS chBUS = new CauHoiBUS();
            if (dataGridView_GoiCauHoi.CurrentRow != null)
                FillDataGridViewCauHoi(chBUS.GetCauHoiByIdGoi(Convert.ToInt32(dataGridView_GoiCauHoi.CurrentRow.Cells[0].Value.ToString())));
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView_CauHoi.CurrentRow != null)
            {
                SuaCauHoiForm suaForm = new SuaCauHoiForm(dataGridView_CauHoi.CurrentRow);
                suaForm.reload += new SuaCauHoiForm.Finish(loadDataGrid);
                suaForm.Show();
            }
        }

        private void btn_deleteNhom_Click(object sender, EventArgs e)
        {
            PleaseWaitForm pleaseWait = new PleaseWaitForm();
            pleaseWait.Show();
            new GoiCauHoiBUS().XoaGoiCauHoi(Convert.ToInt32(dataGridView_GoiCauHoi.CurrentRow.Cells[0].Value.ToString()));
            pleaseWait.Close();
        }

        private void btn_addNhom_Click(object sender, EventArgs e)
        {
            ThemGoiCauHoiForm themgch = new ThemGoiCauHoiForm();
            themgch.Show();
        }

        private void btn_addCauHoi_Click(object sender, EventArgs e)
        {
            SuaCauHoiForm suaCauHoi = new SuaCauHoiForm();
            suaCauHoi.reload += new SuaCauHoiForm.Finish(loadDataGrid);
            suaCauHoi.Show();
        }

        private void btn_deleteCauHoi_Click(object sender, EventArgs e)
        {
            if (dataGridView_CauHoi.CurrentRow != null)
            {
                new CauHoiBUS().XoaCauHoiById(Convert.ToInt32(dataGridView_CauHoi.CurrentRow.Cells[0].Value.ToString()));
                loadDataGrid();
            }
        }
    }
}
