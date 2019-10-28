using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAN_BUS_Simulation
{
    class CopySignal
    {
        StringBuilder StrBuild = new StringBuilder();
        int i;

        public string CopySg(uint ID, byte[] Payload, byte Signal)
        {
            StringBuilder amountMsg = new StringBuilder();

            amountMsg.AppendFormat("{0:x2} ", ID);
            Payload[0] = Signal;

            for (i = 0; i < 8; i++)
            {
                amountMsg.AppendFormat("{0:x2} ", Payload[i]);
            }

            return amountMsg.ToString().ToUpper();
        }
        
    }
}




/*  foreach (byte b in Payload)
       {
           Pay = StrBuild.AppendFormat("{0:x2}",Payload).ToString();
       }*/

//  Id = StrBuild.Append(" 0x",ID).ToString();