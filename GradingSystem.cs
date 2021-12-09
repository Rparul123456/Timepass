//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace TimePass
//{
//    class GradingSystem
//    {
//        public static List<int> gradingStudents(List<int> grades)
//        {
//            //int roundValue = 0;
//            //List<int> newGrades = new List<int>();

//            //foreach (var item in grades) 
//            //{
//            //   decimal decimalVal = (decimal)item / 5;
//            //   roundValue = Convert.ToInt32(Math.Ceiling(decimalVal));
//            //    if (((roundValue*5) - item) < 3 && item >= 38)
//            //    {
//            //        newGrades.Add(roundValue*5);
//            //    }
//            //    else
//            //        newGrades.Add(item);
//            //}

//            //return newGrades;

//            for (int i = 0; i < grades.Count; i++)
//            {
//                grades[i] = grades[i] >= 38 && grades[i] % 5 > 2 ? grades[i] + (5 - grades[i] % 5) : grades[i];
//            }
//            return grades;
//        }


//        public static void Main(string[] args)
//        {
//            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> grades = new List<int>();

//            for (int i = 0; i < gradesCount; i++)
//            {
//                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
//                grades.Add(gradesItem);
//            }

//            gradingStudents(grades);

//        }
//    }
//}
