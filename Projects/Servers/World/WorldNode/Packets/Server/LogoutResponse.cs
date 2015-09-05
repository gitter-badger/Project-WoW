using Framework.Misc;
using Framework.Network.Packets;
using WorldNode.Constants.Net;

namespace WorldNoder.Packets.Server
{
    class LogoutResponse : ServerPacket
    {
        public int Reason { get; set; }
        public bool Instant { get; set; }

        public LogoutResponse() : base(ServerMessage.LogoutResponse) { }

        public override void Write()
        {
            Packet.Write(Reason);
            Packet.PutBit(Instant);
            Packet.FlushBits();
        }
    }
}
