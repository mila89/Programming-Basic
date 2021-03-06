﻿using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main()
        {
            int gradus = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            string outfit="";
            string shoes = "";
            switch (partOfDay)
            {
                case "Morning":
                    if (gradus >= 10 && gradus <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                    }
                    else if (gradus > 18 && gradus <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (gradus >= 25)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    break;
                case "Afternoon":
                    if (gradus >= 10 && gradus <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (gradus > 18 && gradus <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                    }
                    else if (gradus >= 25)
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                    }
                    break;
                case "Evening":
                    if (gradus >= 10 && gradus <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (gradus > 18 && gradus <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    else if (gradus >= 25)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                    }
                    break;
            }
            Console.WriteLine($"It's {gradus} degrees, get your {outfit} and {shoes}.");
        }
    }
}
