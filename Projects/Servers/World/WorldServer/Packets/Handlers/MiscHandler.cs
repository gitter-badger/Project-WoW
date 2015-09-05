// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Framework.Attributes;
using Framework.Constants.Account;
using Framework.Constants.Net;
using Framework.Misc;
using Framework.Packets.Client.Net;
using Framework.Packets.Server.Net;
using WorldServer.Managers;
using WorldServer.Network;
using WorldServer.Attributes;
using WorldServer.Constants.Net;
using WorldServer.Packets.Client.Misc;

namespace WorldServer.Packets.Handlers
{
    class MiscHandler
    {
        [Message(ClientMessage.UITimeRequest, SessionState.Authenticated)]
        public static async void HandleUITimeRequest(UITimeRequest req, WorldSession session)
        {
            await session.Send(new UITime());
        }
    }
}
