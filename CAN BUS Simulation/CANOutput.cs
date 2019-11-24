using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAN_BUS_Simulation
{
    class CANOutput
    {

        LogFile WriteLog = new LogFile();
        CopySignal CpSg = new CopySignal();
        CopyTelegram CpTg = new CopyTelegram();

        public static string OutPayload { get;  set; }

        public string CAN_Output(string CheckIn, bool FirstClick)
        {
            byte[] Payload = CANInput.InPayload;
            int Sig_Pos = CANInput.SigPos;
            byte [] PreviousPayload = CANInput.PrevPay;


            if (CheckIn == "CS" && FirstClick == true)
            {
                return OutPayload = CpSg.CopySg(Payload, Sig_Pos);
            }

            else if (CheckIn == "CT")
            {
                return OutPayload = CpTg.CopyTg(Payload);
            }

            else
            {
                OutPayload = null;
                return OutPayload = CpSg.CopySg(Payload, PreviousPayload, Sig_Pos);
            }
        }
    }
}
