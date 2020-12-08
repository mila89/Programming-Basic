using System;

namespace Volleyball
{
    class Program
    {
        static void Main()
        {
            string typeOfYear = Console.ReadLine();
            int p = int.Parse(Console.ReadLine()); //* praznichni dni
            int h = int.Parse(Console.ReadLine()); //* pytuwa do rodniq grad
            int weekendsInSofia = 48 - h;
            double playsInTown = 0;
            double plays = 0;
            plays = weekendsInSofia*3 ;
            plays = plays / 4;
            playsInTown = p * 2;
            playsInTown = playsInTown / 3;
            //Math.Round(playsInTown, 3);
            plays = plays + playsInTown + h;
            //*+ h + p * 2 / 3;
            if (typeOfYear == "leap")
            {
                Math.Round(plays, 3);
                double morePlays = plays * 15 / 100;
                Math.Round(morePlays, 3);
                plays =plays+morePlays;
            }
            Console.WriteLine(Math.Floor(plays));
        }
    }
}
