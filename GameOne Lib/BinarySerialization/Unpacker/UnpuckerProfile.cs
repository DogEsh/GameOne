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
    public class UnpackerProfile : IUnpackerID
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperMessageID.Profile;
            }
        }
        public UnpackerState CreateMessage(ref IMessage message, BinaryReader reader, SizePacket size)
        {
            String nick = reader.ReadString();
            if (reader.BaseStream.Position >= size) return UnpackerState.SizeOut;
            UInt32 honor = reader.ReadUInt32();
            if (reader.BaseStream.Position != size) return UnpackerState.SizeOut;
            message = new MessageProfile(nick, honor);
            return UnpackerState.Ok;
        }

    }
}
