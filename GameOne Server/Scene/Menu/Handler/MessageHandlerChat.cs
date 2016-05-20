using System;
using SimpleTeam.User;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Message;
using SimpleTeam.Command;
using SimpleTeam.Command.Scenario;
using SimpleTeam.GameOne.Command;

namespace SimpleTeam.GameOne.Scene
{
    using MessageID = Byte;
    class MessageHandlerChat : IMessageHandler
    {
        public byte Type
        {
            get
            {
                return (MessageID)HelperMessageID.Chat;
            }
        }
        
        IScenario _scenario;
        public MessageHandlerChat(IScenario scenario)
        {
            _scenario = scenario;
        }

        public void SetMessage(IMessage m)
        {
            MessageChat message = m as MessageChat;
            IUserProfile user = message.Users[0] as IUserProfile;
            //if (user.Nick == String.Empty) return;

            message.Line = DateTime.Now.ToString("T") + "  <<" + user.Nick + ">>:  " + message.Line;
            message.Users.Clear();
            ICommand c = new CommandSendMessageNetwork(message);
            _scenario.Set(c);
        }
    }
}
