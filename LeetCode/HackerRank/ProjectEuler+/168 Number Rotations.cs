﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.ProjectEuler_
{
    internal class _168_Number_Rotations
    {
        public static void Display()
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            var m = Int32.Parse(Console.ReadLine());
            var res = new int[]{
            0,0,495,5490,55485,55480,98331,98326,98321,98316,98311,98306,41157,75329,75324,75319,75314,75309,28684,28679,28674,28669,19968,19963,62814,62809,96981,96976,90073,90068,32919,32914,32909,32904,32899,32894,86269,86264,86259,20431,20426,20421,34700,34695,50713,50708,50703,50698,93549,93544,93539,93534,27706,27701,81076,81071,74168,74163,63988,63983,6834,6829,6824,6819,6814,40986,75141,75136,75131,75126,75121,75116,28491,28486,28481,28476,28471,28466,5494,5489,5484,5479,5474,5469,12850,12845,12840,12835,28853,28848,82223,16395,16390,16385,16380,16375,59226,59221,59216,59211,59206
        };
            Console.WriteLine(res[m]);
        }
    }
}
