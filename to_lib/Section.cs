using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{
    public class Section : ElementBase
    {

        private List<ElementBase> _elements = new List<ElementBase>();

        public List<ElementBase> Elements
        {
            get { return _elements; }
            set { _elements = value; }
        }
    }
}
