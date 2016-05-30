using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CommonTypes
{
  public  class MessageData
    {
        public string Textmessage
        { get; set; }

        public DateTime Dt
        { get; set; }

        public Color Messagecolor
        { get; set; }

        public UserData Ud
        { get; set; }

        public Font Uf
        { get; set; }
    }
}
