using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace to_lib
{
    public class Article
    {

        public Article()
        {
            Id = Guid.NewGuid();
        }


        public Guid Id;

        public string Title { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Series { get; set; }

        [Display(Name="Year From")]
        public int YearFrom { get; set; }

        [Display(Name = "Year To")]
        public int YearTO { get; set; }

        private List<Engine> _engines = new List<Engine>();

        public List<Engine> Engines
        {
            get
            {
                return _engines;
            }
            set { _engines = value; }
        }


        private List<Section> _sections = new List<Section>();

        public List<Section> Sections
        {
            get { return _sections; }
            set { _sections = value; }
        }

        private List<Resource> _resources = new List<Resource>();

        public List<Resource> Resources
        {
            get { return _resources; }
            set { _resources = value; }
        }



        public ElementBase GetElementWithId(Guid id)
        {
            ElementBase result = null;
            foreach (var s in Sections)
            {
                if (s.Id == id)
                {
                    result = (ElementBase)s;
                }
                else
                {
                    foreach (var x in s.Elements)
                    {
                        if (x.Id == id)
                            result = x;
                        else
                            result = GetElementWithId(s.Id);
                    }
                }
            }
            return result;
        }
    }
}
