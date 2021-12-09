//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class ValleyProblem
//    {
//        public static int countingValleys(int steps, string path)
//        {
//            var path1 = path.ToCharArray();
//            int seaLevel = 0;
//            int valleyCount = 0;
//            foreach (var step in path1) {
//                //seaLevel =  step == 'U' ? seaLevel+1 : seaLevel-1 ;
//                valleyCount = ++seaLevel == 0 && step == 'U' ? valleyCount+1 : seaLevel--;
//            }
//            return valleyCount;
//        }

//        class Solution
//        {
//            public static void Main(string[] args)
//            {

//                int steps = Convert.ToInt32(Console.ReadLine().Trim());

//                string path = Console.ReadLine();

//                int result = ValleyProblem.countingValleys(steps, path);
//                Console.WriteLine(result);
//            }
//        }
//    }
//}
