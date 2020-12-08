using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            for (int i = 1; i <= n; i++)
            {
                double num=double.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    oddSum = oddSum + num;
                    if (oddMin > num)
                        oddMin = num;
                    if (oddMax < num)
                        oddMax = num;
                }
                else 
                {
                    evenSum = evenSum + num;
                    if (evenMin > num)
                        evenMin = num;
                    if (evenMax < num)
                        evenMax = num;
                }
            }
            Console.WriteLine($"OddSum={oddSum,2:F},");
            if (oddMin==double.MaxValue)
                Console.WriteLine("OddMin=No,");
            else
                Console.WriteLine($"OddMin={oddMin,2:F},");
            if (oddMax==double.MinValue)
                Console.WriteLine("OddMax=No,");
            else
                Console.WriteLine($"OddMax={oddMax,2:F},");
            Console.WriteLine($"EvenSum={evenSum,2:F},");
            if (evenMin==double.MaxValue)
               Console.WriteLine("EvenMin=No,");
            else
                Console.WriteLine($"EvenMin={evenMin,2:F},");
            if (evenMax==double.MinValue)
                Console.WriteLine("EvenMax=No");
            else
                Console.WriteLine($"EvenMax={evenMax,2:F}");
        }
    }
}
