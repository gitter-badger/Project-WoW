using Framework.Constants.Account;
using WorldNode.Network;
using WorldNode.Attributes;
using WorldNode.Constants.Net;
using WorldNode.Packets.Client;
using WorldNoder.Packets.Server;

namespace WorldNode.Packets.Handlers
{
    class MiscHandler
    {
        [Message(ClientMessage.ViolenceLevel, SessionState.All)]
        public static void HandlerViolenceLevel(ViolenceLevel violenceLevel, NodeSession session)
        {
            // not implemented
        }
    }
}
