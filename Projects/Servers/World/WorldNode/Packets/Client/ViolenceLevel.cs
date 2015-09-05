using Framework.Network.Packets;

namespace WorldNode.Packets.Client
{
    public class ViolenceLevel : ClientPacket
    {
        public byte Level;

        public override void Read()
        {
            Level = Packet.Read<byte>();
        }
    }
}
