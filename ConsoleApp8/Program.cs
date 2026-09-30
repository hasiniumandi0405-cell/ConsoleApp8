using ConsoleApp8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        ServiceRobot originalRobot = new ServiceRobot(
            "SR-100",
            10,
            "V1.0",
            "Hospital Assistance"
        );

        ServiceRobot clonedRobot =
            (ServiceRobot)originalRobot.Clone();

        clonedRobot.BatteryCapacity = 15;
        clonedRobot.SoftwareVersion = "V1.1";

        Console.WriteLine("Original Robot:");
        originalRobot.Display();

        Console.WriteLine("\nCloned Robot:");
        clonedRobot.Display();


        IndustrialRobot industrialRobot =
            new IndustrialRobot(
                "IR-200",
                20,
                "V2.0",
                "Welding"
            );

        IndustrialRobot clonedIndustrialRobot =
            (IndustrialRobot)industrialRobot.Clone();

        clonedIndustrialRobot.BatteryCapacity = 25;

        Console.WriteLine("\nIndustrial Robot Clone:");
        clonedIndustrialRobot.Display();


        EntertainmentRobot entertainmentRobot =
            new EntertainmentRobot(
                "ER-300",
                8,
                "V3.0",
                "Dancing"
            );

        EntertainmentRobot clonedEntertainmentRobot =
            (EntertainmentRobot)entertainmentRobot.Clone();

        clonedEntertainmentRobot.BatteryCapacity = 12;

        Console.WriteLine("\nEntertainment Robot Clone:");
        clonedEntertainmentRobot.Display();
    }
}