using SimpleTeam.Message;
using SimpleTeam.Command;
using System;

namespace SimpleTeam.GameOne.Command
{
    
    using TypeID = Byte;
    /**
    <summary>
    Команда для отправки сообщения в интернет.
    </summary>
    */
    public class CommandSendMessageNetwork : ICommand
    {
        public TypeID Type
        {
            get
            {
                return (TypeID)HelperParameterID.MessageManager;
            }
        }

        IMessage _message;
        public CommandSendMessageNetwork(IMessage message)
        {
            _message = message;
        }

        void ICommand.Do(IAllParameters parameters)
        {
            IParameterMessagesManager p = parameters.GetParameter(Type) as IParameterMessagesManager;
            if (p != null)
            {
                p.GetMessagesManager().SetMessage(_message);
            }
            
        }
    }
}
