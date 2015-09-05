using Framework.Network.Packets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using World.Shared.Game.Entities.Object.Guid;

namespace WorldServer.Packets.Client.Misc
{
    public class RequestAccountData : ClientPacket
    {
        public PlayerGuid PlayerGuid { get; private set; }
        public DataType Type { get; private set; }

        public enum DataType : byte
        {
            GlobalConfigCache            = 0,
            PerCharacterConfigCache      = 1,
            GlobalBindingsCache          = 2,
            PerCharacterBindingsCache    = 3,
            GlobalMacrosCache            = 4,
            PerCharacterMacrosCache      = 5,   
            PerCharacterLayoutCache      = 6, 
            PerCharacterChatCache        = 7,   
            NumAccountDataTypes          = 8
        }

        public override void Read()
        {
            PlayerGuid = Packet.ReadGuid<PlayerGuid>();
            Type = Packet.GetBits<DataType>(3);
        }
    }
}
