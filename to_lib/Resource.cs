using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{
    public class Resource:ElementBase
    {
        public Guid ResourceId { get; set; }
        public Uri Location { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
        public string DisplayText { get; set; }
    }
}

