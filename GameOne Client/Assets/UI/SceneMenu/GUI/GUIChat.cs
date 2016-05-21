using UnityEngine;
using UnityEngine.UI;
using SimpleTeam.Message;
using SimpleTeam.Command;
using SimpleTeam.GameOne.Message;
using SimpleTeam.GameOne.Command;
using System;

namespace SimpleTeam.GameOne.Scene
{
    using MessageID = Byte;
    public class GUIChat : MonoBehaviour, IMessageHandler
    {
        public SceneClientMenu Menu;
        public Button ButtonSend;
        public InputField InputChat;
        public Text OutputChat;
        public IMessageContainer _container = new MessageContainer();

        public MessageID Type
        {
            get
            {
                return (MessageID)HelperMessageID.Chat;
            }
        }
        public void SetMessage(IMessage message)
        {
            _container.Set(message);
        }

        // Use this for initialization
        void Start()
        {

        }
        public void SetStateSignIn(bool isSignIn)
        {
            ButtonSend.interactable = isSignIn;
            InputChat.interactable = isSignIn;
        }
        // Update is called once per frame
        void Update()
        {
            if (!_container.IsEmpty)
            {
                MessageChat m = _container.Get() as MessageChat;
                OutputChat.text += "\n" + m.Line;
            }
        }
        public void SendToChat()
        {
            //OutputChat.text += "\n" + InputChat.text;
            IMessage msg = new MessageChat(InputChat.text);
            InputChat.text = string.Empty;
            ICommand cmd = new CommandSendMessageNetwork(msg);
            Menu.GetScenario().Set(cmd);
        }

        
    }
}

