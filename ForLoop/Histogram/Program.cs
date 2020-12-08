using System;

namespace Histogram
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;
            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > 0 && num < 200)
                {
                    double procent = Convert.ToDouble(100) / Convert.ToDouble(n);
                    p1 = p1 + procent;
                }
                else if (num >= 200 && num < 400)
                {
                    double procent = Convert.ToDouble(100) / Convert.ToDouble(n);
                    p2 = p2 + procent;
                }
                else if (num >= 400 && num < 600)
                {
                    double procent = Convert.ToDouble(100) / Convert.ToDouble(n);
                    p3 = p3 + procent;
                }
                else if (num >= 600 && num < 800)
                {
                    double procent = Convert.ToDouble(100) / Convert.ToDouble(n);
                    p4 = p4 + procent;
                }
                else if (num >= 800)
                {
                    double procent = Convert.ToDouble(100) / Convert.ToDouble(n);
                    p5 = p5 + procent;
                }
            }
            Console.WriteLine($"{p1,2:F}%");
            Console.WriteLine($"{p2,2:F}%");
            Console.WriteLine($"{p3,2:F}%");
            Console.WriteLine($"{p4,2:F}%");
            Console.WriteLine($"{p5,2:F}%");
        }
    }
}
