using System;
using System.Collections.Generic;
using SimpleTeam.Message;

namespace SimpleTeam.GameOne.Scene
{
    public abstract class SceneMessagesBase : ISceneMessages
    {
        protected List<IMessageHandler> _handlers;
        protected SceneMessagesBase()
        {
            _handlers = new List<IMessageHandler>();
        }

        public void SetMessage(IMessage message)
        {
            foreach (IMessageHandler h in _handlers)
            {
                if (h.Type == message.Type)
                {
                    h.SetMessage(message);
                }
            }
        }
    }
}
