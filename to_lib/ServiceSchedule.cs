using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{
    public class ServiceSchedule:ElementBase
    {

        public ServiceSchedule()
        {
           

            
        }


        private List<ServiceInterval> _serviceIntervals = new List<ServiceInterval>();

        public List<ServiceInterval> ServiceIntervals
        {
            get { return _serviceIntervals; }
            set { _serviceIntervals = value; }
        }

        private List<ServiceOperationGroup> _serviceOperationGroups = new List<ServiceOperationGroup>();

        public List<ServiceOperationGroup> ServiceOperationGroups
        {
            get { return _serviceOperationGroups = new List<ServiceOperationGroup>(); }
            set { _serviceOperationGroups = value; }
        }
        
        
    }
}
