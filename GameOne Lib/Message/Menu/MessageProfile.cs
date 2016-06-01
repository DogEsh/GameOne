using System;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Parameter;

namespace SimpleTeam.GameOne.Message
{
    using MessageID = Byte;
    using ParameterID = Byte;
    [Serializable]
    public sealed class MessageProfile : MessageBase
    {
        public override MessageID Type
        {
            get
            {
                return (MessageID)HelperMessageID.Profile;
            }
        }
        public override ParameterID ParameterType
        {
            get
            {
                return (ParameterID)HelperParameterID.SceneMenu;
            }
        }
        private String _nick;
        private UInt32 _honor;

        public MessageProfile(String nick, UInt32 honor)
        {
            _nick = nick;
            _honor = honor;
        }


        public string Nick
        {
            get
            {
                return _nick;
            }
        }
        public UInt32 Honor
        {
            get
            {
                return _honor;
            }
        }
    }
    

}
