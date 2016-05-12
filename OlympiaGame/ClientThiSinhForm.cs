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
        String topic2Serer;
        public ClientThiSinhForm(String username)
        {
            InitializeComponent();
            userName = username;
            setupMQTT();
        }

        // BEGINMQTT
        private void setupMQTT()
        {
            // create client instance
            MqttClient client = new MqttClient(IPAddress.Parse(MQTT_BROKER_ADDRESS));

            // register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);

            // subscribe to the topic "/home/temperature" with QoS 2
            client.Subscribe(new string[] { "/server" }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

            topic2Serer = "/thisinh/" + clientId;
            client.Subscribe(new string[] { "/thisinh/"+clientId }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });

            client.Publish("/server", Encoding.UTF8.GetBytes(topic2Serer));
        }

        static void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Console.WriteLine("Msg:" + Encoding.UTF8.GetString(e.Message));
        }
        // ENDMQTT

        private void ClientThiSinhForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
