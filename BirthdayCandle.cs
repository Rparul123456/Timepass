//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Text;
//using System.Linq;

//namespace TimePass
//{
//    class BirthdayCandle
//    {
//        static int birthdayCakeCandles(int[] ar)
//        {
//            // var newArray = ar.GroupBy(x => x);

//            //var total = newArray.OrderByDescending(x => x.Count()).First();

//            //int count = 0;
//            //List<int> newArr = new List<int>();

//            //var newArray = ar.OrderByDescending(x => x).ToArray();

//            //for (int i = 0; i < newArray.Count(); i++)
//            //{
//            //    for (int j = i; j < newArray.Count(); j++)
//            //    {
//            //        if (newArray[i] == newArray[j])
//            //        {
//            //            count++;
//            //        }
//            //    }
//            //    newArr.Add(count);
//            //}

//            int count = 1;
//            int temp = ar[0];

//            for (int i = 1; i < ar.Length; i++)
//            {
//                if (ar[i] > temp)
//                {
//                    temp = ar[i];
//                    count = 1;
//                }
//                else if (ar[i] == temp)
//                {
//                    count++;
//                }
//            }

//            return count;
//            //return total.Count();
//        }

//        static void Main(string[] args)
//        {
//            int arCount = Convert.ToInt32(Console.ReadLine());
//            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
//            int result = birthdayCakeCandles(ar);
//            Console.WriteLine("output is:" +result);
//        }
//    }
//}
