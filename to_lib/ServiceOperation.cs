using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{
    public class ServiceOperation
    {
        public string OperationName { get; set; }
        public string ServiceNotes { get; set; }

        private List<ServiceIntervalOperation> _serviceIntervalOperations = new List<ServiceIntervalOperation>();

        public List<ServiceIntervalOperation> ServiceOperations
        {
            get { return _serviceIntervalOperations; }
            set { _serviceIntervalOperations = value; }
        }

    }

}
