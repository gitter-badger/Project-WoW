// Copyright (c) Multi-Emu.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Framework.Network.Packets
{
    public abstract class TwoSidePacket
    {
        public Packet Packet { get; set; }
        public bool IsReadComplete { get { return Packet.IsReadComplete; } }

        public abstract void Read();        
        public abstract void Write();

        protected TwoSidePacket()
        {
            Packet = new Packet();
        }

        protected TwoSidePacket(object netMessage, bool authHeader = false)
        {
            Packet = new Packet(netMessage, authHeader);
        }
    }
}
