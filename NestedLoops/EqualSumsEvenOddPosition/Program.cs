using System;

namespace EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main()
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            for (int i = Num1; i <= Num2; i++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string currentNum = i.ToString();
                for (int j = 0; j < currentNum.Length; j++)
                {
                    if (j % 2 != 0)
                    {
                        oddSum += int.Parse(currentNum[j].ToString());
                    }
                    else
                    { 
                        evenSum=evenSum+int.Parse(currentNum[j].ToString());
                    }
                }
                if (oddSum==evenSum)
                    Console.Write((i)+" ");
            }
        }
    }
}
