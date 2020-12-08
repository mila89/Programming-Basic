using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            bool isSpecial = true;
            for (int i = 1111; i <= 9999; i++)
            {
                string valueInString=i.ToString();
                for (int j = 0; j < 4; j++)
                {
                   int p = ((int)valueInString[j] - 48);
                    if (p==0 || (num % ((int)valueInString[j]-48) != 0))
                    {
                        isSpecial = false;
                        break;
                    }
                    else
                        isSpecial = true;
                }
                if (isSpecial)
                    Console.Write(i+" ");
            }
        }
    }
}
