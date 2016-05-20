using System;
using System.Collections;
using System.Linq;
using UnityEngine;
using SimpleTeam.GameOne.GameInfo;

namespace SimpleTeam.GameOne.Scene
{
    public class Simplus : MonoBehaviour
    {
        public SimplusWrapper _wrapper;

        private SimplusInfo _info;

        private ArrayList _links;

        public GameMap _map;

        

        //rm
        public GameObject LinkPrefab;

        //rm
        private SimplusLink _link;

        public SimplusInfo Info
        {
            get
            {
                return _info;
            }
        }

        //public SimplusInfo Info { get; set; }

        public Simplus()
        {
            //_wrapper = new SimplusWrapper();
        }

        public void InitInfo(SimplusInfo info)
        {
            gameObject.transform.position = info.Obj2D.GetPos();

            SetInfo(info);
        }

        public void SetInfo(SimplusInfo info)
        {
            foreach (SimplusLinkInfo inf in info.Links)
            {
                //if (inf.Equals(_links)
                //    continue;
                HandleLink(inf);
            }
            //go through link list (info)
            //if there are not the same
            //update links (create if needed)
            //update info

            SetWrapper(info);

            _info.SetInfo(info);
        }

        public void SetWrapper(SimplusInfo info)
        {
            
        }

        public void HandleLink(SimplusLinkInfo info)
        {
            if (null == _links[info.ID])
            {
                CreateLink(info);
            }
            if (null != _links[info.ID] && null != info)
            {
                DestroyLink(info);
            }

            UpdateLink(info);
        }

        public void UpdateLink(SimplusLinkInfo info)
        {
            (_links[info.ID] as SimplusLink).Info = info;
            
        }

        public void CreateLink(SimplusLinkInfo info)
        {
            Simplus dest = _map.GetSimplus(info.ID);
            _links.Add(CreateLink(dest));
        }

        public void DestroyLink(SimplusLinkInfo info)
        {
            (_links[info.ID] as SimplusLink).Destroy();
            _links.RemoveAt(info.ID);
        }

        //rm
        public SimplusLink CreateLink(Simplus destination)
        {
            //_link = new SimplusLink(this, destination);
            GameObject linkObj = Instantiate(LinkPrefab);
            _link = linkObj.GetComponent<SimplusLink>();
            _link.SetSimplusLinkData(this, destination);
            return _link;
        }

        //public bool IsFocused(Vector2 focusPos)
        //{
        //    return _wrapper.IsFocused(focusPos);
        //}
    }
}
