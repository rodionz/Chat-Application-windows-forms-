using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInterface
{
   public class ServerBools
    {
        public static bool PortisValid
        { get; set; } = false;

        public static bool IPisVAlid
        { get; set; } = false;

        public static bool ServerisValid
        {

            get
            {
                if (PortisValid && ServerisValid)
                    return true;

                else
                    return
                        false;

            }

        }
    }
}
