using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CAN_BUS_Simulation
{
    public class Message
    {

        public virtual uint GetId(string strID) { return 0; }
        public virtual byte[] GetPayload(string Payload) { return new byte[] {00}; }
    }

}
