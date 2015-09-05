using Framework.Misc;
using Framework.Network.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldServer.Constants.Net;

namespace WorldServer.Packets
{
    class UITime : ServerPacket
    {
        public uint DateTime { get; set; }

        public UITime() : base(ServerMessage.UITime) { }

        public override void Write()
        {
            Packet.Write(Helper.GetUnixTime());
        }
    }
}
