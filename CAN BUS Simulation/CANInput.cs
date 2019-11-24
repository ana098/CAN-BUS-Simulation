using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAN_BUS_Simulation
{
    public class CANInput
    {
        CANmsg CanMessage = new CANmsg();

        public static byte[] InPayload { get; set; }
        public static int SigPos { get; set; }
        public static byte[] PrevPay { get; set; }

        public void CAN_Input(string InTxTPayload, int Signal_Position)
        {
            InPayload = CanMessage.GetPayload(InTxTPayload);
            SigPos = Signal_Position;
        }

        public void CAN_Input(string InTxTPayload, string PrevPayload, int Signal_Position)
        {
            InPayload = CanMessage.GetPayload(InTxTPayload);
            PrevPay = CanMessage.GetPayload(PrevPayload);
            SigPos = Signal_Position;
        }

        public void CAN_Input(string InTxtPayload)
        {
            InPayload = CanMessage.GetPayload(InTxtPayload);
        }

    }
}
