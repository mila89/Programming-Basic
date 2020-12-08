using System;

namespace Coins
{
    class Program
    {
        static void Main()
        {
            double restSum = double.Parse(Console.ReadLine());
            double coin = 0;
            int coinCount = 0;
           if (restSum >= 2)
           {
               coinCount=coinCount+(int)(restSum) / 2;
               restSum = restSum % 2;
           }
           if (restSum >= 1)
           {
               coinCount = coinCount + (int)(restSum )/ 1;
               restSum = restSum % 1;
               restSum = restSum * 100;
           }
           if (restSum < 1)
                restSum = restSum * 100;
                if (restSum >= 50)
                {
                    coinCount = coinCount + (int)(restSum )/ 50;
                    restSum = restSum % 50;
                }
                if (restSum >= 20)
                {
                    coinCount = coinCount + (int)(restSum) / 20;
                    restSum = restSum % 20;
                }
                if (restSum >= 10)
                {
                    coinCount = coinCount + (int)(restSum) / 10;
                    restSum = restSum % 10;
                }
                if (restSum >= 5)
                {
                    coinCount = coinCount + (int)(restSum) / 5;
                    restSum = restSum % 5;
                }
                if (restSum >= 2)
                {
                    coinCount = coinCount + (int)(restSum) / 2;
                    restSum = restSum % 2;
                }
                if (restSum >= 1)
                {
                    coinCount = coinCount + (int)(restSum );
                    restSum = restSum % 1;
                }
            Console.WriteLine(coinCount);
        }
    }
}
