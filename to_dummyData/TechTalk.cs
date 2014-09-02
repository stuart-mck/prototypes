using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_lib;

namespace to_dummyData
{
    public class TechTalk:Article
    {
        public TechTalk()
        {
            Make = "<Any>";
            Model = "<Any>";
            Series = "<Any>";
            Title = "Ford Recall - Steering Rack Stud Alert";

            var s = new Section()
            {
                Title = "content",
                Order = 1
            };

            Sections.Add(s);

            s.Elements.Add(new TextContent() { Title = "Ford Recall", Order = 1, ElementContent = DataContext.GetContent("tt1") });

            var d = new Section()
            {
                Order = 2,
                Title = "Diagrams"
            };

            Sections.Add(d);

            d.Elements.Add(new Resource() { Title = "Diag 1", Order = 1 });
        }
    }
}
