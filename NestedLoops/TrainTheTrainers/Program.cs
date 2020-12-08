using System;

namespace TrainTheTrainers
{
    class Program
    {
        static void Main()
        {
            /* int numJuri = int.Parse(Console.ReadLine());
             bool isFinish = false;
             double scorePresent = 0;
             while (!isFinish)
             {
                 string presentation = Console.ReadLine();
                 for (int i = 1; i < numJuri; i++)
                 {
                     scorePresent += double.Parse(Console.ReadLine());
                 }
             }*/

            double judges = double.Parse(Console.ReadLine());
            double allAverage = 0;
            double sum = 0;
            double counter = 0;
            double average = 0;
            while (true)
            {
                string presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    allAverage = sum / counter;
                    Console.WriteLine($"Student's final assessment is {allAverage:f2}.");
                }
                for (int i = 1; i <= judges; i++)
                {
                    double result = double.Parse(Console.ReadLine());
                    sum += result;
                    counter++;
                    average = sum / counter;


                }
                Console.WriteLine($"{presentation} - {average:f2}.");
            }
        }
    }
}
