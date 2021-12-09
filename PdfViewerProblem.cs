//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class PdfViewerProblem
//    {
//        public static int designerPdfViewer(List<int> h, string word)
//        {
//            //int[] highestValue = new int[] {0};
//            //List<string> alphabets = new List<string>(new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" });
//            //foreach (var item in word.Select(x => new string(x, 1)).ToArray())
//            //{
//            //    var position = alphabets.IndexOf(item.ToString());
//            //    if (highestValue[0] >= h[position])
//            //    {
//            //        continue;
//            //    }
//            //    else
//            //    {
//            //        highestValue[0] = h[position];
//            //    }
//            //}
//            //return highestValue[0] * word.Length;

//            int max = 0;
//            for (int i = 0; i < word.Length; i++)
//            {
//                if (h[word[i] - 'a'] > max)
//                {
//                    max = h[word[i] - 97];
//                }
//            }
//            return max * word.Length;
//        }
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            List<int> h = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(hTemp => Convert.ToInt32(hTemp)).ToList();

//            string word = Console.ReadLine();

//            int result = PdfViewerProblem.designerPdfViewer(h, word);
//        }
//    }
//}
