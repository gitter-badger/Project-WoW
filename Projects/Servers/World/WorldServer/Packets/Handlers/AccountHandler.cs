// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Framework.Attributes;
using Framework.Constants.Account;
using Framework.Constants.Net;
using Framework.Database;
using Framework.Database.Character.Entities;
using Framework.Logging;
using World.Shared.Game.Entities;
using WorldServer.Attributes;
using WorldServer.Constants.Net;
using WorldServer.Managers;
using WorldServer.Network;
using WorldServer.Packets.Client.Character;
using WorldServer.Packets.Client.Misc;
using WorldServer.Packets.Server.Misc;
using WorldServer.Packets.Server.Spell;

namespace WorldServer.Packets.Handlers
{
    class AccountHandler
    {
        [Message(ClientMessage.RequestAccountData, SessionState.Authenticated)]
        public static void HandleRequestAccountData(RequestAccountData data, WorldSession session)
        {
            
        }
    }
}
