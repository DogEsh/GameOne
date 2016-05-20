using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleTeam.GameOne.Scene
{
    public class SimplusAnimationManager
    {
        public SimplusAnimationManager(Animator animator)
        {
            _animator = animator;
        }

        private Animator _animator;

        public void SetActionState(SimplusActionState state)
        {
            if (SimplusActionState.Focused == state)
                StartAnimation("Focused");
            if (SimplusActionState.Passive == state)
                StartAnimation("Passived");
            if (SimplusActionState.Pressed== state)
                StartAnimation("Pressed");
        }

        private void StartAnimation(string name)
        {
            _animator.SetTrigger(name);
        }
    }
}
