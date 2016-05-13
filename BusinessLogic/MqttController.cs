using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace BusinessLogic
{
    public class MqttController
    {
        private MqttClient client;
        private String MQTT_BROKER_ADDRESS;

        public delegate void NewLogin(String username, String clientID); // For Server
        public delegate void ThongTin(String key,String msg); // For Client
        public delegate void Test(String msg); // For test
        public delegate void LogOut(String username); // For Server
        public Test test;
        public NewLogin newlogin;
        public ThongTin thongTin;
        public LogOut logOut;
        private String username;
        public String clientID { get; set; }

        public MqttController(String serverAddress,String username)
        {
            MQTT_BROKER_ADDRESS = serverAddress;
            MqttClient client = new MqttClient(IPAddress.Parse(MQTT_BROKER_ADDRESS));
            this.client = client;
            // register to message received
            client.MqttMsgPublishReceived += client_MqttMsgPublishReceived;

            string clientId = Guid.NewGuid().ToString();
            client.Connect(clientId);
            this.username = username;
        }

        public void client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            String msg = Encoding.UTF8.GetString(e.Message);
            String[] agrs = msg.Split('|');
            MqttClient mqttClient = (MqttClient)sender;

            if (newlogin != null)
            {
                if (e.Topic.Equals("/thiSinhLogin"))
                {
                    newlogin.Invoke(agrs[0], agrs[1]);
                }
            }

            if (test != null)
            {
                if (e.Topic.Equals("/test"))
                {
                    test.Invoke(msg);
                }
            }

            if (thongTin != null)
            {
                if (e.Topic.Equals("/ten/"+username))
                {
                    thongTin.Invoke("Ten",msg);
                }

                if (e.Topic.Equals("/diem/" + username))
                {
                    thongTin.Invoke("Diem", msg);
                }

                if (e.Topic.Equals("/cauhoi/" + username))
                {
                    thongTin.Invoke("CauHoi", msg);
                }

                if (e.Topic.Equals("/socaudung/" + username))
                {
                    thongTin.Invoke("SoCauDung", msg);
                }
            }

            if(logOut != null)
            {
                if (e.Topic.Equals("/logout"))
                {
                    logOut.Invoke(msg);
                }
            }
        }

        public void Disconnect()
        {
            client.Disconnect();
        }

        public void Subscribe(String topic)
        {
            client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_EXACTLY_ONCE });
        }

        public void Publish(String topic,String content)
        {
            client.Publish(topic,Encoding.UTF8.GetBytes(content));
        }
    }
}
