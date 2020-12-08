using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int digit1 = 0;
            int digit2 = 0;
            char digit3 = ' ';
            char digit4 = ' ';
            int digit5 = 11;
            string result = "";
            int maxValue = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i >= digit5)
                    break;
                digit1 = i;
                for (int j = 1; j <= n; j++)
                {
                    digit2 = j;
                    for (char k='a'; k<'a'+l; k++)
                    {
                        digit3 = k;
                        for (char y = 'a'; y < 'a'+l; y++)
                        {
                            digit4 = y;
                            if (i > j)
                                maxValue = i;
                            else
                                maxValue = j;
                            for (int x = maxValue+1; x <= n; x++)
                            {
                                digit5 = x;
                                result = digit1.ToString() + digit2.ToString() + Char.ToString(digit3) + Char.ToString(digit4) + digit5.ToString();
                                Console.Write(result + " ");
                            }
                        }
                    }   
                            
                }
                
            }
        }
    }
}
