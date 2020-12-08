using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());
            for (int i=1;i<=n;i++)
            {
                string siteName = Console.ReadLine();
                if (siteName == "Facebook")
                    salary = salary - 150;
                else if (siteName == "Instagram")
                    salary = salary - 100;
                else if (siteName == "Reddit")
                    salary = salary - 50;
                if (salary <= 0)
                    i = n + 1;
            }
            if (salary <= 0)
                Console.WriteLine("You have lost your salary.");
            else
                Console.WriteLine(salary);
        }
    }
}
