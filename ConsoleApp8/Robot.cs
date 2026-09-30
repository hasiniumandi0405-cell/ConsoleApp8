using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp8
{
    public abstract class Robot
    {
        public string ModelName { get; set; }
        public int BatteryCapacity { get; set; }
        public string SoftwareVersion { get; set; }

        public Robot(string modelName, int batteryCapacity, string softwareVersion)
        {
            ModelName = modelName;
            BatteryCapacity = batteryCapacity;
            SoftwareVersion = softwareVersion;
        }

        public abstract Robot Clone();

        public virtual void Display()
        {
            Console.WriteLine("Model Name: " + ModelName);
            Console.WriteLine("Battery Capacity: " + BatteryCapacity + " hours");
            Console.WriteLine("Software Version: " + SoftwareVersion);
        }
    }
}
