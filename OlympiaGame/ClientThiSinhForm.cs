using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace OlympiaGame
{
    public partial class ClientThiSinhForm : DevExpress.XtraEditors.XtraForm
    {
        String MQTT_BROKER_ADDRESS = "192.168.1.6";
        String userName;
        MqttController mqttController;
        public ClientThiSinhForm(String username)
        {
            InitializeComponent();
            userName = username;
            mqttController = new MqttController(MQTT_BROKER_ADDRESS,username);
            mqttController.Publish("/thiSinhLogin", userName + '|' + mqttController.clientID);
            mqttController.Subscribe("/ten/" + username);
            mqttController.Subscribe("/diem/" + username);
            mqttController.Subscribe("/socaudung/" + username);
            mqttController.Subscribe("/cauhoi/" + username);
            mqttController.Subscribe("/test" + mqttController.clientID);
            mqttController.thongTin += new MqttController.ThongTin(CapNhatThongTin);
            mqttController.test += new MqttController.Test(TestMqtt);
        }

        private void ClientThiSinhForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mqttController.Publish("/logout", userName);
            mqttController.Disconnect();
            System.Windows.Forms.Application.Exit();
        }

        private void CapNhatThongTin(String key,String msg)
        {
            if (key.Equals("Ten"))
            {
                this.Invoke(new MethodInvoker(delegate { lb_ten.Text = msg; }));
                Console.Write("Ten:" + msg);
            }
            else if (key.Equals("Diem"))
            {
                this.Invoke(new MethodInvoker(delegate { lb_Diem.Text = msg; }));
                Console.Write("Diem:" + msg);
            }
            else if (key.Equals("CauHoi"))
            {
                this.Invoke(new MethodInvoker(delegate { rtb_CauHoi.Text = msg; }));
                Console.Write("Diem:" + msg);
            }
            else if (key.Equals("SoCauDung"))
            {
                this.Invoke(new MethodInvoker(delegate { lb_soCauDung.Text = msg; }));
                Console.Write("Diem:" + msg);
            }
        }

        private void TestMqtt(String msg)
        {
            Console.WriteLine("MSG:" + msg);
        }
    }
}
