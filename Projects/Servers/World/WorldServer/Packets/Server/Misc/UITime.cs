using Framework.Misc;
using Framework.Network.Packets;
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
