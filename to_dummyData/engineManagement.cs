using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_lib;

namespace to_dummyData
{
    public class engineManagement:Article
    {
        public engineManagement()
        {
            Make = "Audi";
            Model = "Q7";
            Series = "3.6L BHK";
            YearFrom = 2006;
            YearTO = 2011;
            Title = "Engine Management";

            var tuProcedures = new Section()
            {
                Order = 1,
                Title = "Tune Up Procedures"
            };

            Sections.Add(tuProcedures);

            tuProcedures.Elements.Add(new TextContent() { Order = 1, Title = "Idle Speed", ElementContent = "<p>Can not be adjusted</p>" });
            tuProcedures.Elements.Add(new TableContent() { Order = 2, Title = "", ElementContent = "<table><tr><th>Condition</th><th>Specification</th></tr><tr><td >Idle</td><td 600 - 800 rpm&#160;</td></tr></tbody></table>" });
            tuProcedures.Elements.Add(new TableContent() { Order = 3, Title = "Spark Plugs", ElementContent = "<table><tr><th>Spark Plug</th><th>Gap</th></tr><tr><td>&#160;NGK ILZKR7A</td><td>&#160;0.9mm</td></tr></table>" });
            tuProcedures.Elements.Add(new TextContent() { Order = 4, Title = "Ignition Timing", ElementContent = "Can not be adjusted" });
            tuProcedures.Elements.Add(new TextContent() { Order = 5, Title = "Fuel Pressure", ElementContent = "<ol><li>Battery Voltage must be 12.5V</li><li>Fuel tank must be at least a quarter full</li><li>Fuel pump control unit is at the front of the fuel tank above the exhaust and prop shaft.</li><li>Unplug the connector from the fuel pump control unit.</li><li>Connect remote switch.</li><li>Disconnect fuel line to fuel rail.</li><li>Fit fuel pressure gauge.</li></ol>" });
            tuProcedures.Elements.Add(new TableContent() { Order = 6, Title = "", ElementContent = "<table><tr><th>Condition</th><th>Fuel Pressure</th></tr><tr><td>Idle</td><td >600 kPa (87 psi)</td></tr></tbody></table>" });
            tuProcedures.Elements.Add(new TextContent() { Order = 7, Title = "Accelerator Pedal Position Relearn", ElementContent = "N/S" });
            tuProcedures.Elements.Add(new TextContent() { Order = 8, Title = "Throttle Valve Closed Position Relearn", ElementContent = "add description" });


            var faultCodeAccess = new Section()
            {
                Title = "Fault Code Access",
                Order = 2
            };

            Sections.Add(faultCodeAccess);
            faultCodeAccess.Elements.Add(new TextContent() { Title = "", Order = 1, ElementContent = "<p >Data link connector is under the dash on the driver side.</p><h4>Reading Codes</h4><p>A suitable diagnostic scan tool is required to extract fault codes.</p><h4>Erasing Codes</h4><p>A suitable diagnostic scan tool is required to erase fault codes.</p>" });

            var faultCodeTable = new Section()
            {
                Title = "Fault Code Table",
                Order = 3
            };

            Sections.Add(faultCodeTable);
            faultCodeTable.Elements.Add(new TableContent() { Title = "Fault Code Access", Order = 1, ElementContent = DataContext.GetContent("emFaultCodes") });

            var ci = new Section()
            {
                Title = "Component Inspection",
                Order = 4
            };

            Sections.Add(ci);
            ci.Elements.Add(new TextContent() { Title = "Component Inspection", Order = 1, ElementContent = "No information available" });

            var pd= new Section()
            {
                Title = "PINDATA",
                Order = 5
            };
            Sections.Add(pd);
            pd.Elements.Add(new TextContent() { Order = 1, Title = "60 Pin Connector", ElementContent = DataContext.GetContent("efPinData60") });
            pd.Elements.Add(new TextContent() { Order = 2, Title = "94 Pin Connector", ElementContent = DataContext.GetContent("efPinData94") });

            var d = new Section()
            {
                Title = "Diagrams",
                Order = 7
            };

            Sections.Add(d);

            d.Elements.Add(new Resource() { Order = 1, Title = "Component Locations" });
            d.Elements.Add(new Resource() { Order = 2, Title = "Under Bonnet Locations" });
            d.Elements.Add(new Resource() { Order = 3, Title = "Connectors" });
            d.Elements.Add(new Resource() { Order = 4, Title = "Wiring Diagram" });
            d.Elements.Add(new Resource() { Order = 5, Title = "Diagram 5" });
            d.Elements.Add(new Resource() { Order = 6, Title = "Diagram 6" });

        }
    }
}
