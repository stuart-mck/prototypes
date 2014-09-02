using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{
    public class ElementBase
    {

        public ElementBase()
        {
            Id = Guid.NewGuid();
        }

        public string Title { get; set; }

        private List<Attribute> _attributes = new List<Attribute>();

        public Guid Id;

        public List<Attribute> Attributes
        {
            get { return _attributes; }
            set { _attributes = value; }
        }

        private List<Tag> _tags = new List<Tag>();

        public List<Tag> Tags 
        {
            get { return _tags; }
            set { _tags = value; }
        }

        public  int Order { get; set; }

    }
}
