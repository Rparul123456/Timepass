//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class PrisonerProblem
//    {
//        public static List<int> circularArrayRotation(List<int> a, int k, List<int> queries)
//        {
//            var newLsit = new List<int>( new int[a.Count] );
//            for (int i = 0; i < a.Count; i++)
//            {
//                newLsit[(i + k) % a.Count] = a[i];
//            }

//            var indexList = new List<int>();
//            foreach (var item in queries)
//            {
//                indexList.Add(newLsit[item]);
//            }
//            return indexList;
//        }


//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int n = Convert.ToInt32(firstMultipleInput[0]);

//            int k = Convert.ToInt32(firstMultipleInput[1]);

//            int q = Convert.ToInt32(firstMultipleInput[2]);

//            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

//            List<int> queries = new List<int>();

//            for (int i = 0; i < q; i++)
//            {
//                int queriesItem = Convert.ToInt32(Console.ReadLine().Trim());
//                queries.Add(queriesItem);
//            }

//            List<int> result = PrisonerProblem.circularArrayRotation(a, k, queries);
//        }
//    }
//}
