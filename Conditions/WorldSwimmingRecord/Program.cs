using System;

namespace WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double bestRecord = double.Parse(Console.ReadLine()); //time in seconds
            double distance = double.Parse(Console.ReadLine()); // distance in meters
            double speedIvan=double.Parse(Console.ReadLine());
            double speedWater = Math.Floor(distance / 15);
            double timeIvan = distance * speedIvan + (speedWater * 12.5);
            double result = (timeIvan - bestRecord);
            if (timeIvan < bestRecord)
                Console.WriteLine($"Yes, he succeeded! The new world record is {timeIvan,2:F} seconds.");
            else
                Console.WriteLine($"No, he failed! He was {result,2:F} seconds slower.");
        }
    }
}
