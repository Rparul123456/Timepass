//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class MigratoryBirds
//    {
//        static int migratoryBirds(List<int> arr)
//        {
//            List<int> arr1 = new List<int>(Enumerable.Repeat(0,arr.Count));

//            for (int i = 0; i < arr.Count; i++)
//            {
//                arr1[arr[i]]++;
//            }
            

//            var maxCount = arr1.Max();
//            var maxVal = arr1.IndexOf(maxCount);

//            return maxVal;
//        }

//        static void Main(string[] args)
//        {

//            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//            int result = migratoryBirds(arr);
//            Console.WriteLine(result);
//        }
//    }
//}
