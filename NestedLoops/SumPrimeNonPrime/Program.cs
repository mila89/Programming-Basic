using System;

namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main()
        {
            string input = " ";
            int num = 0;
            int primeSum = 0;
            int noPrimeSum = 0;
            while (input != "stop")
            {
                input = Console.ReadLine();
                if (input =="stop")
                    break;
                num = int.Parse(input);
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }
                if (num == 1 || num==2)
                    primeSum += num;
                else
                {
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0 && num!=2)
                        {
                            noPrimeSum += num;
                            break;
                        }
                        if (i==num-1)
                            primeSum += num;
                    }
                }
                
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {noPrimeSum}");

        }
    }
}
