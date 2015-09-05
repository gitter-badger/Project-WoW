using System;
using System.Security.Cryptography;
using System.Text;
using Framework.Attributes;
using Framework.Constants.Account;
using Framework.Constants.Net;
using Framework.Database;
using Framework.Database.Auth.Entities;
using Framework.Misc;
using Framework.Packets.Client.Authentication;
using Framework.Packets.Server.Net;
using WorldNode.Managers;
using WorldNode.Network;
using WorldNode.Attributes;
using WorldNode.Constants.Net;
using WorldNode.Packets.Client;
using WorldNoder.Packets.Server;

namespace WorldNode.Packets.Handlers
{
    class PlayerHandler
    {

        [Message(ClientMessage.LogoutRequest, SessionState.All)]
        public static async void HandlerLogoutRequest(LogoutRequest logoutRequest, NodeSession session)
        {
            await session.Send(new LogoutResponse { Reason = 0, Instant = true });
        }
    }
}
