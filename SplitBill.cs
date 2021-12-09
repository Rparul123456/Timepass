//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class SplitBill
//    {
//        static void bonAppetit(List<int> bill, int k, int b)
//        {
//            int final = b - (bill.Sum() - bill[k])/2;
//            if(final == 0)
//            {
//                Console.WriteLine("Bon Appetit");
//            }
//            else
//            {
//                Console.WriteLine(final);
//            }
//        }

//        static void Main(string[] args)
//        {
//            string[] nk = Console.ReadLine().TrimEnd().Split(' ');

//            int n = Convert.ToInt32(nk[0]);

//            int k = Convert.ToInt32(nk[1]);

//            List<int> bill = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(billTemp => Convert.ToInt32(billTemp)).ToList();

//            int b = Convert.ToInt32(Console.ReadLine().Trim());

//            bonAppetit(bill, k, b);
//        }
//    }
//}
