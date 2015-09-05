// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Framework.Misc;
using Framework.Network.Packets;
using Framework.Objects;
using World.Shared.Game.Entities.Object.Guid;
using WorldServer.Constants.Net;

namespace WorldServer.Packets.Server.Misc
{
    class UpdateAccountData : ServerPacket
    {
        public PlayerGuid PlayerGuid { get; set; }
        public uint[] AccountTimes { get; } = new uint[8];

        public UpdateAccountData() : base(ServerMessage.AccountDataTimes) { }

        public override void Write()
        {
            Packet.Write(PlayerGuid);
            Packet.Write(Helper.GetUnixTime());

            for (var i = 0; i < AccountTimes.Length; i++)
                Packet.Write(AccountTimes[i]);
        }
    }
}
