using System;
using System.IO;
using SimpleTeam.Message;
using SimpleTeam.Network;
using SimpleTeam.GameOne.Message;
using SimpleTeam.BinarySerialization;

namespace SimpleTeam.GameOne.BinarySerialization
{
    using SizePacket = UInt16;
    using TypeID = Byte;
    public class UnpackerChat : IUnpackerID
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperMessageID.Chat;
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