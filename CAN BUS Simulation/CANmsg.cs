using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace CAN_BUS_Simulation
{
    class CANmsg:Message
    {
        uint ID;
        byte Signal;
        byte tempID;
        byte[] Payload;
        string tempByte;
        int i;
        string ToOutputID;
        string ToOutputP;
        byte[] DP;

        ByteConverter ByteConv = new ByteConverter();

            public CANmsg(uint ID, byte [] Payload)
            {
                this.ID = ID;
                this.Payload = Payload;
                Signal = Payload[0];
            }

    public byte[] DefPayload {get;set;}
           /* {
                get
                {
                    return DP;
                }
                set
                {
                    DP = new byte[] { 0xF0, 0xF1, 0xF2, 0xF3, 0xF4, 0xF5, 0xF6, 0xF7 };
                }
            }*/

            public CANmsg()
            {
                DefPayload = new byte[] { 0xF0, 0xF1, 0xF2, 0xF3, 0xF4, 0xF5, 0xF6, 0xF7 };
                this.Payload = new byte[] {0xF0,0xF1,0xF2,0xF3,0xF4,0xF5,0xF6,0xF7};
                this.ID = 0xFF;
            }

            public override uint GetId(string strID)
            {
                tempID = (byte)ByteConv.ConvertFromString(strID);
                ID = Convert.ToUInt32(tempID);
                return ID;
            }

            public override byte[] GetPayload(string PayLd)
            {
                    for (int b = 1; b < 8; b++)
                    {
                        tempByte = PayLd.Substring(i, 4);
                        this.Payload[b] = (byte)ByteConv.ConvertFromString(tempByte);
                        i += 4;
                        
                    }
                    i = 0;
                return this.Payload;
            }

            public override byte GetSignal(string Signal)
            {
                var tempSignal = (byte)ByteConv.ConvertFromString(Signal);
                return tempSignal;
            }



            public string OutputMsg(uint ID, byte[] Payload, byte Signal)       
            {
                ToOutputID = ID.ToString();
                Payload[0] = Signal;
                for (i = 1; i < 8; i++)
                {
                    ToOutputP += Payload[i].ToString();
                }
                return ToOutputID+ " " + ToOutputP;
            }

    }
}
//0xA1 0xA10xA20xA30xA40xA50xA60xA70xA0
//0xA1 0x000x000x000x000x000x000x000x00