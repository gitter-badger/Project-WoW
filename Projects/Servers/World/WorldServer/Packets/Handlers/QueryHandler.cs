using Framework.Attributes;
using Framework.Constants.Account;
using Framework.Constants.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldServer.Network;

namespace WorldServer.Packets.Handlers
{
    class QueryHandler
    {
        [GlobalMessage(GlobalClientMessage.DBQueryBulk, SessionState.Authenticated)]
        public static void HandleDBQueryBulk(DBQueryBulk req, WorldSession session)
        {
            //2DO

        }
    }
}
