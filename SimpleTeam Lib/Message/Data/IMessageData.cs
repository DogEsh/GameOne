using System;

namespace SimpleTeam.Message
{
    using ParameterID = Byte;
    public interface IMessageData : IMessageID
    {
        ParameterID ParameterType { get; }
    }
}
