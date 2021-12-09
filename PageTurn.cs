//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class PageTurn
//    {
//        static double pageCount(double n, double p)
//        {
//            double totalTurnFromFront = Math.Floor(n / 2);
//            double targetTurnFromFront = Math.Floor(p / 2);
//            double targetTurnFromBack = totalTurnFromFront - targetTurnFromFront;
//            double result = Math.Min(targetTurnFromFront, targetTurnFromBack);

//            return result;
//        }

//        static void Main(string[] args)
//        {

//            int n = Convert.ToInt32(Console.ReadLine());

//            int p = Convert.ToInt32(Console.ReadLine());

//            double result = pageCount(n, p);
//            Console.WriteLine(result);
//        }
//    }
//}
