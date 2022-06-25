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
            int[][] nums = new int[2][]{
                new int[2]{1,1},
                new int[2]{0,0},
            };

            int[][] nums1 = new int[2][]{
                new int[2]{0,1},
                new int[2]{1,1},
            };
            //ListNode six = new ListNode(4);
            //ListNode five = new ListNode(6, six);
            //ListNode list2 = new ListNode(5, five);


            //ListNode fifteen = new ListNode(0);
            //ListNode fourtenn = new ListNode(0, fifteen);
            //ListNode thirteen = new ListNode(0, fourtenn);
            //ListNode twelve = new ListNode(0, thirteen);
            //ListNode eleven = new ListNode(0, twelve);
            //ListNode ten = new ListNode(0, eleven);
            //ListNode nine = new ListNode(1, ten);
            //ListNode eight = new ListNode(1, nine);
            //ListNode seven = new ListNode(1, eight);
            //ListNode six = new ListNode(0, seven);
            //ListNode five = new ListNode(0, six);
            //ListNode four = new ListNode(1, five);
            //ListNode three = new ListNode(0, four);
            //ListNode two = new ListNode(0, three);
            //ListNode list1 = new ListNode(1, two);


            //ListNode list1 = new ListNode(5);

            //Console.Write(MyAtoi2("words and 987"));
            //Console.Write(MyAtoi2("-91283472332"));
            //Console.Write(MyAtoi("4193 with words"));
            var paths = new List<IList<string>>()
            {
                new List<string>() { "London", "New York" },
                  new List<string>() { "New York","Lima" },
                    new List<string>() { "Lima","Sao Paulo" },
            };
            var res = new string[] { "pay", "attention", "practice", "attend" };
            var res1 = new int[] {2443, 5845, 3267, 2030, 4863, 2214, 3354, 6565, 3996, 9130, 3273, 2731, 8761, 8719, 324, 651, 6110, 1702, 2439, 2015, 6114, 529, 8145, 3762, 446, 3735, 6626, 6137, 7999, 9736, 4223, 3075, 474, 6715, 4231, 3404, 3699, 2565, 1782, 2205, 1842, 8700, 5727, 160, 707, 4350, 7398, 3126, 9671, 2715, 8448, 4194, 1837, 6727, 7955, 2675, 7443, 5544, 1321, 6580, 5686, 7029, 5640, 76, 3397, 6479, 4433, 8955, 9990, 2302, 2135, 3929, 7562, 7537, 3633, 8468, 3582, 6406, 5562, 209, 6330, 1586, 3596, 2392, 7267, 8412, 6915, 4148, 6530, 4893, 624, 9649, 9720, 187, 3720, 1397, 4747, 2488, 6266, 4535, 349, 3768, 7683, 2624, 3622, 363, 4915, 6036, 7562, 1118, 8292, 7017, 5824, 3163, 1742, 4909, 8259, 9726, 6826, 5407, 9309, 3896, 4785, 1615, 4916, 775, 1106, 3412, 50, 5928, 6260, 9141, 4913, 711, 3218, 9140, 6363, 2545, 5438, 8034, 6031, 3945, 3232, 9992, 7337, 1951, 3888, 8000, 4137, 3193, 7440, 4774, 6367, 7282, 8598, 8387, 4279, 3594, 3350, 8227, 5896, 8133, 6199, 2933, 1942, 9025, 2581, 8, 3963, 5314, 6416, 33, 9836, 5523, 9685, 3058, 9328, 1964, 286, 7915, 540, 1121, 8425, 7044, 2726, 5604, 6485, 6498, 6598, 9121, 7174, 4436, 611, 1385, 1392, 7177, 3775, 9092, 1820, 454, 3318, 397, 3385, 9748, 9492, 2845, 1340, 3273, 2465, 2604, 1279, 996, 8635, 8839, 9676, 8032, 4050, 5256, 8273, 6897, 8119, 1243, 3783, 3555, 986, 5971, 4776, 588, 5240, 4960, 381, 56, 6062, 4191, 3269, 1222, 8230, 2998, 8144, 5228, 8397, 8365, 5365, 5883, 7894, 7474, 6388, 8716, 1128, 9853, 9601, 9310, 8444, 7548, 4170, 4827, 7295, 5346, 7708, 2338, 5220, 4852, 7752, 3892, 3550, 5701, 9289, 8572, 5352, 508, 3849, 4626, 4289, 8031, 8746, 6140, 7748, 2507, 6994, 9592, 7159, 2322, 6385, 365, 9780, 5730, 5322, 4367, 3986, 3199, 7570, 9282, 2684, 9449, 4820, 703, 5472, 9229, 2278, 483, 3694, 7128, 4667, 7948, 717, 282, 4323, 8396, 4874, 6990, 4792, 2893, 5471, 9231, 4707, 1797, 5506, 8798, 7801, 3536, 5572, 9964, 3968, 2008, 224, 1680, 6724, 994};
            
            
            Console.WriteLine(StrongPasswordCheckerII("1aB!"));        
            Console.ReadKey();
        }



       































































    }


}
