using UnityEngine;
using SimpleTeam.Command;
using System;
using SimpleTeam.Command.Scenario;
using SimpleTeam.GameOne.Message;

namespace SimpleTeam.GameOne.Scene
{
    public class SceneClientGame : MonoBehaviour, ISceneGame
    {
        //ISceneScenario
        private SceneScenario _sceneScenario = new SceneScenario();

        public IScenario GetScenario()
        {
            return ((ISceneScenario)_sceneScenario).GetScenario();
        }


        //ISceneMenuMessages

        void ISceneGameMessages.SetMessage(MessageGamerCommand message)
        {
            throw new NotImplementedException();
        }

        void ISceneGameMessages.SetMessage(MessageGameState message)
        {
            throw new NotImplementedException();
        }

        void ISceneGameMessages.SetMessage(MessageGameMap message)
        {
            //call GameManager, giving him message which contains MapInfo and MessType
            throw new NotImplementedException();
        }
    }
}
