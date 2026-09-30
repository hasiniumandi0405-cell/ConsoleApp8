using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp8
{
    public class IndustrialRobot : Robot
    {
        public string IndustrialTask { get; set; }

        public IndustrialRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string industrialTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            IndustrialTask = industrialTask;
        }

        public override Robot Clone()
        {
            return (IndustrialRobot)this.MemberwiseClone();
        }

        public override void Display()
        {
            Console.WriteLine("Industrial Robot");
            base.Display();
            Console.WriteLine("Industrial Task: " + IndustrialTask);
        }
    }
}
