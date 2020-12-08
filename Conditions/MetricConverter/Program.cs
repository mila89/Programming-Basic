using System;

namespace MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double inputNum = double.Parse(Console.ReadLine());
            string mesureIn = Console.ReadLine();
            string mesureOut = Console.ReadLine();
            double result = 0;
            if (mesureIn == "m")
            {
                if (mesureOut == "cm")
                    result = inputNum * 100;
                else
                    result = inputNum * 1000;
            }
            else if (mesureIn == "cm")
            {
                if (mesureOut == "mm")
                    result = inputNum * 10;
                else
                    result = inputNum / 100;
            }
            else if (mesureIn == "mm")
            {
                if (mesureOut == "cm")
                    result = inputNum / 10;
                else
                    result = inputNum / 1000;
            }

            Console.WriteLine("{0:F3}", result);
        }
    }
}
