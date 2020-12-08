using System;

namespace FishingBoat
{
    class Program
    {
        static void Main()
        {
            int budjet = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numFishers = int.Parse(Console.ReadLine());
            double rentBoat = 0;
            switch (season)
            {
                case "Spring":
                    rentBoat = 3000;
                    break;
                case "Summer" :
                    rentBoat = 4200;
                    break;
                case "Autumn":
                    rentBoat = 4200;
                    break;
                case "Winter":
                    rentBoat = 2600;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
                    break;  
            }
            if (numFishers <= 6 )
                rentBoat = rentBoat * 0.9;
            else if (numFishers > 7 && numFishers <= 11)
                rentBoat = rentBoat * 0.85;
            else if (numFishers >= 12)
                rentBoat = rentBoat * 0.75;
            if ((numFishers % 2 == 0) && season != "Autumn")
                rentBoat = rentBoat * 0.95;
            rentBoat = Math.Round(rentBoat, 2);
            if (rentBoat != 0)
            {
                if (rentBoat < budjet)
                    Console.WriteLine($"Yes! You have {budjet - rentBoat,2:F} leva left.");
                else
                    Console.WriteLine($"Not enough money! You need {rentBoat - budjet,2:F} leva.");
            }
        }
    }
}
