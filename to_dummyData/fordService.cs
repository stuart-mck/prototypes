using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_lib;

namespace to_dummyData
{
    public class fordService:Article
    {
        public fordService()
        {
            Make = "Ford";
            Model = "Fairlaine";
            Series = "BF";
            YearFrom = 2005;
            YearTO = 2007;
            Title = "Service Schedule";

            //var notes = new Section()
            //{
            //    Order = 1,
            //    Title = "Service Notes"
            //};

            //Sections.Add(notes);

            //notes.Elements.Add(new TextContent() { Title = "Service Notes", Order = 1, ElementContent = "*Severe Service applies to vehicles that are used in adverse conditions.<br />These items are serviced more frequently (see Service Schedule)." });


            var ss = new Section() { Order = 2, Title = "Service Schedule" };
            Sections.Add(ss);

            ss.Elements.Add(new fordServiceSchedule() { Order = 1, Title = "Service Schedule" });
            //ss.Elements.Add(new TextContent() {Order = 2, Title = "Footer", ElementContent = "<p><b>Legend: A = Adjust, C = Clean, D = Drain, I = Inspect, L = Lubricate, R = Replace, T = Tension</b></p><p><b>N/A = Not Applicable, N/S = Not Stated</b></p<p><b>*Severe Service:</b><b>(1)</b> = Driving less than 10,000 km in 6 months or continual short trips less than 10 km. <b>(2)</b> = Driving in dust, dirt, sand. <b>(3)</b> = Driving in muddy, wet, or humid areas. <b>(4)</b> = Driving in temperatures below 5°C with most trips less than 10 km. <b>(5)</b> = Stop/start driving, excessive idling or low speed operation eg. taxi, delivery vehicle. <b>(6)</b> = Caravan/trailer towing or high roof racks. <b>(7)</b> = Extended heavy load high speed operation in temperatures above 35°C. <b>(8)</b> = Driving in excess of 250,000 km per 5 years. <b>(9)</b> = Driving at frequent or prolonged high speeds.</p>" });


        }
    }
}
