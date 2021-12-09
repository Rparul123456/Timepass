//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class UtopianTreeProblem
//    {
//        public static int utopianTree(int n)
//        {
//            //recursion----
//            if (n == 0)
//                return (1);
//            else if (n % 2 != 0)
//                return (2 * utopianTree(n - 1));
//            else
//                return (utopianTree(n - 1) + 1);
//        }
//        //loop-----
//        //int number = 1;
//        //if (n == 0) { return 1; }
//        //else
//        //{
//        //    for (int i =1; i <= n; i++)
//        //    {
//        //      number =  i % 2 == 0 ? number + 1 : number * 2;
//        //    }
//        //    return number;
//        //}
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            int t = Convert.ToInt32(Console.ReadLine().Trim());

//            for (int tItr = 0; tItr < t; tItr++)
//            {
//                int n = Convert.ToInt32(Console.ReadLine().Trim());

//                int result = UtopianTreeProblem.utopianTree(n);

//                Console.WriteLine("-----------Result is--------------");
//                Console.WriteLine(result);
//            }

//        }
//    }
//}
