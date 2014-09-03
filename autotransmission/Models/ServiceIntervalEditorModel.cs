using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using to_lib;

namespace autotransmission.Models
{
    public class ServiceIntervalEditorModel
    {

        public ServiceIntervalEditorModel()
        {

        }

        private List<ServiceInterval> _list = new List<ServiceInterval>();

        public ServiceIntervalEditorModel(List<ServiceInterval> list)
        {
            
            _list = list;
        }
        public List<ServiceInterval> Intervals
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
            }
        }
    }
}