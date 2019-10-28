using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAN_BUS_Simulation
{
    class CopyTelegram
    {
        StringBuilder StrBuild = new StringBuilder();
        int i;

        public string CopyTg(uint ID, byte[] Payload, byte Signal)
        {
            StringBuilder amountMsg = new StringBuilder();

            amountMsg.AppendFormat("{0:x2} ", ID);
            amountMsg.AppendFormat("{0:x2} ", Signal);

            for (i = 1; i < 8; i++)
            {
                amountMsg.AppendFormat("{0:x2} ", Payload[i]);
            }

            return amountMsg.ToString().ToUpper();
        }
    }
}
