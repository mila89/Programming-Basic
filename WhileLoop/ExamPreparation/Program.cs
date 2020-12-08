using System;

namespace ExamPreparation
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int numOfBadResults = 0;
            string subjectSchool = "";
            int score = 0;
            double finalScore = 0;
            int i = 0;
            string endResult = "";
            while (numOfBadResults <= n)
            {
                subjectSchool = Console.ReadLine();
                if (subjectSchool == "Enough")
                {
                   double result = finalScore/Convert.ToDouble(i);
                    Console.WriteLine($"Average score: {result,2:F}");
                    Console.WriteLine($"Number of problems: {i}");
                    Console.WriteLine($"Last problem: {endResult}");
                    break;
                }
                score = int.Parse(Console.ReadLine());
                if (score <= 4)
                    numOfBadResults++;
                if (numOfBadResults == n)
                {
                    Console.WriteLine($"You need a break, {n} poor grades.");
                    break;
                }
                finalScore = finalScore + score;
                i++;
                endResult = subjectSchool;
            }
        }
    }
}
