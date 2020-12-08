using System;

namespace OldBooks
{
    class Program
    {
        static void Main()
        {
            string myBook = Console.ReadLine();
            string nameBook = "";
            int i = 0;
            while (myBook != nameBook)
            {
                nameBook = Console.ReadLine();
                if (myBook == nameBook)
                {
                    Console.WriteLine($"You checked {i} books and found it.");
                    break;
                }
                else if (nameBook == "No More Books")
                {
                    Console.WriteLine("The book you search is not here!");
                    Console.WriteLine($"You checked {i} books.");
                    break;
                }
                i++;

            }
        }
    }
}
