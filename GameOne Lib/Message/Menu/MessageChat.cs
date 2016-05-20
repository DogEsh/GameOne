using System;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Parameter;
namespace SimpleTeam.GameOne.Message
{
    using MessageID = Byte;
    using ParameterID = Byte;

    [Serializable]
    public sealed class MessageChat : MessageBase
    {
        public override MessageID Type
        {
            get
            {
                return (MessageID)HelperMessageID.Chat;
            }
        }
        public override ParameterID ParameterType
        {
            get
            {
                return (ParameterID)HelperParameterID.SceneMenu;
            }
        }
        public string Line;
        public MessageChat(String line)
        {
            Line = line;
        }
    };
}