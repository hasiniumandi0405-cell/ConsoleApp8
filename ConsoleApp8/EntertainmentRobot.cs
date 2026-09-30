using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp8
{
    public class EntertainmentRobot : Robot
    {
        public string EntertainmentFeature { get; set; }

        public EntertainmentRobot(
            string modelName,
            int batteryCapacity,
            string softwareVersion,
            string entertainmentFeature)
            : base(modelName, batteryCapacity, softwareVersion)
        {
            EntertainmentFeature = entertainmentFeature;
        }

        public override Robot Clone()
        {
            return (EntertainmentRobot)this.MemberwiseClone();
        }

        public override void Display()
        {
            Console.WriteLine("Entertainment Robot");
            base.Display();
            Console.WriteLine(
                "Entertainment Feature: " + EntertainmentFeature);
        }
    }
}
