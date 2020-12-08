using System;

namespace OperationsBetweenNumbers
{
    class Program
    {
        static void Main()
        {
            int N1 = int.Parse(Console.ReadLine());
            int N2 = int.Parse(Console.ReadLine());
            double result = 0;
            char operatorType = char.Parse(Console.ReadLine());
            switch (operatorType)
            {
                case '+':
                    result = N1 + N2;
                    if (result % 2 == 0)
                        Console.WriteLine($"{N1} + {N2} = {result} - even");
                    else
                        Console.WriteLine($"{N1} + {N2} = {result} - odd");
                    break;
                case '-':
                    result = N1 - N2;
                    if (result % 2 == 0)
                        Console.WriteLine($"{N1} - {N2} = {result} - even");
                    else
                        Console.WriteLine($"{N1} - {N2} = {result} - odd");
                    break;
                case '*':
                    result = N1 * N2;
                    if (result % 2 == 0)
                        Console.WriteLine($"{N1} * {N2} = {result} - even");
                    else
                        Console.WriteLine($"{N1} * {N2} = {result} - odd");
                    break;
                case '/':
                    if (N2 != 0)
                    { 
                    result = Convert.ToDouble(N1) / Convert.ToDouble(N2);
                    Console.WriteLine($"{N1} / {N2} = {result,2:F}"); 
                    }
                    else
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    break;
                case '%':
                    if (N2 != 0)
                    {
                        result = N1 % N2;
                        Console.WriteLine($"{N1} % {N2} = {result}");
                    }
                    else
                        Console.WriteLine($"Cannot divide {N1} by zero");
                    break;
            }
         }
    }
}
