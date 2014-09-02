using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using to_lib;

namespace to_dummyData
{
    public class fordServiceSchedule:ServiceSchedule
    {
        public fordServiceSchedule()
        {
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 15000, Selected = true, Months = 12, Labour = 0.8 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 30000, Selected = true, Months = 24, Labour = 0.8 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 45000, Selected = true, Months = 36, Labour = 1.2 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 60000, Selected = true, Months = 48, Labour = 0.8 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 75000, Selected = true, Months = 60, Labour = 0.8 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 90000, Selected = true, Months = 72, Labour = 1.3});
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 105000, Selected = true, Months = 84, Labour = 0.8 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 120000, Selected = true, Months = 96, Labour = 0.8 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 135000, Selected = true, Months = 108, Labour = 1.2 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 150000, Selected = true, Months = 120, Labour = 1.4 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 165000, Selected = true, Months = 132, Labour = 0.8 });
            ServiceIntervals.Add(new ServiceInterval() { ServiceIntervalMarker = 180000, Selected = true, Months = 144, Labour = 1.3 });

            var lubGroup = new ServiceOperationGroup() { Order = 1, Name = "Lubrication" };
            ServiceOperationGroups.Add(lubGroup);

            lubGroup.ServiceOperations.Add(BuildServiceOperation("Engine Oil & filter", "*Replace every 7,500 km or 6 months under severe conditions 2,4,5 or 6"));
            lubGroup.ServiceOperations.Add(BuildServiceOperation("Engine Coolant", "Check antifreeze content. Replace every 3 years, Add 0.5 hr"));
            lubGroup.ServiceOperations.Add(BuildServiceOperation("Automatic Transmission Oil", "Add 0.9 hr *Replace fluid every 45,000 km under severe conditions 5 or 6,"));
            lubGroup.ServiceOperations.Add(BuildServiceOperation("Brake Fluid", "Replace fluid every 2 years. *Replace fluid every 12 months under severe conditions 2 or 3, Add 0.2 hr"));
            lubGroup.ServiceOperations.Add(BuildServiceOperation("Rear Differential Oil", "*Replace fluid every 60,000 km under severe conditions 5 or 6, Add 0.2 hr"));


            var ubGroup = new ServiceOperationGroup() { Order = 2, Name = "Under Bonnet" };
            ServiceOperationGroups.Add(ubGroup);
            ubGroup.ServiceOperations.Add(BuildServiceOperation("Pollen Filter (if fitted)", "Replace as required *Replace every 5,000 km under severe conditions 2", operationType.Replace));
            ubGroup.ServiceOperations.Add(BuildServiceOperation("Drive Belts", "*Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            ubGroup.ServiceOperations.Add(BuildServiceOperation("Cooling System", "*Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6"));
            ubGroup.ServiceOperations.Add(BuildServiceOperation("Spark Plugs", ""));
            ubGroup.ServiceOperations.Add(BuildServiceOperation("Fuel Filter", ""));
            ubGroup.ServiceOperations.Add(BuildServiceOperation("Fuel Lines and Hoses", "*Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6"));
            ubGroup.ServiceOperations.Add(BuildServiceOperation("Air Filter", "*Clean Air cleaner body and intake tube every 5,000 km under severe conditions 2, 4, 5 or 6 *Replace every 15,000 km under severe conditions 2"));
            ubGroup.ServiceOperations.Add(BuildServiceOperation("Battery Level and Terminals", "*Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6"));
            ubGroup.ServiceOperations.Add(BuildServiceOperation("All Fluid Levels", "*Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6"));

            var candbGroup = new ServiceOperationGroup() { Order = 3, Name = "Chassis & Body" };
            ServiceOperationGroups.Add(candbGroup);
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Brakes Pads", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Brake Discs", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Brake Lines, Caliper Seals, Connections and Hoses", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Parkbrake Travel", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("C.V. Boots and Driveshafts", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Steering Linkages and Boots", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Exhaust System and Mountings", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Front Suspension Components", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Rear Suspension Components", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Interior, Exterior and Warning Lights", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Door Locks and Hinges", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Lubricate));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Driveline Oil Leaks", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            candbGroup.ServiceOperations.Add(BuildServiceOperation("Tyre Pressure and Wear", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));

            var igroup = new ServiceOperationGroup() { Name = "Interior", Order = 4 };
            ServiceOperationGroups.Add(igroup);
            igroup.ServiceOperations.Add(BuildServiceOperation("Air Conditioning / Climate Control Performance", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));
            igroup.ServiceOperations.Add(BuildServiceOperation("Instruments, Switches and Controls", "Inspect every 7,500 km or 6 months under severe conditions 2,4,5 or 6", operationType.Inspect));

            var agroup = new ServiceOperationGroup() { Name = "Additional Checks", Order = 5 };
            ServiceOperationGroups.Add(agroup);
            agroup.ServiceOperations.Add(BuildServiceOperation("Vehicle Diagnostic Check", "Diagnostic Check on Auto Trans/Engine including Idle speed and ABS", operationType.Inspect));
            agroup.ServiceOperations.Add(BuildServiceOperation("Vehicle Campaign or Recall Actions", "Using the Ford Computer Network", operationType.Inspect));
            agroup.ServiceOperations.Add(BuildServiceOperation("Road Test", "", operationType.Inspect));
            

        }

        private ServiceOperation BuildServiceOperation(string p1, string p2, operationType type = operationType.Inspect)
        {
            var so = new ServiceOperation() { OperationName = p1, ServiceNotes = p2 };

            foreach (var si in ServiceIntervals)
            {
                so.ServiceOperations.Add(new ServiceIntervalOperation() { OperationType = type, ServiceInterval = si });
            }
            return so;
        }

    }
}
