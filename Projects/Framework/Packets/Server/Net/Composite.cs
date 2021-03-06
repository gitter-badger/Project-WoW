﻿// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Framework.Constants.Net;
using Framework.Network.Packets;

namespace Framework.Packets.Server.Net
{
    public class Composite : ServerPacket
    {
        public Composite() : base(GlobalServerMessage.Composite) { }

        public override void Write()
        {
        }
    }
}
