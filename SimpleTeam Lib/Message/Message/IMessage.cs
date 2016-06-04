using System;

namespace SimpleTeam.Message
{
    public interface IMessage : IMessageID
    {
        IMessageData Data { get; }
        IMessageAddress Address { get; }

    }
}
