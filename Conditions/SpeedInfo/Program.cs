using System;

namespace SpeedInfo
{
    class Program
    {
        static void Main()
        {
            double speedNum = double.Parse(Console.ReadLine());
            string infoSpeed = "";
            if (speedNum <= 10)
                infoSpeed = "slow";
            else if (speedNum <= 50)
                infoSpeed = "average";
            else if (speedNum <= 150)
                infoSpeed = "fast";
            else if (speedNum <= 1000)
                infoSpeed = "ultra fast";
            else if (speedNum > 1000)
                infoSpeed = "extremely fast";
            Console.WriteLine(infoSpeed);
        }
    }
}
