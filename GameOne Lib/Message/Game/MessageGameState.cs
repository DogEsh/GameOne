using System;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Parameter;

namespace SimpleTeam.GameOne.Message
{
    using MessageID = Byte;
    using ParameterID = Byte;
    [Serializable]
    public sealed class MessageGameState : MessageBase
    {
        public override MessageID Type
        {
            get
            {
                return (MessageID)HelperMessageID.GameState;
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