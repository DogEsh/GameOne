using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleTeam.GameOne.Scene
{
    public class LinkLogics
    {
        private Simplus _focus;
        private Simplus _source;
        private Simplus _destination;
        public Simplus Source
        {
            get
            {
                return _source;
            }
        }
        public Simplus Destination
        {
            get
            {
                return _destination;
            }
        }
        public Simplus Focus
        {
            get
            {
                return _focus;
            }
        }
        public bool ToDraw
        {
            get
            {
                return (_source != null && _focus != _source);
            }
        }

        private MessageLink _message;

        public MessageLink GetMessage()
        {
            MessageLink m = _message;
            _message = null;
            return m;
        }

        private void Clear()
        {
            if (_source != null)
            {
                _source._wrapper.SetPressed(false);
                _source = null;
            }
            
            _destination = null;
            //SetAnimation(_focus, SimplusActionState.Focused);
        }

        public void SetMouseState(MouseState state)
        {
            if (MouseState.Down == state)
            {
                Clear();
                if (_focus != null)
                {
                    _source = _focus;
                    _source._wrapper.SetPressed(true);
                }
            }
            if (MouseState.Up == state)
            {
                if(_source != null && _focus != null && _focus != _source)
                {
                    _destination = _focus;
                    _message = new MessageLink(this);
                }
                Clear();
            }
        }

        public void SetFocus(Simplus focus)
        {
            if (focus != _focus)
            {
                if (focus != null)
                {
                    focus._wrapper.SetFocused(true);
                }
                if (_focus != null)
                {
                    _focus._wrapper.SetFocused(false);
                }
                _focus = focus;
            }
        }

      
    }
}
