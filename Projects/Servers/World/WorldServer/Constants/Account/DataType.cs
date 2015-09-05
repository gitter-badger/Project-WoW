using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldServer.Packets.Structures.Account
{
    public enum DataType : byte
    {
        GlobalConfigCache = 0,
        PerCharacterConfigCache = 1,
        GlobalBindingsCache = 2,
        PerCharacterBindingsCache = 3,
        GlobalMacrosCache = 4,
        PerCharacterMacrosCache = 5,
        PerCharacterLayoutCache = 6,
        PerCharacterChatCache = 7,
        NumAccountDataTypes = 8
    }
}
