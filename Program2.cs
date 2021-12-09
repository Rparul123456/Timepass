//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace TimePass
//{
//    public class Program2
//    {
        
//        static void plusMinus(int[] arr)
//        {
//            //decimal plusCount = 0, minusCount = 0, zeroCount = 0;
//            //for (int i = 0; i < arr.Length; i++)
//            //{
//            //    if (arr[i] > 0)
//            //        plusCount++;
//            //    else if (arr[i] < 0)
//            //        minusCount++;
//            //    else
//            //        zeroCount++;
//            //}
//            //Console.WriteLine(Math.Round(plusCount / arr.Length, 6));
//            //Console.WriteLine(Math.Round(minusCount / arr.Length, 6));
//            //Console.WriteLine(Math.Round(zeroCount / arr.Length, 6));

//            Console.WriteLine(Math.Round(Convert.ToDecimal(arr.Count(x => x > 0)) / arr.Length, 6));
//            Console.WriteLine(Math.Round(Convert.ToDecimal(arr.Count(x => x < 0)) / arr.Length, 6));
//            Console.WriteLine(Math.Round(Convert.ToDecimal(arr.Count(x => x == 0)) / arr.Length, 6));

//        }
//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
//            plusMinus(arr);
//        }
//    }
//}
