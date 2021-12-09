//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class SequenceEquation
//    {
//        public static int jumpingOnClouds(int[] c, int k)
//        {
//            int i = 0;
//            int e = 100;
//            do
//            {
//                i = (i + k) % c.Length;
//                e = c[i] == 0 ? e - 1 : e - 3;
//            } while (i != 0);
//                return e;
//        }
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            string[] nk = Console.ReadLine().Split(' ');

//            int n = Convert.ToInt32(nk[0]);

//            int k = Convert.ToInt32(nk[1]);

//            int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
//            ;
//            int result = SequenceEquation.jumpingOnClouds(c, k);

//        }
//    }
//}
