using System;

namespace GodzillaKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double filmBudjet = double.Parse(Console.ReadLine());
            int statists = int.Parse(Console.ReadLine());
            double clothPrice = double.Parse(Console.ReadLine());
            double decorPrice = filmBudjet * 10 / 100;
            double clothBudjet = 0;
            if (statists <= 150)
                clothBudjet = statists * clothPrice;
            else
                clothBudjet = statists * clothPrice * 0.9;
            double clothDecorAmount = clothBudjet+decorPrice;
            if (clothDecorAmount > filmBudjet)
            {
                double neededMoney = clothDecorAmount - filmBudjet;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {neededMoney,2:F} leva more.");
            }
            else 
            { 
                double neededMoney = filmBudjet - clothDecorAmount;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {neededMoney,2:F} leva left.");
            }
        }
    }
}