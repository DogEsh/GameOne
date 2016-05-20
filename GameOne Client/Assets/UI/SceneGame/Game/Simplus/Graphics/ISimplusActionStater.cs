using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleTeam.GameOne.Scene
{
    interface ISimplusActionStater
    {
        void SetFocused(bool isFocused);

        void SetPressed(bool isPressed);
    }
}
