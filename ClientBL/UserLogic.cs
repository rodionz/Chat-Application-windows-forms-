using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using CommonTypes;
using System.IO;

namespace ClientBL
{
    public class UserLogic
    {

        public string IPadress
        { get; set; }

        public int UserPort
        { get; set; }

        public UserData Ud
        { get; set; }


        public MessageData Md
        { get; set; }


        public void ConnecttoServer ()
        {
            TcpClient client = new TcpClient();

            try
            {
                client.Connect(IPAddress.Loopback, UserPort);

                using (Stream str = client.GetStream())
                {

                    BinaryFormatter Bformat = new BinaryFormatter();
                    //Bformat.Serialize(str,object)

                }

            }


            finally
            {
                client.Close();
            }
        }

        public void SendMessage()
        {

        }

        public void Disconnect()
        {

        }

        public event EventHandler MessageRecieved;

    }
}
