using System;
using System.Collections.Generic;
namespace ShellDemo
{
    public class BusStopsData : List<BusStopInfo>
    {
        public BusStopsData()
        {
            Add(new BusStopInfo { CrossStreets = "7th Ave W & W Raye St", AttractionName = "West Queene Anne", RouteNumber = 2 });
            Add(new BusStopInfo { CrossStreets = "Queen Anne Ave N & Mercer St", AttractionName = "Seattle Center", RouteNumber = 2 });
            Add(new BusStopInfo { CrossStreets = "3rd Ave & Union St", AttractionName = "Downtown Seattle", RouteNumber = 2 });
            Add(new BusStopInfo { CrossStreets = "Broadway & E Union St", AttractionName = "First Hill", RouteNumber = 2 });
            Add(new BusStopInfo { CrossStreets = "Madrona Dr & Lake Washington Blvd", AttractionName = "Madrona Park", RouteNumber = 2 });

            Add(new BusStopInfo { CrossStreets = "34th Ave & E Union St", AttractionName = "Madrona", RouteNumber = 3 });
            Add(new BusStopInfo { CrossStreets = "E Jefferson St & 23rd Ave", AttractionName = "Cherry Hill", RouteNumber = 3 });
            Add(new BusStopInfo { CrossStreets = "Jefferson St & 9th Ave", AttractionName = "First Hill", RouteNumber = 3 });
            Add(new BusStopInfo { CrossStreets = "3rd Ave & Pike St", AttractionName = "Downtown Seattle", RouteNumber = 3 });
            Add(new BusStopInfo { CrossStreets = "Cedar St & Denny Way", AttractionName = "Seattle Center", RouteNumber = 3 });
            Add(new BusStopInfo { CrossStreets = "Queen Anne Ave N & Boston St", AttractionName = "Queen Anne", RouteNumber = 3 });
            Add(new BusStopInfo { CrossStreets = "3rd Ave W & W Cremona St", AttractionName = "Seattle Pacific University", RouteNumber = 3 });

            Add(new BusStopInfo { CrossStreets = "Pike St & 4th Ave", AttractionName = "Downtown Seattle", RouteNumber = 10 });
            Add(new BusStopInfo { CrossStreets = "Pike St & Boren Ave", AttractionName = "Stop #11132", RouteNumber = 10 });
            Add(new BusStopInfo { CrossStreets = "E John St & Broadway", AttractionName = "Stop #29270", RouteNumber = 10 });
            Add(new BusStopInfo { CrossStreets = "E John St & 15th Ave", AttractionName = "Capitol Hill", RouteNumber = 10 });
            Add(new BusStopInfo { CrossStreets = "15th Ave & E Galer St", AttractionName = "Stop #11370", RouteNumber = 10 });

            Add(new BusStopInfo { CrossStreets = "Mt Rainier Dr S & S Hanford St", AttractionName = "Mt Baker", RouteNumber = 14 });
            Add(new BusStopInfo { CrossStreets = "23rd Ave S & S Jackson St", AttractionName = "Stop #11910", RouteNumber = 14 });
            Add(new BusStopInfo { CrossStreets = "S Jackson St & 5th Ave S", AttractionName = "Downtown Seattle", RouteNumber = 14 });
            Add(new BusStopInfo { CrossStreets = "3rd Ave & Pike St", AttractionName = "Downtown Seattle", RouteNumber = 14 });
            Add(new BusStopInfo { CrossStreets = "1st Ave & John St", AttractionName = "Downtown Seattle", RouteNumber = 14 });

            Add(new BusStopInfo { CrossStreets = "4th Ave S & S Jackson St", AttractionName = "Downtown Seattle", RouteNumber = 19 });
            Add(new BusStopInfo { CrossStreets = "3rd Ave & Union St", AttractionName = "Downtown Seattle", RouteNumber = 19 });
            Add(new BusStopInfo { CrossStreets = "Denny Way & Queen Anne Ave N", AttractionName = "Seattle Center", RouteNumber = 19 });
            Add(new BusStopInfo { CrossStreets = "28th Ave W & W Blaine St", AttractionName = "Central Magnolia", RouteNumber = 19 });
            Add(new BusStopInfo { CrossStreets = "W Emerson St & Magnolia Blvd W", AttractionName = "West Magnolia", RouteNumber = 19 });
        }
    }

    public class BusStopInfo
    {
        public string CrossStreets { get; set; }
        public int RouteNumber { get; set; }
        public string AttractionName { get; set; }
    }

}
