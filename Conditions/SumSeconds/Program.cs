using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());
            int sumTime = firstTime + secondTime + thirdTime;
            int sumSeconds = sumTime % 60;
            int sumMinutes = (sumTime / 60);

            if (sumSeconds<10)
                Console.WriteLine($"{ sumMinutes}:0{ sumSeconds}");
            else Console.WriteLine($"{ sumMinutes}:{ sumSeconds}");
        }
    }
}
