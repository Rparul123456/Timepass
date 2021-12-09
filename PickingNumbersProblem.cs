//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class PickingNumbersProblem
//    {
//        public static int pickingNumbers(List<int> a)
//        {
//            List<int> newList = new List<int>();
//            var list1 = a.OrderBy(x => x).ToList();
//            for (int i=0; i < list1.Count(); i++)
//            {
//                int count = 1;
//                for (int j = i; j < list1.Count()-1; j++ )
//                {
//                    int diff = Math.Abs(list1[i]) - Math.Abs(list1[j + 1]);
//                    if (Math.Abs(diff) <= 1)
//                    {
//                        count++;
//                    }
//                }
//                newList.Add(count);
//            }
//            return newList.Max(x => x);
//        }

//        static void Main(string[] args)
//        {

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//            int result = PickingNumbersProblem.pickingNumbers(a);

//            Console.WriteLine(result);

//        }

//        }
//    }
