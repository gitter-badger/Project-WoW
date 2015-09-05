using Framework.Network.Packets;

namespace WorldNode.Packets.Client
{
    public class QueuedMessagesEnd : ClientPacket
    {
        public int Timestamp { get; set; }

        public override void Read()
        {
            Timestamp = Packet.Read<int>();
        }
    }
}
