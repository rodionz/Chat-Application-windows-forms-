using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerInterface
{
   public static class ServerBools
    {
        public static bool PortValid
        { get; set; } = false;

        public static bool IPisVAlid
        { get; set; } = false;

        public static bool ServerisValid
        {

            get
            {
                if (PortValid && ServerisValid)
                    return true;

                else
                    return
                        false;

            }

        }

    public static bool PortisValid(this int num)
        {
            if (num > 10000 && num < 65535)
                return true;
            else
                return false;


        }


    }
}
