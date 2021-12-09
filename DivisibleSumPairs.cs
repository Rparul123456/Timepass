/* check for different solution*/

//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class DivisibleSumPairs
//    {
//        static int divisibleSumPairs(int n, int k, int[] ar)
//        {
//            int count = 0;
//            for (int i=0; i < n; i++)
//            {
//                for (int j = i; j < n-1; j++) 
//                {
//                    if (i > j)
//                    {
//                        continue;
//                    }
//                    else if ((ar[i]+ar[j+1]) % k == 0) 
//                    {
//                        count++;
//                    }
//                }
//            }

//            return count;

//        }

//        static void Main(string[] args)
//        {
//            string[] nk = Console.ReadLine().Split(' ');

//            int n = Convert.ToInt32(nk[0]);

//            int k = Convert.ToInt32(nk[1]);

//            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
//            ;
//            int result = divisibleSumPairs(n, k, ar);

//        }
//    }
//}
