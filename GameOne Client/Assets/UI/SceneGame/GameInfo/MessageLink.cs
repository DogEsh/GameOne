using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace SimpleTeam.GameOne.Scene
{
    public class MessageLink
    { 
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
        public MessageLink(LinkLogics link)
        {
            _source = link.Source;
            _destination = link.Destination;
        }
    }
}
