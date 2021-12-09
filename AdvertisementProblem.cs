//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class AdvertisementProblem
//    {
//        public static int viralAdvertising(int n)
//        {
//            int tolalCummLikes = 0;
//            int recepients = 5;
//            for (int i = 1; i <= n; i++)
//            {
//                int likes = recepients/2;
//                tolalCummLikes += likes;
//                recepients = likes * 3;
//            }
//            return tolalCummLikes;
//        }
//    }
//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            int result = AdvertisementProblem.viralAdvertising(n);

//            Console.WriteLine(result);
//        }
//    }
//}
