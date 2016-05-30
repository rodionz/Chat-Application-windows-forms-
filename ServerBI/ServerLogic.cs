using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using CommonTypes;

namespace ServerBI
{
    public class ServerLogic
    {

        public string IPAdress
        { get; set; }

        public int Port
        { get; set; }

        public List<UserData>  udl
        { get; set; }

      


        public void  StartListening ()

        {


        }


        public void StopListening()

        {


        }

    }
}
