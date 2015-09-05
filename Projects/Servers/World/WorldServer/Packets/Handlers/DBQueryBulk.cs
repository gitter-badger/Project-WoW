using System;
using Framework.Network.Packets;
using Framework.Objects;
using World.Shared.Game.Entities.Object.Guid;

namespace WorldServer.Packets.Handlers
{
    public class DBQueryBulk : ClientPacket
    {
        public UInt32 Id { get; private set; }
        public UInt32 Count { get; private set; }

        public struct QueryEntry
        {
            public ItemGuid Guid;
            public UInt32 Value;
        }

        public QueryEntry[] Entries { get; private set; }

        public override void Read()
        {
            Id = Packet.Read<UInt32>();
            Count = Packet.GetBits<UInt32>(13);

            Entries = new QueryEntry[Count];

            for (int i = 0; i < Count; i++)
            {
                Entries[i] = new QueryEntry
                {
                    Guid = Packet.ReadGuid<ItemGuid>(),
                    Value = Packet.Read<UInt32>()
                };
            }
        }
    }
}