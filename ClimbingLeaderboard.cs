//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace TimePass
//{
//    class ClimbingLeaderboard
//    {
//        public static List<int> climbingLeaderboard(List<int> ranked, List<int> player)
//        {
//            //List<int> newList = new List<int>();
//            //foreach(var item in player)
//            //{
//            //    ranked.Add(item);
//            //    //var sortedList = ranked.OrderByDescending(x => x).Distinct().ToList();
//            //    //newList.Add(sortedList.IndexOf(item) + 1);
//            //   // newList.Add(ranked.OrderByDescending(x => x).Distinct().ToList().IndexOf(item)+1);
//            //    ranked.Remove(item);
//            //}

//            //return newList;

//            //-------------------------------Binary Search-----------------------------------//

//            //    for (int i=0; i<player.Count; i++)
//            //{
//            //    if (player[i] > sortedList[0]) {
//            //        indexList.Add(1);
//            //    }
//            //    else if (player[i] < sortedList[sortedList.Count - 1]) {
//            //        indexList.Add((sortedList.Count-1)+2);
//            //    }
//            //    else
//            //    {
//            //        indexList.Add((BinarySearch(sortedList, player[i]))+1);
//            //    }
//            //}

//            //int BinarySearch(List<int> ar, int key) {
//            //    var start = 0;
//            //    var end = ar.Count - 1;

//            //    while (start <= end)
//            //    {
//            //        int mid = (start + end)/2;
//            //        if (key == ar[mid])
//            //        {
//            //            return mid;
//            //        }
//            //        else if (key > ar[mid] && key < ar[mid-1])
//            //        {
//            //            return mid;
//            //        }
//            //        else if (key < ar[mid] && key > ar[mid+1])
//            //        {
//            //            return mid + 1;
//            //        }
//            //        else if (key < ar[mid])
//            //        {
//            //            start = mid + 1;
//            //        }
//            //        else if (key > ar[mid])
//            //        {
//            //            end = mid - 1;
//            //        }
//            //    }
//            //    return -1;
//            //}

//            //---------------------------------------------------------------------------------------//

//            List<int> indexList = new List<int>();

//            var sortedList = ranked.Distinct().ToList();

//            int j = sortedList.Count - 1;

//            for (int i = 0; i < player.Count; i++)
//            {
//                while(i >= 0)
//                {
//                    if (player[i] >= sortedList[j])
//                    {
//                        if(j <= 0)
//                        {
//                            break;
//                        }
//                        else
//                        {
//                            j--;
//                        }
//                    }
//                    else
//                    {
//                        indexList.Add(j+2);
//                        break;
//                    }
//                }
//                if(i < 0 )
//                {
//                    indexList.Add(1);
//                }
//            }

//            return indexList;
//        }
//    }

//    class Solution
//    {
//        public static void Main(string[] args)
//        {
//            int rankedCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> ranked = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(rankedTemp => Convert.ToInt32(rankedTemp)).ToList();

//            int playerCount = Convert.ToInt32(Console.ReadLine().Trim());

//            List<int> player = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(playerTemp => Convert.ToInt32(playerTemp)).ToList();

//            List<int> result = ClimbingLeaderboard.climbingLeaderboard(ranked, player);

//            Console.WriteLine(result);

//        }
//    }
//}
