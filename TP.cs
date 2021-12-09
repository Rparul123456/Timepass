//using System.CodeDom.Compiler;
//using System.Collections.Generic;
//using System.Collections;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Globalization;
//using System.IO;
//using System.Linq;
//using System.Reflection;
//using System.Runtime.Serialization;
//using System.Text.RegularExpressions;
//using System.Text;
//using System;

//namespace TimePass
//{
//    class TP
//    {
//        static int findLongestPalindrome(String S)
//        {
//            string longest = S.Substring(0,1);
//            for(int i=0; i< S.Length; i++)
//            {
//                //odd
//                string temp = checkEquality(S, i, i);
//                if(longest.Length < temp.Length)
//                {
//                    longest = temp;
//                }

//                //// even
//                //temp = checkEquality(S, i, i+1);
//                //if (longest.Length < temp.Length)
//                //{
//                //    longest = temp;
//                //}
//            }
//            Console.WriteLine(longest);
//            return longest.Length;
//        }

//        public static string checkEquality(String str, int begin, int end)
//        {
//            while(begin >= 0 && end <= str.Length-1 && str.ElementAt(begin) == str.ElementAt(end))
//            {
//                begin--;
//                end++;
//            }
//            return str.ra.Substring(begin + 1, end-begin);
//        }

//        static void Main(string[] args)
//        {
//            string S;
//            S = Console.ReadLine();
//            int result;
//            result = findLongestPalindrome(S);

//            Console.Write(result);
//        }
//    }
//}