using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAN_BUS_Simulation
{
    class CopyTelegram
    {
        StringBuilder amountMsg = new StringBuilder();

        public string CopyTg(byte[] Payload)
        {
            amountMsg.Clear();

            foreach (byte b in Payload)
            {
                amountMsg.AppendFormat("{0:x2} ", b);
            }

            return amountMsg.ToString().ToUpper();
        }
    }
}
