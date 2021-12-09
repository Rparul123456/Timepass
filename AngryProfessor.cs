//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class AngryProfessor
//    {
//        public static int beautifulDays(int i, int j, int k)
//        {
//            var beautifulDayList = new List<int>();
//            for (int z = i; z <= j; z++)
//            {
//                int reverse = 0;
//                int number = z;
//                while (number > 0)
//                {
//                    int r = number % 10; 
//                    reverse = reverse * 10 + r;
//                    number = number / 10;
//                }

//                if ((z - reverse) % k == 0)
//                {
//                    beautifulDayList.Add(i);
//                }
//            }
//            return beautifulDayList.Count;
//        }
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

//            int i = Convert.ToInt32(firstMultipleInput[0]);

//            int j = Convert.ToInt32(firstMultipleInput[1]);

//            int k = Convert.ToInt32(firstMultipleInput[2]);

//            int result = AngryProfessor.beautifulDays(i, j, k);

//            Console.WriteLine(result);

//        }
//    }
//}