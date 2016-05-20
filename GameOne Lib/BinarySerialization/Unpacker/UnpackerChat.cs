using System;
using System.IO;
using SimpleTeam.Message;
using SimpleTeam.Network;
using SimpleTeam.GameOne.Message;
using SimpleTeam.BinarySerialization;

namespace SimpleTeam.GameOne.BinarySerialization
{
    using SizePacket = UInt16;
    using MessageID = Byte;
    public class UnpackerChat : IUnpackerMessage
    {
        MessageID IMessageID.Type
        {
            get
            {
                return (MessageID)HelperMessageID.Chat;
            }
        }
        public UnpackerState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size)
        {
            String line = reader.ReadString();
            if (reader.BaseStream.Position != size) return UnpackerState.SizeOut;
            message = new MessageChat(line);
            return UnpackerState.Ok;
        }

        
    }
}