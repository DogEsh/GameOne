using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleTeam.Message
{
    using ParameterID = Byte;
    public interface IMessage : IMessageID
    {
        ParameterID ParameterType { get; }
    }
}
