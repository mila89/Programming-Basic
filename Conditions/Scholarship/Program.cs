using System;

namespace Scholarship
{
    class Program
    {
        static void Main()
        {
            double earnings = double.Parse(Console.ReadLine());
            double averageProgress= double.Parse(Console.ReadLine());
            double minSalary= double.Parse(Console.ReadLine());
            double scholarshipScocial = 0;
            double scholarshipProgress = 0;
            if (averageProgress < 4.5)
                Console.WriteLine("You cannot get a scholarship!");
            else
            {
                Console.WriteLine("You cannot get a scholarship!dsds");
                /* if (earnings > minSalary)
                 {
                     if (averageProgress >= 5.5)
                     {
                         scholarshipProgress = Math.Floor(5.5 * 25);
                         Console.WriteLine($"You get a scholarship for excellent results {scholarshipProgress} BGN");
                     }
                 }
                 else
                 {
                     if (averageProgress >= 5.5)
                         scholarshipProgress = 5.5 * 25;
                     else
                         scholarshipScocial = minSalary * 35 / 100;
                     if (scholarshipScocial > scholarshipProgress)
                         Console.WriteLine($"You get a Social scholarship {Math.Floor(scholarshipScocial)} BGN");
                     else
                         Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(scholarshipProgress)} BGN"); ;
                 }*/
            }
        }
    }
}
