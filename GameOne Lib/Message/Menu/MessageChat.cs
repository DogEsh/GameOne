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
        private string _line;
        public MessageChat(String line)
        {
            _line = line;
        }
        public String Line
        {
            get
            {
                return _line;
            }
        }
    };
}