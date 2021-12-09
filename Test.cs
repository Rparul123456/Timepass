//using System;
//using System.Collections.Generic;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//namespace TimePass
//{
//    class Test
//    {

//        static void Main(string[] args)
//        {


//            Dictionary<int, string> input = new Dictionary<int, string>();

//            input.Add(2, "A,B,C");
//            input.Add(3, "D,E,F");

//            int[] keyArr = new int[2] {2,3};
//            string test = string.Empty;
//            string test1 = string.Empty;

//            foreach(var key in keyArr) 
//            {
//                if (input.ContainsKey(key))
//                {
//                    Console.WriteLine(input[key]);
//                    test += input[key]+',';  /// A,B,C,D,E,F
//                }
//            }

//            var arr1 = test.Split(',');
//            var list = new List<string>();
//               //Console.WriteLine(input[key]);
//            for(int i = 0; i< arr1.Length; i++)
//            {
//                test1 = string.Empty;
//                for (int j = i; j < arr1.Length; j++)
//                {
//                    test1 += arr1[j];
//                    list.Add(test1);
//                Console.WriteLine(test1 +" ");

//            }

//            }

//            var testList = list.Where(x => x.Length == keyArr.Length).ToList();

//        }
//    }
//}
