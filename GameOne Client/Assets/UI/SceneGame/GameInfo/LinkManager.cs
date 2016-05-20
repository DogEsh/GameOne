using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using SimpleTeam.GameOne.GameInfo;

namespace SimpleTeam.GameOne.Scene
{
    public class LinkManager : MonoBehaviour
    {
        private LinkLogics _logics;
        public LinkActionDrawer _drawer;

        public void Start()
        {
            _logics = new LinkLogics();
            //_drawer = new LinkActionDrawer();
        }

        public void Update()
        {
            MessageLink m = _logics.GetMessage();
            if (m != null)
            {
                Debug.Log("Create link");
                m.Source.CreateLink(m.Destination);
            }
        }

        public void UpdateDraw(Simplus simplus, MouseManager mouse)
        {
            _logics.SetFocus(simplus);
            _logics.SetMouseState(mouse.State.Get());

            if (_logics.ToDraw)
            {
                DragInfo drag = new DragInfo();
                drag.SetSource(_logics.Source._wrapper);
                if (_logics.Focus != null)
                {
                    drag.SetDestination(_logics.Focus._wrapper);
                }
                else
                {
                    
                    drag.SetDestination(new Point(Camera.main.ScreenToWorldPoint(Input.mousePosition)));
                }
                _drawer.UpdateInfo(drag, LinkActionDrawer.LinkState.Link);
                _drawer.Visible(true);
            }
            else
                _drawer.Visible(false);
        }
    }
}
