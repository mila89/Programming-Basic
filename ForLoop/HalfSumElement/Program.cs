using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum = sum + num;
                if (num > max)
                {
                    max = num;
                }
            }
            int sumWithoutMaxNumber = sum - max;
            if (max==sumWithoutMaxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int result = Math.Abs(sumWithoutMaxNumber-max);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {result}");
            }
            
        }
    }
}
