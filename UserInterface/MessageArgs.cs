using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
   public  class MessageArgs : EventArgs
    {
        public string MessageText
        { get; set; }
    }
}
