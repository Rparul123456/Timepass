//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace TimePass
//{
//    class ElectronicShop
//    {
//        static int getMoneySpent(int[] keyboards, int[] drives, int b)
//        {
//            int max = -1;
//            int sum = 0;
//            foreach(var priceKB in keyboards)
//            {
//                foreach(var priceDrive in drives)
//                {
//                    sum = priceDrive + priceKB;
//                    if(sum > max && sum <= b)
//                    {
//                        max = sum;
//                    }
//                }
//            }

//            return max;

//        }
//        static void Main(string[] args)
//        {
//            string[] bnm = Console.ReadLine().Split(' ');

//            int b = Convert.ToInt32(bnm[0]);

//            int n = Convert.ToInt32(bnm[1]);

//            int m = Convert.ToInt32(bnm[2]);

//            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '), keyboardsTemp => Convert.ToInt32(keyboardsTemp))
//            ;

//            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
//            ;
//            /*
//             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
//             */

//            int moneySpent = getMoneySpent(keyboards, drives, b);
//            Console.WriteLine(moneySpent);

//        }
//    }
//}
