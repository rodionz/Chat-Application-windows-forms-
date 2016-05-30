using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using CommonTypes;


namespace ClientBL
{
    public class UserLogic
    {

        public string IPadress
        { get; set; }

        public int Port
        { get; set; }

        public UserData Ud
        { get; set; }


        public MessageData Md
        { get; set; }


        public void ConnecttoServer ()
        {


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
