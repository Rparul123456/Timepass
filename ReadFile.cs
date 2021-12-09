using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace TimePass
{
    class ReadFile
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            var text = System.IO.File.ReadAllLines(@"C:\Users\chourpar\input.txt");

            foreach (var item in text)
            {
                var word = item.Split(',')[1];
                if (dict.ContainsKey(word))
                {
                    dict[word]++;
                }
                else
                {
                    dict.Add(word,1);
                }

            }

            var value = dict.OrderByDescending(x => x.Value).First().Value;
            var key = dict.OrderByDescending(x => x.Value).First().Key;
            string output = key + ":" + value;
            File.WriteAllText(@"C:\Users\chourpar\output.txt", output.ToString());
        }
    }
}
