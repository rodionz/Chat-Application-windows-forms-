using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using ServerData;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

using UserInterface;

namespace TCP_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server();
            
            

           
            

            TcpListener listener1 = new TcpListener(IPAddress.Parse(server.IP), server.Port);
        
            TcpClient client1 = listener1.AcceptTcpClient();
           
            NetworkStream networkStream = client1.GetStream();
            BinaryFormatter bformater = new BinaryFormatter();
            

          

            
           

            networkStream.Close();
            client1.Close();
            listener1.Stop();
            

        }
    }
}
