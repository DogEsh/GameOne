using System.Collections.Generic;
using SimpleTeam.User;
using System;

namespace SimpleTeam.Message
{
    using MessageID = Byte;
    using ParameterID = Byte;
    /**
    <summary>
    Хранит список юзеров от кого отправлено\кому отправить сообщение.
    </summary>
    */
    [Serializable]
    public abstract class MessageBase : IMessage
    {
        public abstract MessageID Type { get; }
        public abstract ParameterID ParameterType { get; }
        [NonSerialized] public List<IUserNetwork> Users;
        protected MessageBase()
        {
            Users = new List<IUserNetwork>();
        }

        
    }
}


 

