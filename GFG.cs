using System;
using System.Collections.Generic;
using System.Text;

namespace TimePass
{
    class GFG
    {
        static int MAX_CHAR = 26;

        static String encodeString(char[] str)
        {
            // hashEven stores the count of even
            // indexed character for each string
            // hashOdd stores the count of odd
            // indexed characters for each string
            int[] hashEven = new int[MAX_CHAR];
            int[] hashOdd = new int[MAX_CHAR];

            // creating hash for each string
            for (int i = 0; i < str.Length; i++)
            {
                char m = str[i];

                // If index of current character is odd
                if ((i & 1) != 0)
                    hashOdd[m - 'a']++;
                else
                    hashEven[m - 'a']++;
            }

            // For every character from 'a' to 'z',
            // we store its count at even position
            // followed by a separator,
            // followed by count at odd position.
            String encoding = "";
            for (int i = 0; i < MAX_CHAR; i++)
            {
                encoding += (hashEven[i]);
                encoding += ('-');
                encoding += (hashOdd[i]);
                encoding += ('-');
            }
            return encoding;
        }

        // This function basically uses a hashing based set
        // to store strings which are distinct according
        // to criteria given in question.
        static int countDistinct(String[] input, int n)
        {
            int countDist = 0; // Initialize result

            // Create an empty set and store all distinct
            // strings in it.
            HashSet<String> s = new HashSet<String>();
            for (int i = 0; i < n; i++)
            {
                // If this encoding appears first time,
                // increment count of distinct encodings.
                if (!s.Contains(encodeString(input[i].ToCharArray())))
                {
                    s.Add(encodeString(input[i].ToCharArray()));
                    countDist++;
                }
            }

            return countDist;
        }

        // Driver Code
        //public static void Main(String[] args)
        //{
        //    String[] input = {"abcd", "acbd", "adcb",
        //                "cdba", "bcda", "badc"};
        //    int n = input.Length;

        //    Console.WriteLine(countDistinct(input, n));
        //}
    }
}
