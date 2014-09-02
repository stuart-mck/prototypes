using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_lib;

namespace to_dummyData
{
    public class autoTransmissionArticle:Article
    {
        public autoTransmissionArticle()
        {
            
            Make = "Holden";
            Model = "Commodore";
            Series = "VC";
            YearFrom = 1980;
            YearTO = 1982;
            Title = "Auto Transmission";
            

            Engines.Add(new Engine() { Name = "2.1 xxaaa", YearFrom = 1980, YearTo = 1981 });
            Engines.Add(new Engine() { Name = "3.1 bd", YearFrom = 1981, YearTo = 1982 });

            Resources.Add(new Resource() { Name = "HeaderImage", Title="Main", ResourceId = Guid.NewGuid(), Location = new Uri("/images/holdenvc.jpg", UriKind.Relative)});

            ///
            /// Lubrication Section
            ///

            var lubricationSection = new Section() { Order = 1, Title = "Lubrication" };
            lubricationSection.Attributes.Add(new to_lib.Attribute() { Name = "autoShow", Value = "true" });
            lubricationSection.Attributes.Add(new to_lib.Attribute() { Name = "class", Value = "articeSection" });
            lubricationSection.Tags.Add(new Tag() { Value = "Lubrication" });

            Sections.Add(lubricationSection);

            lubricationSection.Elements.Add(new TableContent()
            {
                Title = "SPECIFICATIONS",
                ElementContent = DataContext.GetContent("lubeTableData"),
                Order = 1
            });

            lubricationSection.Elements.Add(new TableContent()
            {
                Title = "Torque Specifications",
                Order = 2,
                ElementContent = DataContext.GetContent("lubeTorqueSpecs")
            });


            lubricationSection.Elements.Add(new TextContent()
            {
                Title = "Service Notes",
                Order = 3,
                ElementContent = DataContext.GetContent("serviceNotes")
            });

            lubricationSection.Elements.Add(new TextContent()
            {
                Title = "Band Adustment Procedure",
                Order = 4,
                ElementContent = DataContext.GetContent("bandAdjustment")
            });

            lubricationSection.Elements.Add(new TextContent()
            {
                Title = "Level Checking Procedure",
                Order = 5,
                ElementContent = DataContext.GetContent("levelCheckingProcedure")
            });


            ///
            /// Fault Codes Section
            ///

            var faultCodes = new Section() { Order = 2, Title = "Fault Code Access" };
            faultCodes.Attributes.Add(new to_lib.Attribute() { Name = "autoShow", Value = "false" });
            faultCodes.Attributes.Add(new to_lib.Attribute() { Name = "class", Value = "articeSection" });
            faultCodes.Tags.Add(new Tag() { Value = "FaultCodeAccess" });

            faultCodes.Elements.Add(new TextContent()
            {
                Title = "Code Access",
                Order = 1,
                ElementContent = DataContext.GetContent("codeACcess")
            });

            Sections.Add(faultCodes);

            ///
            /// Fault Code List Section
            ///

            var faultCodeList = new Section() { Order = 3, Title = "Fault Codes" };
            faultCodeList.Attributes.Add(new to_lib.Attribute() { Name = "autoShow", Value = "false" });
            faultCodeList.Attributes.Add(new to_lib.Attribute() { Name = "class", Value = "articeSection" });
            faultCodeList.Tags.Add(new Tag() { Value = "faultCodes" });


            faultCodeList.Elements.Add(new TableContent()
            {
                Title = "Fault Codes",
                Order = 1,
                ElementContent = DataContext.GetContent("faultCodes")
            });

            Sections.Add(faultCodeList);

            ///
            /// Component Inspection Section
            ///

            var componentInsepctionSection = new Section() { Order = 3, Title = "Component Inspection" };
            componentInsepctionSection.Attributes.Add(new to_lib.Attribute() { Name = "autoShow", Value = "false" });
            componentInsepctionSection.Attributes.Add(new to_lib.Attribute() { Name = "class", Value = "articeSection" });
            componentInsepctionSection.Tags.Add(new Tag() { Value = "componentInspection" });

            componentInsepctionSection.Elements.Add(new TextContent() { Order = 1, Title = "Component Inspection", ElementContent = "N/A" });

            Sections.Add(componentInsepctionSection);

            ///
            /// Pin Data Section
            ///

            var pinDataSection = new Section() { Order = 3, Title = "Pindata" };
            pinDataSection.Attributes.Add(new to_lib.Attribute() { Name = "autoShow", Value = "false" });
            pinDataSection.Attributes.Add(new to_lib.Attribute() { Name = "class", Value = "articeSection" });
            pinDataSection.Tags.Add(new Tag() { Value = "pindata" });

            pinDataSection.Elements.Add(new TableContent()
            {
                Order = 1,
                Title = "Pin Data",
                ElementContent = DataContext.GetContent("pindata")
            });

            Sections.Add(pinDataSection);

            var diagramsSection = new Section() { Order = 4, Title = "Diagrams" };
            pinDataSection.Attributes.Add(new to_lib.Attribute() { Name = "autoShow", Value = "false" });
            pinDataSection.Attributes.Add(new to_lib.Attribute() { Name = "class", Value = "articeSection" });
            pinDataSection.Tags.Add(new Tag() { Value = "diagrams" });

            diagramsSection.Elements.Add(new Resource()
            {
                Order = 1,
                Title = "Component Locations",
                Location = new Uri("images/AT1003_thumb.gif", UriKind.RelativeOrAbsolute)
            });

            diagramsSection.Elements.Add(new Resource()
            {
                Order = 1,
                Title = "Filler Location",
                Location = new Uri("images/AT1081_thumb.gif", UriKind.RelativeOrAbsolute)
            });

            diagramsSection.Elements.Add(new Resource()
            {
                Order = 1,
                Title = "Valve Body Layout",
                Location = new Uri("images/AT1076_thumb.gif", UriKind.RelativeOrAbsolute)
            });

            diagramsSection.Elements.Add(new Resource()
            {
                Order = 1,
                Title = "Wiring Diagram",
                Location = new Uri("images/AT1087_thumb.gif", UriKind.RelativeOrAbsolute)
            });

            diagramsSection.Elements.Add(new Resource()
            {
                Order = 1,
                Title = "Wiring Diagram",
                Location = new Uri("images/AT1089_thumb.gif", UriKind.RelativeOrAbsolute)
            });

            diagramsSection.Elements.Add(new Resource()
            {
                Order = 1,
                Title = "Wiring Diagram",
                Location = new Uri("images/AT1002_thumb.gif", UriKind.RelativeOrAbsolute)
            });

            Sections.Add(diagramsSection);

        }
    }
}
