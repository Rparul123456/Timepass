//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class CalenderDate
//    {
//        // Complete the dayOfProgrammer function below.
//        static string dayOfProgrammer(int year)
//        {
//            int leapyear;
//            int totalDays;
//            int EightMonthTotal = 215;
//            if (year % 4 == 0)
//            {
//                leapyear = 29;
//            }
//            else
//            {
//                leapyear = 28;
//            }

//            totalDays = EightMonthTotal + leapyear;
//            int date = 256 - totalDays;
//            return(date + "." + "09" + "." + year);
//        }

//        static void Main(string[] args)
//        {

//            int year = Convert.ToInt32(Console.ReadLine().Trim());

//            string result = dayOfProgrammer(year);

//        }
//    }
//}
