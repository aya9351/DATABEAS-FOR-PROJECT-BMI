//using final_Project.Data;
//using final_Project.Models;
using System;

namespace final_Project
{
    internal class MeasurementRecord
    {
        public string UserName { get; set; }
        public DateTime Date { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double BMIValue { get; set; }
        public string BMICategory { get; set; }
    }
}