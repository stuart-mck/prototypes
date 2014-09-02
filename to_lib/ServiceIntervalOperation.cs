using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{
    public class ServiceIntervalOperation
    {
        public ServiceInterval ServiceInterval { get; set; }
        public operationType OperationType { get; set; }
    }

    public enum operationType
    {
        Adjust,
        Clean,
        Drain,
        Inspect,
        Lubricate,
        Replace,
        Tension,
        NA,
        None
    }
}
