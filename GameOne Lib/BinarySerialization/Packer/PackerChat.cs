using System;
using System.IO;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Message;

namespace SimpleTeam.GameOne.BinarySerialization
{
    using TypeID = Byte;
    public class PackerChat : IPackerID
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperMessageID.Chat;
            }
        }
        public void CreatePacket(BinaryWriter writer, IMessage message)
        {
            MessageChat m = (MessageChat)message;
            writer.Write(m.Line);
        }
        public PackerChat()
        { }
    }
}
