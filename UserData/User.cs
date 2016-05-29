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
using CommonData;

namespace UserData
{
    public class User : Data
    {

      public string Nickname
        { get; set; }

        public int UserID
        { get; set; }


        public User(int _userID)

        {

            this.UserID = _userID;

        }
    }
}
