//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class SetProb
//    {
//        /*
//   * Complete the 'getTotalX' function below.
//   *
//   * The function is expected to return an INTEGER.
//   * The function accepts following parameters:
//   *  1. INTEGER_ARRAY a
//   *  2. INTEGER_ARRAY b
//   */

//        public static int getTotalX(List<int> a, List<int> b)
//        {
//            int count = 0;
//            List<int> t = new List<int>();
//            t.AddRange(a);
//            t.AddRange(b);

//            var min = a.Last();
//            var max = b.First();

//            while (min <= max) { 
//                var temp = 0;
//                foreach (var item in t) {
//                    if (min >= item)
//                    {
//                        if (min % item != 0)
//                        {
//                            temp = 1;
//                            break;
//                        }
//                    }
//                    else if (min <= item)
//                    {
//                        if (item % min != 0)
//                        {
//                            temp = 1;
//                            break;
//                        }
//                    }
//                }
//                if (temp == 0)
//                {
//                    count++;
//                }
//                min++;
//            }
//            Console.WriteLine(count);
//            return count;
//        }

//        public static void Main(string[] args)
//        {
//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int n = Convert.ToInt32(firstMultipleInput[0]);

//            int m = Convert.ToInt32(firstMultipleInput[1]);

//            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

//            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

//            int total = getTotalX(arr, brr);

//        }
//    }
//}

