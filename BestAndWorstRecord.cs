//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class BestAndWorstRecord
//    {
//        static int[] breakingRecords(int[] scores)
//        {
//            int tempMin = scores[0];
//            int tempMax = scores[0];

//            int[] newArr = new int[2];

//            foreach (var item in scores) {
//                if (item < tempMin) {
//                    tempMin = item;
//                    ++newArr[1];
//                }
//                if (item > tempMax) {
//                    tempMax = item;
//                    ++newArr[0];
//                }
//            }

//            return newArr;

//        }

//        static void Main(string[] args)
//        {

//            int n = Convert.ToInt32(Console.ReadLine());

//            int[] scores = Array.ConvertAll(Console.ReadLine().Split(' '), scoresTemp => Convert.ToInt32(scoresTemp));
//            int[] result = breakingRecords(scores);

//        }
//    }
//}
