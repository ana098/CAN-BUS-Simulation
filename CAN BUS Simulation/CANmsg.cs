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
        byte tempID;
        byte[] Payload;


        ByteConverter ByteConv = new ByteConverter();
        Conversion conv = new Conversion();

            public CANmsg(uint ID, byte [] Payload)
            {
                this.ID = ID;
                this.Payload = Payload;
            }

            public byte[] DefPayload {get;set;}

            public CANmsg()
            {
                DefPayload = new byte[] { 0X00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 }; 
                Payload = new byte[] {0xF0,0xF1,0xF2,0xF3,0xF4,0xF5,0xF6,0xF7};
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
                Payload = conv.StringToByteArray(PayLd);
                return Payload;
            }

    }
}
//0xA1 0xA10xA20xA30xA40xA50xA60xA70xA0
//0xA1 0x000x000x000x000x000x000x000x00