using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0; //delenie na 2
            double p2 = 0; // delenie na 3
            double p3 = 0; // na 4
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    double procent = Convert.ToDouble(100) / Convert.ToDouble(n);
                    p1 = p1 + procent;
                }
                if (num % 3 == 0)
                {
                    double procent = Convert.ToDouble(100) / Convert.ToDouble(n);
                    p2 = p2 + procent;
                }
                if (num % 4 == 0)
                {
                    double procent = Convert.ToDouble(100) / Convert.ToDouble(n);
                    p3 = p3 + procent;
                }
            }
            Console.WriteLine($"{p1,2:F}%");
            Console.WriteLine($"{p2,2:F}%");
            Console.WriteLine($"{p3,2:F}%");
        }

        }
}
