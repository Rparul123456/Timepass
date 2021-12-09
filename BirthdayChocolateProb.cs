//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class BirthdayChocolateProb
//    {
//        static int birthday(List<int> s, int d, int m)
//        {
//            int count = 0;
//            for (int i = 0; i < s.Count - m + 1; i++)
//            {
//                int temp = s[i];
//                for (int j = 1; j < m; j++)
//                {
//                    temp = temp + s[i + j];
//                }
//                if (temp == d)
//                {
//                    count++;
//                }
//            }
//            return count;
//        }
//        static void Main(string[] args)
//        {

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

//            string[] dm = Console.ReadLine().TrimEnd().Split(' ');

//            int d = Convert.ToInt32(dm[0]);

//            int m = Convert.ToInt32(dm[1]);

//            int result = birthday(s, d, m);
//        }
//    }
//}
