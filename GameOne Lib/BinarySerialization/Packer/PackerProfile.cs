using System;
using System.IO;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Message;

namespace SimpleTeam.GameOne.BinarySerialization
{
    using TypeID = Byte;
    class PackerProfile : IPackerID
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperMessageID.Profile;
            }
        }
        public void CreatePacket(BinaryWriter writer, IMessage message)
        {
            MessageProfile m = (MessageProfile)message;
            writer.Write(m.Nick);
            writer.Write(m.Honor);
        }
    }
}
