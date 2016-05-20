using System;
using SimpleTeam.User;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Message;
using SimpleTeam.Command;
using SimpleTeam.Command.Scenario;
using SimpleTeam.GameOne.Command;
using SimpleTeam.GameOne.Data;

namespace SimpleTeam.GameOne.Scene
{
    using MessageID = Byte;
    class MessageHandlerAccount : IMessageHandler
    {
        public byte Type
        {
            get
            {
                return (MessageID)HelperMessageID.Account;
            }
        }

        DataSet _data;
        IScenario _scenario;
        public MessageHandlerAccount(IScenario scenario)
        {
            _scenario = scenario;
            _data = new DataSet();
        }

        public void SetMessage(IMessage m)
        {
            MessageAccount message = m as MessageAccount;
            bool success = false;
            UserClient user = message.Users[0] as UserClient;
            if (message.State == MessageAccount.StateType.SignUp)
            {
                success = _data.SignUp(message.Email, message.Password, message.Nick);

            }
            else if (message.State == MessageAccount.StateType.SignIn)
            {
                IUserProfile p = _data.SignIn(message.Email, message.Password);
                if (p != null)
                {
                    success = true;
                    user.UpdateProfile(p);

                    MessageProfile mm = new MessageProfile(user.Nick, 0);
                    mm.Users.Add(message.Users[0]);
                    ICommand cc = new CommandSendMessageNetwork(mm);
                    _scenario.Set(cc);
                }
            }
            else if (message.State == MessageAccount.StateType.SignOut)
            {
                success = true;
                user.Nick = string.Empty;
            }
            else if (message.State == MessageAccount.StateType.ChangePassword)
            {
                if (user.Nick != null)
                {
                    _data.UpdatePassword(user.Nick, message.Password);
                    success = true;
                }
            }
            MessageAccount ms = new MessageAccount(message.State, success);
            ms.Users.Add(message.Users[0]);
            ICommand c = new CommandSendMessageNetwork(ms);
            _scenario.Set(c);
        }
    }
}

