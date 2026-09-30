using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp8
{
    public class ServiceRobot : Robot
    {
        public string ServiceTask { get; set; }

        public ServiceRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string serviceTask)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            ServiceTask = serviceTask;
        }

        public override Robot Clone()
        {
            return (ServiceRobot)this.MemberwiseClone();
        }

        public override void Display()
        {
            Console.WriteLine("Service Robot");
            base.Display();
            Console.WriteLine("Service Task: " + ServiceTask);
        }
    }
}
