using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{

    public enum eBehaviour
    {
        Hover,
        Click
    }

    public enum eAction
    {
        PopUp,
        NewWindow,
        Follow
    }

    public class Behaviour
    {
        public eBehaviour BehaviourType{ get; set; }
        public eAction Action { get; set; }
        public Uri ActionTarget { get; set; }
    }
}
