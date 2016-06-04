

using System;
using SimpleTeam.Command;
using SimpleTeam.GameOne.Message;
using SimpleTeam.Command.Scenario;
using SimpleTeam.Message;

namespace SimpleTeam.GameOne.Scene
{
    class SceneServerGame : ISceneGame
    {
        //ISceneScenario
        private SceneScenario _sceneScenario = new SceneScenario();

        public IScenario GetScenario()
        {
            return ((ISceneScenario)_sceneScenario).GetScenario();
        }

        //ISceneMessages
        private ISceneMessages _sceneMessage = new SceneServerGameMessages();
        public void SetMessage(IMessage message)
        {
            _sceneMessage.SetMessage(message);
        }
    }
}
