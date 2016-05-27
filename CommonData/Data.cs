using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonData
{
    public class Data
    {
        private int port = 50000;
        public int Port
        {
            get { return port; }

            set { port = value; }
        }

        private string ip = "127.0.0.1";
        public string IP
        {

            get { return ip; }

            set { ip = value; }
        }


    }
}
