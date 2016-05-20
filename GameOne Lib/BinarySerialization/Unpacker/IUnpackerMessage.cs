using System;
using SimpleTeam.Message;
using SimpleTeam.Network;
using System.IO;
using SimpleTeam.BinarySerialization;

namespace SimpleTeam.GameOne.BinarySerialization
{
    using SizePacket = UInt16;

    public interface IUnpackerMessage : IMessageID
    {
        UnpackerState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size);
    }
}
