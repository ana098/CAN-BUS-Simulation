using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAN_BUS_Simulation
{
    class CopySignal
    {
        StringBuilder amountMsg = new StringBuilder();
        CANmsg CanMessage = new CANmsg();

        public string CopySg(byte[] Payload, int Signal_Position)
        {

                CanMessage.DefPayload[Signal_Position] = Payload[Signal_Position];

                foreach (byte b in CanMessage.DefPayload)
                {
                    amountMsg.AppendFormat("{0:x2} ", b);
                }

            return amountMsg.ToString().ToUpper();
        }


        public string CopySg(byte[] Payload, byte[] PrevPayload, int Signal_Position)
        {
            amountMsg.Clear();

            PrevPayload[Signal_Position] = Payload[Signal_Position];

            foreach (byte b in PrevPayload)
            {
                amountMsg.AppendFormat("{0:x2} ", b);
            }

            return amountMsg.ToString().ToUpper();
        }
      
    }
}