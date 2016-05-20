using System;
using SimpleTeam.Message;
using SimpleTeam.Network;

namespace SimpleTeam.BinarySerialization
{
    public enum UnpackerState : byte
    {
        Ok = 0,
        NotReady = 1,
        NotFoundType = 2,
        SizeOut = 3,
        NotParse = 4
    }
    public interface IUnpacker
    {
        UnpackerState CreateMessage(ref IMessage message, Packet packet);
    }
}
