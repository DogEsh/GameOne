using System;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Parameter;

namespace SimpleTeam.GameOne.Message
{
    using ParameterID = Byte;
    using MessageID = Byte;

    [Serializable]
    public sealed class MessageGameMap : MessageBase
    {
        public override MessageID Type
        {
            get
            {
                return (MessageID)HelperMessageID.GameMap;
            }
        }
        public override ParameterID ParameterType
        {
            get
            {
                return (ParameterID)HelperParameterID.SceneGame;
            }
        }
    }
}
