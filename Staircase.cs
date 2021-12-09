//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class Staircase
//    {
//        static void staircase(int n)
//        {
//            for (int i = 1; i <= n; i++)
//            {
//                for (int j = n; j >= 1; j--)
//                {
//                    if (i < j)
//                    {
//                        Console.Write(" ");
//                    }
//                    else 
//                    {
//                        Console.Write("#");
//                    }
//                }
//                Console.WriteLine();
//            }
//        }

//        static void Main(string[] args)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            staircase(n);
//        }
//    }
//}
