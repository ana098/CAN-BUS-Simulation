using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace CAN_BUS_Simulation
{
    class LogFile
    {
        string Successfully = "Successfully sent!!  ->   ";
        string Error = "Error writing";
        int i;
        static string FileName = @"C:\Users\X\Desktop\Tx Rx " + DateTime.Today.ToString("MM/dd/yyyy") + ".txt";
      //  BinaryWriter bw = new BinaryWriter (File.OpenWrite(FileName));

        public void WriteLogTx(uint ID, byte[] Payload, byte Signal, string method)
        {
            using (var fileStream = new FileStream(FileName, FileMode.Append, FileAccess.Write, FileShare.None))
            using (var bw = new BinaryWriter(fileStream))
            {
                StringBuilder amountMsg = new StringBuilder();

                amountMsg.AppendFormat("{0:x2} ", ID);
                Payload[0] = Signal;

                for (i = 0; i < 8; i++)
                {
                    amountMsg.AppendFormat("{0:x2} ", Payload[i]);
                }

                // return amountMsg.ToString().ToUpper();

                /* ToOutputID = ID.ToString();
                 Payload[0] = Signal;
                     for (i = 1; i < 8; i++)
                     {
                         ToOutputP += Payload[i].ToString();
                     }*/

                bw.Write(new UTF8Encoding().GetBytes( Successfully + method + " Tx :" + amountMsg.ToString().ToUpper()));
                bw.Write(new UTF8Encoding().GetBytes(Environment.NewLine));
            }
        }

        public void WriteLogRx(string Rx, string method)
        {
            using (var fileStream = new FileStream(FileName, FileMode.Append, FileAccess.Write, FileShare.None))
            using (var bw = new BinaryWriter(fileStream))
            {
                bw.Write(new UTF8Encoding().GetBytes(Successfully + method + " Rx :" + Rx));
                bw.Write(new UTF8Encoding().GetBytes(Environment.NewLine));
            }
        }

        public void WriteError()
        {
            using (var fileStream = new FileStream(FileName, FileMode.Append, FileAccess.Write, FileShare.None))
            using (var bw = new BinaryWriter(fileStream))
            {
                bw.Write(new UTF8Encoding().GetBytes(Error));
                bw.Write(new UTF8Encoding().GetBytes(Environment.NewLine));
            }
        }

        public void Start(string date)
        {
            using (var fileStream = new FileStream(FileName, FileMode.Append, FileAccess.Write, FileShare.None))
            using (var bw = new BinaryWriter(fileStream))
            {
                bw.Write(new UTF8Encoding().GetBytes("******************" + date + "******************"));
                bw.Write(new UTF8Encoding().GetBytes(Environment.NewLine));
            }
        }
    }
}
