using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int numPrint = 1;
            for (int rows = 1; rows <= num; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {                
                    if (numPrint > num)
                        break;
                    Console.Write(numPrint + " ");
                    numPrint++;
                }
                if (numPrint >num)
                    break;
               Console.WriteLine();
            }
         }
    }
}
