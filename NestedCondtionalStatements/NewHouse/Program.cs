using System;

namespace NewHouse
{
    class Program
    {
        static void Main()
        {
            string flours = Console.ReadLine();
            int numFlours = int.Parse(Console.ReadLine());
            int budjet = int.Parse(Console.ReadLine());
            double flourPrice = 0;
            switch (flours)
            {
                case "Roses":
                    if (numFlours>80)
                        flourPrice = 5 * numFlours*0.9;
                    else
                        flourPrice = 5 * numFlours;
                    break;
                case "Dahlias":
                    if (numFlours > 90)
                        flourPrice = 3.8 * numFlours * 0.85;
                    else
                        flourPrice = 3.8 * numFlours;
                    break;
                case "Tulips":
                    if (numFlours > 80)
                        flourPrice = 2.8 * numFlours * 0.85;
                    else
                        flourPrice = 2.8 * numFlours;
                    break;
                case "Narcissus":
                    if (numFlours < 120)
                        flourPrice = 3 * numFlours * 1.15;
                    else
                        flourPrice = 3 * numFlours;
                    break;
                case "Gladiolus":
                    if (numFlours < 80)
                        flourPrice = 2.5 * numFlours * 1.2;
                    else
                        flourPrice = 2.5 * numFlours;
                    break;
            }
            if (budjet-flourPrice>=0)
                Console.WriteLine($"Hey, you have a great garden with {numFlours} {flours} and {budjet-flourPrice,2:F} leva left.");
            else
                Console.WriteLine($"Not enough money, you need {flourPrice-budjet,2:F} leva more.");
        }
    }
}
