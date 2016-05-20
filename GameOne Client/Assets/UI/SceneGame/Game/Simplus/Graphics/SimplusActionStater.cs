using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleTeam.GameOne.Scene
{
    public enum SimplusActionState
    {
        Passive,
        Focused,
        Pressed
    }
    public class SimplusActionStater : ISimplusActionStater
    {
        private bool _isFocused;
        private bool _isPressed;


        public SimplusActionState GetState()
        {
            if (_isPressed)
                return SimplusActionState.Pressed;
            if (_isFocused)
                return SimplusActionState.Focused;

            return SimplusActionState.Passive;
        }

        public void SetFocused(bool isFocused)
        {
            _isFocused = isFocused;
        }

        public void SetPressed(bool isPressed)
        {
            _isPressed = isPressed;
        }
    }

    
}
