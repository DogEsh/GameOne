using System;
using SimpleTeam.Message;
using System.IO;
using SimpleTeam.GameOne.Message;

namespace SimpleTeam.GameOne.BinarySerialization
{
    using TypeID = Byte;
    public class PackerAccount : IPackerID
    {
        TypeID ITypeID.Type
        {
            get
            {
                return (TypeID)HelperMessageID.Account;
            }
        }
        public void CreatePacket(BinaryWriter writer, IMessage message)
        {
            MessageAccount m = (MessageAccount)message;
            //writer.Write(m.StateValue);
            writer.Write(m.Success);
            writer.Write((Byte)m.State);
            writer.Write(m.Email);
            writer.Write(m.Password);
            writer.Write(m.Nick);
        }
        
    }
}
