using Framework.Network.Packets;

namespace WorldServer.Packets.Client.Character
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
