using SimpleTeam.GameOne.Message;
using SimpleTeam.Message;
using SimpleTeam.GameOne.Data;
using SimpleTeam.User;
using System;
using SimpleTeam.Command;
using SimpleTeam.GameOne.Command;
using SimpleTeam.Command.Scenario;

namespace SimpleTeam.GameOne.Scene
{
    class SceneServerMenuMessages : SceneMessagesBase
    {
        public SceneServerMenuMessages(IScenario scenario)
        {
            _handlers.Add(new MessageHandlerAccount(scenario));
            _handlers.Add(new MessageHandlerChat(scenario));
        }

    }
}
