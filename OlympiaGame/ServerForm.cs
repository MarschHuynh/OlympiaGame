using BusinessLogic;
using DataTableObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace OlympiaGame
{
    public partial class ServerForm : DevExpress.XtraEditors.XtraForm
    {
        class ThiSinh {
            public String ID { get; set; }
            public String Ten { get; set; }
            public String clientID { get; set; }
            public int Diem { get; set; }
            public int Kq_KD { get; set; }
            public String Username { get; set; }

            public ThiSinh(String username,String clientID,String ten)
            {
                this.Username = username;
                this.clientID = clientID;
                this.Ten = ten;
            }
        }

        class KhoiDongGame
        {
            public String Username
            {
                get; set;
            }
            public int Diem
            {
                get; set;
            }
            int SocauHoi;
            int CauHoiHienTai;
            List<CauHoi> CacCauHoiHienTai;

            public KhoiDongGame(String user,int diem,int sch,List<CauHoi> listch)
            {
                this.CauHoiHienTai = -1;
                this.Username = user;
                this.Diem = diem;
                this.CacCauHoiHienTai = listch;
                this.SocauHoi = sch;
            }

            public CauHoi CauHoiTiepTheo()
            {
                this.CauHoiHienTai++;
                if (CauHoiHienTai < SocauHoi)
                    return this.CacCauHoiHienTai.ToArray()[this.CauHoiHienTai];
                else
                    return null;
            }

            public void TraLoiDung()
            {
                if (CauHoiHienTai <= SocauHoi)
                    this.Diem += 10;
            }
        }

        String MQTT_BROKER_ADDRESS = "192.168.1.6";
        private Dictionary<String,ThiSinh> thiSinhD;
        private Dictionary<String, String> topicD;
        KhoiDongGame KhoiDong;
        MqttController mqttControl;

        public ServerForm()
        {
            InitializeComponent();
            mqttControl = new MqttController(MQTT_BROKER_ADDRESS,"server");
            mqttControl.newlogin += new MqttController.NewLogin(ThiSinhMoiDangNhap);
            mqttControl.test += new MqttController.Test(testMqtt);
            mqttControl.logOut += new MqttController.LogOut(ThisinhThoat);
            thiSinhD = new Dictionary<String, ThiSinh>();
            topicD = new Dictionary<String, String>();
            mqttControl.Subscribe("/thiSinhLogin");
            mqttControl.Subscribe("/thongTin");
            mqttControl.Subscribe("/test");
            mqttControl.Subscribe("/logout");
        }

        private void ThiSinhMoiDangNhap(String username,String clientID)
        {
            Console.WriteLine("User: " + username);
            thiSinhD.Add(username,new ThiSinh(username, clientID, new UserBUS().GetUserByUserName(username).Ten));
            mqttControl.Publish("/ten/" + username, thiSinhD[username].Ten);
            FillDataGridViewThiSinh();
        }

        private void ThisinhThoat(String username)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                thiSinhD.Remove(username);
            }));
            Console.WriteLine("LOGOUT: " + username);
            FillDataGridViewThiSinh();
        }

        private void testMqtt(String msg)
        {
            Console.WriteLine("MES: " + msg);
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
            SendCauHoiTiepTheo();
            KhoiDong.TraLoiDung();
            mqttControl.Publish("/diem/" + KhoiDong.Username,KhoiDong.Diem.ToString());
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

        void FillDataGridViewThiSinh()
        {
            this.Invoke(new MethodInvoker(delegate
            {
                cb_ThiSinh.Items.Clear();
            }));
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên");
            dt.Columns.Add("Điểm");
            foreach (var item in thiSinhD)
            {
                dt.Rows.Add(item.Value.Ten,item.Value.Diem);
                this.Invoke(new MethodInvoker(delegate
                {
                    cb_ThiSinh.Items.Add(item.Value.Ten);
                }));
                
            }
            this.Invoke(new MethodInvoker(delegate {
                dataGridView_ThiSinh.DataSource = dt;
                dataGridView_ThiSinh.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridView_ThiSinh.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            }));
            

           
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
                suaForm.ShowDialog();
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

        private void ServerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mqttControl.Disconnect();
            System.Windows.Forms.Application.Exit();
        }

        private void dataGridView_ThiSinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox_GoiCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void SendCauHoiTiepTheo()
        {
            CauHoi next = KhoiDong.CauHoiTiepTheo();
            if (next != null){
                rtb_CauHoi.Text = next.NoiDung+ "\nĐáp Án:"+next.DapAn;
                mqttControl.Publish("/cauhoi/" + KhoiDong.Username, next.NoiDung);
            } else {
                rtb_CauHoi.Text = "HẾT RỒI";
            }
        }
        private void btn_BatDau_KD_Click(object sender, EventArgs e)
        {
            PleaseWaitForm please = new PleaseWaitForm();
            please.Show();
            please.Refresh();
            String username = cb_ThiSinh.SelectedIndex==-1? "" : thiSinhD.ToArray()[cb_ThiSinh.SelectedIndex].Key;
            Console.WriteLine(username);
            if (!String.IsNullOrEmpty(comboBox_GoiCauHoi.Text) && !String.IsNullOrEmpty(cb_ThiSinh.Text))
            {
                List<CauHoi> listCauHoi = new CauHoiBUS().GetCauHoiByIdGoi(new GoiCauHoiBUS().GetGoiCauHoiByTen(comboBox_GoiCauHoi.Text).ID_Goi);
                KhoiDong = new KhoiDongGame(username, 0, listCauHoi.Count, listCauHoi);
                mqttControl.Publish("/diem/" + KhoiDong.Username, KhoiDong.Diem.ToString());
                SendCauHoiTiepTheo();
            }
            btn_Dung.Enabled = true;
            btn_Sai.Enabled = true;
            btn_BoQua.Enabled = true;
            please.Close();
        }
    }
}
