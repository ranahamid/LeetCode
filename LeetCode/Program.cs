using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] nums = new int[3][]{
            //    new int[4]{1,3, 5,7},
            //    new int[4]{10,11,16,20},
            //    new int[4]{23,30,34,60}
            //};
            //ListNode six = new ListNode(4);
            //ListNode five = new ListNode(6, six);
            //ListNode list2 = new ListNode(5, five);


            //ListNode three = new ListNode(3);
            //ListNode two = new ListNode(4, three);
            //ListNode list1 = new ListNode(2, two);


            //ListNode six = new ListNode(4);
            //ListNode five = new ListNode(2, six);
            //ListNode list2 = new ListNode(1, five);


            //ListNode list1 = new ListNode(5);

            //Console.Write(MyAtoi2("words and 987"));
            //Console.Write(MyAtoi2("-91283472332"));
            //Console.Write(MyAtoi("4193 with words"));

            var res = new int[] { };
            Console.Write(RomanToInt("MCMXCIV"));
            //Merge(res, 3, res2, 3);
            Console.ReadKey();
        }
        /// <summary>
        /// Runtime: 124 ms, faster than 26.16% of C# online submissions for Roman to Integer.
        /// Memory Usage: 36.7 MB, less than 79.61% of C# online submissions for Roman to Integer.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static  int RomanToInt(string s)
        {
            var result = 0;
            var chars=s.ToCharArray();
            for(int i= chars.Length-1; i>=0; i--)
            {
                if (chars[i] == 'I')
                    result += result >=5 ? -1 : 1;

                if (chars[i] == 'V')
                    result += 5;

                if (chars[i] == 'X')
                    result += 10 * (result >=50 ? -1 : 1);

                if (chars[i] == 'L')
                    result += 50;

                if (chars[i] == 'C')
                    result += 100 * (result >=500 ? -1 : 1);

                if (chars[i] == 'D')
                    result += 500;

                if (chars[i] == 'M')
                    result += 1000;
            }
            return result;
        }



    }

}
