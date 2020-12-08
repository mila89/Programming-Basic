using System;

namespace Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hourIn = int.Parse(Console.ReadLine());
            int minutesIn=int.Parse(Console.ReadLine());
            minutesIn = minutesIn + 15;
            int hourOut = 0;
            int minutesOut = 0;
            if (minutesIn > 59)
            {
                minutesOut = minutesIn - 60;
                hourOut = hourIn + 1;
                if (hourOut > 23)
                    hourOut = 0;
            }
            else
            {
                minutesOut = minutesIn;
                hourOut = hourIn;
            }
            if (minutesOut<10)
                Console.WriteLine($"{hourOut}:0{minutesOut}");
            else
                Console.WriteLine($"{hourOut}:{minutesOut}");
        }
    }
}
