using System;
using System.Collections.Generic;
using Weather.Model;

namespace WeatherApp.Model

{
    public class Timeline
    {
        public string Timestep { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Interval> Intervals { get; set; }
    }
}