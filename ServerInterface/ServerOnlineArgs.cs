using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonTypes;

namespace ServerInterface
{
  public  class ServerOnlineArgs : EventArgs
    {

        public string IPofServer
        { get; set; }

        public int PortofServer
        { get; set; }

    }
}
