using Framework.Network.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World.Shared.Game.Entities.Object.Guid;
using WorldServer.Packets.Structures.Account;

namespace WorldServer.Packets.Client.Misc
{
    public class RequestAccountData : ClientPacket
    {
        public PlayerGuid PlayerGuid { get; private set; }
        public DataType Type { get; private set; }
        
        public override void Read()
        {
            PlayerGuid = Packet.ReadGuid<PlayerGuid>();
            Type = Packet.GetBits<DataType>(3);
        }
    }
}
