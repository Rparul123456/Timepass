//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class AppleOrange
//    {
//        static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
//        {
//            int countApple = 0, countOrange = 0;

//            for (int i =0; i< apples.Length; i++)
//            {
//                apples[i] += a;
//                if (apples[i] >= s && apples[i] <= t)
//                {
//                    countApple++;
//                }
//            }

//            for (int i = 0; i < oranges.Length; i++)
//            {
//                oranges[i] += b;
//                if (oranges[i] >= s && oranges[i] <= t)
//                {
//                    countOrange++;
//                }
//            }


//            Console.WriteLine(countApple);
//            Console.WriteLine(countOrange);
//        }

//        static void Main(string[] args)
//        {
//            string[] st = Console.ReadLine().Split(' ');

//            int s = Convert.ToInt32(st[0]);

//            int t = Convert.ToInt32(st[1]);

//            string[] ab = Console.ReadLine().Split(' ');

//            int a = Convert.ToInt32(ab[0]);

//            int b = Convert.ToInt32(ab[1]);

//            string[] mn = Console.ReadLine().Split(' ');

//            int m = Convert.ToInt32(mn[0]);

//            int n = Convert.ToInt32(mn[1]);

//            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp));

//            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
//            ;
//            countApplesAndOranges(s, t, a, b, apples, oranges);
//        }
//    }
//}
