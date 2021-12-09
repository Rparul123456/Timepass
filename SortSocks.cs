//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class SortSocks
//    {
//        static int sockMerchant(int n, int[] ar)
//        {
//            int count = 0;
//            Array.Sort(ar);
//            for (int i = 0; i < ar.Length-1; i++) { 
//                if(ar[i] == ar[i + 1])
//                {
//                    count += 1;
//                    i++;
//                }
//            }

//            return count;
//        }
//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
//            ;
//            int result = sockMerchant(n, ar);
//            Console.WriteLine(result);
//        }
//    }
//}
