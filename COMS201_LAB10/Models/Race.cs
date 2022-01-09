using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace COMS201_LAB10.Models
{
    public enum RaceType
    {
        Marathon,
        Automobile,
        Motorcycle
    }
    public class Race
    {
        public string Name { get; set; }
        public RaceType Type { get; set; }
        public DateTime StartTime { get; set; }

        public Race(string name, string date, int type)
        {
            Name = name;
            DateTime.TryParse(date, out int d);
            StartTime = d;
            if(type == 1)
            {
                Type = RaceType.Automobile;
            }
            if(type == 2)
            {
                Type = RaceType.Motorcycle;
            }
            if (type != 1 && type != 2)
            {
                Type = RaceType.Marathon;
            }
        }
    }
}
