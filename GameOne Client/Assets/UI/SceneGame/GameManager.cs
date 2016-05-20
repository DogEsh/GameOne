using System;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;
using SimpleTeam.GameOne.Message;
using SimpleTeam.GameOne.GameInfo;


namespace SimpleTeam.GameOne.Scene
{
    using GameID = UInt16;
    class GameManager : MonoBehaviour
    {
        private MouseManager _mouse = new MouseManager();
        public LinkManager _linkManager;
        public GameMap _map;

        public void UpdateLink()
        {
            Simplus simplus = _map.GetFocusedSimplus(_mouse.Pos);
 
            _linkManager.UpdateDraw(simplus, _mouse);
        }

        //public GameObject GetFocusObject()
        //{
        //    _map
        //    //return _mouse.MouseOver();
        //    //Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //    //RaycastHit hit;
        //    //Vector3 mouseVecFar = new Vector3(mousePos.x, mousePos.y, -100);
        //    //Vector3 mouseVecCls = new Vector3(mousePos.x, mousePos.y, 100);
        //    ////Ray ray = new Ray(mouseVec, Vector3.forward);
        //    //Physics.Raycast(mouseVecFar, mouseVecCls, out hit);
        //    //Debug.DrawLine(mouseVecFar, mouseVecCls);
        //    ////RaycastHit hit = Physics.Raycast(mousePos, Vector2.right, LayerMask.NameToLayer("Simplus"));
        //    //if (hit.collider != null)
        //    //{
        //    //    return hit.collider.transform.gameObject;
        //    //}
        //    //Debug.Log("hit == null");
        //    //return null;
        //}

        public void Update()
        {
            _mouse.Update();
            UpdateLink();
        }

        public void SetMap(MessageGameMap message)
        {
            
            //depending on what type of message either call
            //_map.UpdateMap(message.Info)
            //or
            //_map.InitMap(message.Info)

            //fake info
            //GJ
            //InitMapInfo initInfo = new InitMapInfo();
            ArrayList simplusInfo = new ArrayList();

            SimplusInfo info;
            {
                GameID id = 124;
                Circle circle = new Circle(Vector2.zero, 50);
                ISimplusHP hp = new SimplusHP(30);
                IParty party = new Party(0);
                ILinkInfoContainer links = new LinkInfoList();
                info = new SimplusInfo(id, circle, hp, party, links);
            }
            //GJ
            //_map.SetInitMapInfo(initInfo);
        }
    }
}
