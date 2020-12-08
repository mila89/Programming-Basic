using System;

namespace Vacation
{
    class Program
    {
        static void Main()
        {
            
            string spendSave = "";
            double amount = 0;
            int i=0; 
            double moneyForHoliday = double.Parse(Console.ReadLine());
            double curentMoney = double.Parse(Console.ReadLine());
            int br = 1; // брояч за 5 последователни дни
            bool isSpend=false;
            while (curentMoney < moneyForHoliday)
            {
                spendSave = Console.ReadLine();
                amount = double.Parse(Console.ReadLine());
                if (spendSave == "spend")
                {
                    if (isSpend)
                        br++;
                    curentMoney = curentMoney - amount;
                    if (curentMoney < 0)
                        curentMoney = 0;
                    isSpend = true;
                    if (br == 5)
                    {
                        i++;
                        Console.WriteLine("You can't save the money.");
                        Console.WriteLine(i);
                        break;
                    }
                }
                else if (spendSave == "save")
                {
                    curentMoney = curentMoney + amount;
                    isSpend = false;
                    br = 1;
                }
                i++;
                if (curentMoney >= moneyForHoliday)
                {
                    Console.WriteLine($"You saved the money for {i} days.");
                    break;
                }
            }
        }
    }
}
