using System;
using System.Collections.Generic;
namespace ShellDemo
{
    public class BusRoutes : List<BusRouteInfo>
    {
        public BusRoutes(params BusRouteInfo[] args)
        {
            this.AddRange(args);
        }

        public BusRoutes()
        {

        }
    }

    public class BusRouteInfo
    {
        public int RouteNumber { get; set; }
        public string RouteDestination { get; set; }

        public override string ToString()
        {
            return $"{RouteNumber}";
        }
    }

    public static class BusInfoForDisplay
    {
        public static BusRoutes AllRoutes = new BusRoutes()
        {
            new BusRouteInfo { RouteNumber = 2, RouteDestination = "Madrona Park" },
            new BusRouteInfo { RouteNumber= 3, RouteDestination="Seattle Pacific University" },
            new BusRouteInfo { RouteNumber = 10, RouteDestination="Capitol Hill" },
            new BusRouteInfo { RouteNumber = 14, RouteDestination="Downtown Seattle" },
            new BusRouteInfo { RouteNumber = 19, RouteDestination="West Magnolia" }
        };
    }
}
