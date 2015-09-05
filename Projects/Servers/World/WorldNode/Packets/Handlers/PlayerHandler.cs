using Framework.Constants.Account;
using WorldNode.Network;
using WorldNode.Attributes;
using WorldNode.Constants.Net;
using WorldNode.Packets.Client;
using WorldNoder.Packets.Server;
using Framework.Logging;

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
