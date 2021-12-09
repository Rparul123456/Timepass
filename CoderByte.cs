//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Json;
//using System.Linq;

//namespace TimePass
//{
//    class CoderByte
//    {
//        public static void Main(string[] args)
//        {
//            string response = string.Empty;
//            //string input = "{ 'name':{ 'first':'Robert','middle':'','last':'Smith'},'age':25,'DOB':' - ','hobbies':['running','coding',' - '],'education':{ 'highschool':'N\'/ A','college':'Yale'}";
//            using (StreamReader streamWriter = new StreamReader(@"C:\json.txt"))
//            {
//                    response = streamWriter.ReadToEnd();
//            }
            
//            var JsonData = JsonValue.Parse(response).ToString();
//            var test = JsonData.Split(",");

//            var abc = test.Where(x => !x.Contains("N/A"));

//            Console.WriteLine(abc.ToList());
//        }
//    }
//}

