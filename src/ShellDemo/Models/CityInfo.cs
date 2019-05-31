using System;
using System.Collections.Generic;
namespace ShellDemo
{
    public class CityInfo : List<string>
    {
        public CityInfo(params string[] args)
        {
            this.AddRange(args);
        }

        public CityInfo()
        {
        }
    }



    public static class CityInfoForDisplay
    {
        public static CityInfo AllInformation = new CityInfo
        {
            "Space Needle","Pike Place Market","Seattle Great Wheel",
            "Pioneer Square", "Seattle Aquarium", "Seattle Center",
            "Original Starbucks", "Museum of Pop Culture", "Smith Tower",
            "Gas Works Park", "Fremont Troll", "The Museum of Flight","Woodland Park Zoo"
        };
    }
}
