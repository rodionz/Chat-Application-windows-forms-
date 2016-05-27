using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;
using UserData;

using UserInterface;



namespace TCP_Client
{
    class Program
    {
        static void Main(string[] args)
        {

            User user1 = new User();

            TcpClient client = new TcpClient();
            client.Connect(IPAddress.Parse(user1.IP), user1.Port);
            NetworkStream stream = client.GetStream();
            BinaryFormatter formatter = new BinaryFormatter();
          
          
           

            stream.Close();
            client.Close();



        }
    }
}
