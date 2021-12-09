//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Linq;

//namespace TimePass
//{
//    class HackerEarth
//    {
//        public int checkKthElement(int[] arr, int findingElement)
//        {
//            int[] tempArr = new int[arr.Length];
//            var tst = arr.OrderByDescending(x => x).ToArray();
//            for(int i=0; i < tst.Length; i++)
//            {
//                for(int j=i; j<tst.Length; j++)
//                {
//                    var dif = Math.Abs(i - j);
//                    if(arr.Contains(dif) == false)
//                    {
//                        tempArr[i] = dif;
//                    }
//                }
//            }

//            var abc = tst.Concat(tempArr).OrderByDescending(x => x).ToArray();

//            if(tst.Length < findingElement)
//            {
//                return -1;
//            }
//            else
//            {
//                return abc[findingElement - 1];
//            }
//        }

//        public static void Main(string[] args)
//        {
//            int totalTestcases = Convert.ToInt32(Console.ReadLine());
//            for(int i=0; i< totalTestcases; i++)
//            {
//                var arrCount = Convert.ToInt32(Console.ReadLine());

//                 int[] s = Console.ReadLine().Split().Select(int.Parse).ToArray();

//                int findElement = Convert.ToInt32(Console.ReadLine());
//                HackerEarth obj = new HackerEarth();

//                var result = obj.checkKthElement(s, findElement);
//                Console.WriteLine(result);
//            }
           
//        }
//    }
//}
