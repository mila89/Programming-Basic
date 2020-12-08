using System;

namespace Walking
{
    class Program
    {
        static void Main()
        {
            int sumSteps = 0;
            //int sumSteps = 0;
            while (sumSteps < 10000)
            {
                string input = Console.ReadLine();
                if (input != "Going home")
                {
                    sumSteps = sumSteps + int.Parse(input);
                 }
                else 
                {
                    sumSteps = sumSteps + int.Parse(Console.ReadLine());
                    break;
                }
            }
            if (sumSteps >= 10000)
            {
                Console.WriteLine("Goal reached! Good job!");
                Console.WriteLine($"{sumSteps - 10000} steps over the goal!");
            }
            else
                Console.WriteLine($"{10000 - sumSteps} more steps to reach goal.");
        }
    }
}
