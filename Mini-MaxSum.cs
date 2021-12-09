//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;
//using System.Numerics;

//namespace TimePass
//{
//    class Mini_MaxSum
//    {

//        static void miniMaxSum(int[] arr)
//        {

//            var smallElement = arr.Min();
//            var largeElement = arr.Max();
//            long addition = 0;

//            foreach (var items in arr) 
//            {
//                addition += items;
//            }

//            Console.WriteLine((addition - largeElement) + " " + (addition - smallElement));


//            //var smallArr = arr.OrderBy(x => x).ToList();
//            //var largeArr = arr.OrderByDescending(x => x).ToList();
//            //long smallestSum = 0, largestSum = 0;

//            //smallestSum = smallArr.Skip(1).Sum(x => x);
//            //largestSum = largeArr.Skip(1).Sum(x => x);
//            //smallArr.RemoveAt(0);
//            //largeArr.RemoveAt(0);            

//            //foreach(var item in smallArr) 
//            //{
//            //    smallestSum += item;
//            //}

//            //foreach (var item in largeArr)
//            //{
//            //    largestSum += item;
//            //}


//        }  
//        static void Main(string[] args)
//        {
//            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
//            miniMaxSum(arr);
//        }
//    }
//}
