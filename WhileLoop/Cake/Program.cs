using System;

namespace Cake
{
    class Program
    {
        static void Main()
        {
            int lenght = int.Parse(Console.ReadLine());
            int wide = int.Parse(Console.ReadLine());
            int piecesCount = lenght * wide;
            int consumedPieces = 0;
            string input = "";
            while (piecesCount > consumedPieces)
            {
                input= (Console.ReadLine());
                if (input != "STOP")
                {
                    consumedPieces = consumedPieces + int.Parse(input);
                    if (consumedPieces >= piecesCount)
                    {
                        Console.WriteLine($"No more cake left! You need {consumedPieces - piecesCount} pieces more.");
                        break;
                    }
                }
                if (input == "STOP")
                {
                    Console.WriteLine($"{piecesCount-consumedPieces} pieces are left.");
                    break;
                }
            }
        }
    }
}
