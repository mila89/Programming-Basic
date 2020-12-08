using System;

namespace OnTimefortheExam
{
    class Program
    {
        static void Main()
        {
            int examTime = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arraivingTime = int.Parse(Console.ReadLine());
            int arraivingMinute = int.Parse(Console.ReadLine());
            int printHours = examTime - arraivingTime;
            int printMinutes = 0;
            if ((printHours < 0 && arraivingTime != 0 && examTime!=0) || (printHours == 0 && examMinute < arraivingMinute))
            {   // Late
                Console.WriteLine("Late");
                if (printHours <= 0 && examTime!=0 && arraivingTime!=0)
                {
                    printHours = arraivingTime - examTime;
                    if (arraivingMinute > examMinute)
                        printMinutes = arraivingMinute - examMinute;
                    else if (arraivingMinute < examMinute)
                    {
                        printMinutes = 60 - examMinute + arraivingMinute;
                        printHours--;
                    }
                    else if (arraivingMinute == examMinute)
                        printMinutes = 0;
                    if (printHours > 0)
                    {
                        if (printMinutes > 9)
                            Console.WriteLine($"{printHours}:{printMinutes} hours after the start");
                        else
                            Console.WriteLine($"{printHours}:0{printMinutes} hours after the start");
                    }

                    else
                    {
                        Console.WriteLine($"{printMinutes} minutes after the start");
                    }
                }
                else if (printHours>0 && examTime!=0 && arraivingTime!=0)
                {
                    printMinutes = arraivingMinute - examMinute;
                    Console.WriteLine($"{printMinutes} minutes after the start");
                }
            }
            else if (printHours == 0 && examMinute == arraivingMinute)
            {
                Console.WriteLine("On time");
                // on time
            }
            else if ((printHours == 0 && (arraivingMinute - examMinute) <= 30) || (printHours > 0 && (60 - arraivingMinute + examMinute) <= 30))
            {
                Console.WriteLine("On time");
                //On time 30 minutes before the start
                if (printHours == 0)
                    printMinutes = examMinute - arraivingMinute;
                else
                    printMinutes = 60 - arraivingMinute + examMinute;
                Console.WriteLine($"{printMinutes} minutes before the start");
            }
            else if (((printHours > 0 && (60 - arraivingMinute + examMinute) > 30) && arraivingTime!=0 && examTime!=0) || (printHours == 0 && (examMinute - arraivingMinute) > 30))
            {
                // Early
                Console.WriteLine("Early");
                if (printHours > 0)
                {
                    printMinutes = 60 - arraivingMinute + examMinute;
                    if (printMinutes >= 60)
                    {
                        printHours = printHours++;
                        printMinutes = printMinutes - 60;
                        if (printMinutes < 10)
                            Console.WriteLine($"{printHours}:0{printMinutes} hours before the start");
                        else
                            Console.WriteLine($"{printHours}:{printMinutes} hours before the start");
                    }
                    else
                        Console.WriteLine($"{printMinutes} minutes before the start");
                }
                else
                {
                    printMinutes = arraivingMinute + examMinute;
                    Console.WriteLine($"{printMinutes} minutes before the start");
                }
            }
            else if ((arraivingTime == 0 && examTime != 0) || (arraivingTime != 0 && examTime == 0))
            {
                if (arraivingTime == 0)
                {
                    printHours = 24 - examTime;
                    printMinutes = 60 - examMinute + arraivingMinute;
                    printHours--;
                    Console.WriteLine("Late");
                    if (printHours == 0)
                    {
                        Console.WriteLine($"{printMinutes} minutes after the start");
                    }
                    else
                    {
                        if (printMinutes > 9)
                        {
                            Console.WriteLine($"{printHours}:{printMinutes} hours after the start");
                        }
                        else
                            Console.WriteLine($"{printHours}:0{printMinutes} hours after the start");
                    }
                 }
             else
                {
                    printHours = 24 - arraivingTime;
                    printMinutes = 60 - arraivingMinute + examMinute;
                    printHours--;
                    if (printHours == 0)
                    {
                        if (printMinutes <= 30)
                        {
                            Console.WriteLine("On time");
                            Console.WriteLine($"{printMinutes} minutes before the start");
                        }
                        else 
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine($"{printMinutes} minutes before the start");
                        }
                    }
                    else
                    {
                        if (printMinutes > 9)
                        {
                            Console.WriteLine($"{printHours}:{printMinutes} hours after the start");
                        }
                        else
                            Console.WriteLine($"{printHours}:0{printMinutes} hours after the start");
                    }
                }
                
             }
         }
    }
}
