using System;

namespace SumSeconds
{
    class Program
    {
        static void Main()
        {
            string typeOfProjection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            double premier = 12;
            double normal = 7.50;
            double discount = 5;
            int seats = row * col;
            double amount = 0;
            switch (typeOfProjection)
            {
                case "Premiere":
                    amount = seats * premier;
                    Console.WriteLine($"{amount,2:F}");
                    Console.WriteLine("leva");
                    break;
                case "Normal":
                    amount = seats * normal;
                    Console.WriteLine($"{amount,2:F}");
                    Console.WriteLine("leva");
                    break;
                case "Discount":
                    amount = seats * discount;
                    Console.WriteLine($"{amount,2:F}");
                    Console.WriteLine("leva");
                    break;
            }
            
        }
    }
}
