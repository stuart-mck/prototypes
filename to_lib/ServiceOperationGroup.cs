using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{
    public class ServiceOperationGroup
    {
        public int Order { get; set; }
        public string Name { get; set; }
        private List<ServiceOperation> _serviceOperations = new List<ServiceOperation>();
            
        public List<ServiceOperation> ServiceOperations
        {
            get { return _serviceOperations; }
            set { _serviceOperations = value; }
        }
        
    }
}
