//using System;


//namespace LeetCode
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int intTemp = Convert.ToInt32(Console.ReadLine());
//            for (int index = 0; index < intTemp; index++)
//            {
//                var n = Convert.ToInt32(Console.ReadLine());
//                bool isFound = false;
//                for (int i = 0; i < n; i++)
//                {
//                    for (int j = 0; j < n; j++)
//                    {
//                        for (int k = n; k >= 0; k--)
//                        {
//                            if ((i ^ j) + (j ^ k) + (j ^ k) == n)
//                            {
//                                Console.WriteLine($"{i} {j} {k}");
//                                isFound = true;
//                            }
//                            if (isFound)
//                                break;
//                        }
//                        if (isFound)
//                            break;
//                    }
//                    if (isFound)
//                        break;
//                }
//                if (!isFound)
//                    Console.WriteLine(-1);
//            }
//        } 
//    }
//}


//TLE
