namespace Task_2
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Console.Write("Please enter a day:");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Now, please enter a month:");
            int month = int.Parse(Console.ReadLine());

            Console.Write("And in the last place, please enter a year:");
            int year = int.Parse(Console.ReadLine());

            Console.WriteLine("The day of the week is: " + DayOfWeek(day,month,year ));

            
        }

        public static int DateCounter(int startingDate, int endingDate)
        {
            int counter = 0;

            for (int i = startingDate; i <= endingDate; i++)
            {

                if (DayOfWeek(03, 03, i) == "Wednesday") // this count how many times 03 march was on Wednesday in some period
                {
                    counter++;
                }
            }

            return counter;
        }


        public static string DayOfWeek(int day, int month, int year)
        {
            string dayString;
            int a = (14 - month) / 12;
            int y = year - a;
            int m = month + 12 * a - 2;
            int d = (day + y + y / 4 - y / 100 + y / 400 + (31 * m) / 12) % 7;

            switch (d)
            {
                case 0:
                    dayString = "Sunday";
                    break;
                case 1:
                    dayString = "Monday";
                    break;
                case 2:
                    dayString = "Tuesday";
                    break;
                case 3:
                    dayString = "Wednesday";
                    break;
                case 4:
                    dayString = "Thursday";
                    break;
                case 5:
                    dayString = "Friday";
                    break;
                case 6:
                    dayString = "Saturday";
                    break;
                default:
                    dayString = "Sorry Could not compute month :(";
                    break;
            }
            return dayString; ;
        }
    }
}
