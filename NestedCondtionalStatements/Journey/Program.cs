using System;

namespace Journey
{
    class Program
    {
        static void Main()
        {
            double budjet = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = "";
            string typeOfHoliday = "";
            double spendedMoney = 0;
            switch (season)
            {
                case "summer" :
                    if (budjet <= 100 && budjet > 0)
                    {
                        destination = "Bulgaria";
                        typeOfHoliday = "Camp";
                        spendedMoney = budjet * 30 / 100;
                    }
                    else if (budjet > 100 && budjet <= 1000)
                    {
                        destination = "Balkans";
                        typeOfHoliday = "Camp";
                        spendedMoney = budjet * 40 / 100;
                    }
                    else if (budjet > 1000)
                    {
                        destination = "Europe";
                        typeOfHoliday = "Hotel";
                        spendedMoney = budjet * 90 / 100;
                    }
                    break;

                case "winter":
                    if (budjet <= 100 && budjet > 0)
                    {
                        destination = "Bulgaria";
                        typeOfHoliday = "Hotel";
                        spendedMoney = budjet * 70 / 100;
                    }
                    else if (budjet > 100 && budjet <= 1000)
                    {
                        destination = "Balkans";
                        typeOfHoliday = "Hotel";
                        spendedMoney = budjet * 80 / 100;
                    }
                    else if (budjet > 1000)
                    {
                        destination = "Europe";
                        typeOfHoliday = "Hotel";
                        spendedMoney = budjet * 90 / 100;
                    }
                    break;
            }
            Console.WriteLine("Somewhere in "+destination);
            Console.WriteLine($"{typeOfHoliday} - {spendedMoney,2:F}");
        }
    }
}
