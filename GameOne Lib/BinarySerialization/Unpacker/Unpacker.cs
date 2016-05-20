using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleTeam.BinarySerialization;
using System.IO;
using SimpleTeam.Network;
using SimpleTeam.Message;


namespace SimpleTeam.GameOne.BinarySerialization
{
    using TypeID = Byte;
    public class Unpacker: IUnpacker
    {
        private RegisterUnpacker _register;
        public Unpacker()
        {
            _register = new RegisterUnpacker();
        }
        public UnpackerState CreateMessage(ref IMessage message, Packet packet)
        {
            message = null;
            if (!packet.IsReady) return UnpackerState.NotReady;
            if (packet.Size < sizeof(TypeID)) return UnpackerState.SizeOut;
            using (MemoryStream stream = new MemoryStream(packet.GetData()))
            {
                if (!stream.CanRead) throw new SystemException("haha");
                using (BinaryReader reader = new BinaryReader(stream))
                {
                    TypeID type = reader.ReadByte();
                    IUnpackerID unpacker = _register.Find(type);
                    if (unpacker == null) return UnpackerState.NotFoundType;
                    return unpacker.CreateMessage(ref message, reader, packet.Size);
                }
            }
        }
    }
}
