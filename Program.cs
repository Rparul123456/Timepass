//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;

//namespace TimePass
//{
//    class Result
//    {

//        /*
//         * Complete the 'diagonalDifference' function below.
//         *
//         * The function is expected to return an INTEGER.
//         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
//         */

//        public static int diagonalDifference(List<List<int>> arr, int n)
//        {
//            int leftSum = 0;
//            int rightSum = 0;

//            for (int row = 0; row < n; row++)
//            {
//                for (int col = 0; col <= n; col++)
//                {
//                    if (row == col) {
//                        leftSum += arr[row][col];
//                    }
//                    if (row == n - col - 1) {
//                        rightSum += arr[row][col];
//                    }
//                }
//            }
           
//            int diff = rightSum - leftSum;

//            return Math.Abs(diff);
//        }
//    }

//class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello World!");
//            TextWriter textWriter = new StreamWriter(@"C:\Timepass\Timepass.txt", true);

//            int n = Convert.ToInt32(Console.ReadLine().Trim());

//            List<List<int>> arr = new List<List<int>>();

//            for (int i = 0; i < n; i++)
//            {
//                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
//            }

//            int result = Result.diagonalDifference(arr, n);

//            textWriter.WriteLine(result);

//            textWriter.Flush();
//            textWriter.Close();
        
//    }
//    }
//}
