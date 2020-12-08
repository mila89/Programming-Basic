using System;

namespace HotelRoom
{
    class Program
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double priceStudio = 0;
            double priceApart = 0;
            if (month == "May" || month == "October")
            {
                priceApart = 65 * nights;
                priceStudio = 50 * nights;
                if (nights > 7 && nights <= 14)
                    priceStudio = priceStudio * 0.95;
                if (nights > 14)
                {
                    priceStudio = priceStudio * 0.7;
                    priceApart = priceApart * 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceApart = 68.70 * nights;
                priceStudio = 75.20 * nights;
                if (nights > 14)
                {
                    priceStudio = priceStudio * 0.8;
                    priceApart = priceApart * 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                priceApart = 77 * nights;
                priceStudio = 76 * nights;
                if (nights > 14)                   
                    priceApart = priceApart * 0.9;
             }
            Console.WriteLine($"Apartment: {priceApart,2:F} lv.");
            Console.WriteLine($"Studio: {priceStudio,2:F} lv.");
        }
    }
}
