using Microsoft.VisualBasic;
using System;

namespace BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            double points = double.Parse(Console.ReadLine());
            double bonusPoints = 0;
            if (points <= 100)
                bonusPoints = 5;
            else if (points <= 1000)
                bonusPoints = points * 20 / 100;
            else if (points > 1001)
                bonusPoints = points * 10 / 100;
            if (points % 2 == 0)
                bonusPoints = bonusPoints + 1;
            else if (points%5==0)
            {
                if ((points / 5) % 2 != 0)
                    bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(points+bonusPoints);
        }
    }
}
