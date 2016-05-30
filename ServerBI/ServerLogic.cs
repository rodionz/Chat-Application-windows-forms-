﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using CommonTypes;
using System.IO;

namespace ServerBI
{
    public class ServerLogic
    {

        public string IPAdress
        { get; set; }

        public int Serverport
        { get; set; }

        public List<UserData>  udl
        { get; set; }

      


        public void  StartListening ()

        {
            TcpListener listener = new TcpListener(IPAddress.Loopback, Serverport);

            try
            {
                listener.Start();
                TcpClient talker = listener.AcceptTcpClient();
                //    TcpClient talker = listener.AcceptTcpClientAsync();
                using (Stream str = talker.GetStream())
                {


                }

            }

            finally
            {
                listener.Stop();
            }

        }


        public void StopListening()

        {


        }

    }
}
