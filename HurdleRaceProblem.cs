//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace TimePass
//{
//    class HurdleRaceProblem
//    {

//        static int hurdleRace(int k, int[] height)
//        {
//            //int maxHeight = height.Max();
//            //if(maxHeight - k > 0)
//            //{
//            //    return maxHeight - k;
//            //}
//            //else
//            //{
//            //    return 0;
//            //}

//            int potion = height.Max() - k;
//            return Math.Max(0, potion);

//        }

//        static void Main(string[] args)
//        {

//            string[] nk = Console.ReadLine().Split(' ');

//            int n = Convert.ToInt32(nk[0]);

//            int k = Convert.ToInt32(nk[1]);

//            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
//            ;
//            int result = hurdleRace(k, height);

//        }
//    }
//}
