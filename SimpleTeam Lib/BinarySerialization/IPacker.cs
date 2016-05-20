using System;
using SimpleTeam.Message;
using SimpleTeam.Network;

namespace SimpleTeam.BinarySerialization
{
    public interface IPacker
    {
        void CreatePacket(ref Packet packet, IMessage message);
    }
}
