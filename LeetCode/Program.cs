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

            var res = new int[] { 0 };
            Console.Write(SubsetsWithDup(res));
            //Merge(res, 3, res2, 3);
            Console.ReadKey();
        }

        public static  IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            int[] output = new int[0];
            List<IList<int>> list = new List<IList<int>>();
            list.Add(new List<int>()); 
            Dictionary<int, string > dictionary = new Dictionary<int, string >();
            var counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    list.Add(new List<int> { nums[i] });
                    dictionary.Add(counter++, ConvertToStringFromIntCommas(new List<int> { nums[i] }));
                }
                else
                {
                    var existingItems = list.Select(x => x.ToList()).ToList();
                    foreach (var item in existingItems)
                    {
                        item.Add(nums[i]);
                    }
                    foreach (var item in existingItems)
                    {
                        var st = ConvertToStringFromIntCommas(item);
                        if (dictionary.ContainsValue(st))
                        {

                        }
                        else
                        {
                            list.Add(item);
                            dictionary.Add(counter++, st);
                        }
                        
                    }
                      
                }
            }
             
            Console.WriteLine(list.Count());
            var result = list.Select(x => (IList<int>)x).ToList();
            return result;
        }

        public static  string ConvertToStringFromIntCommas(List<int> names)
        {
            if (names != null && names.Count > 0)
            {
                var result = string.Join(",", names.ToArray());
                return result;
            }

            return "";
        }

    }

}
