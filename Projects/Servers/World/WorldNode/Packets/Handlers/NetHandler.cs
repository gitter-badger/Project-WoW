using Framework.Attributes;
using Framework.Constants.Account;
using Framework.Constants.Net;
using WorldNode.Network;
using WorldNode.Packets.Client;

namespace WorldNode.Packets.Handlers
{
    class NetHandler
    {
        [GlobalMessage(GlobalClientMessage.QueuedMessagesEnd, SessionState.All)]
        public static void HandlerQueuedMessagesEnd(QueuedMessagesEnd queuedMessagedEnd, NodeSession session)
        {
            //not implemented 
        }
    }
}
