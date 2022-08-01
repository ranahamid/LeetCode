using System.Collections.Generic;
using System.Numerics;
using System.Text;

int[][] nums = new int[][]
          {
                new int[2] {1,2}, new int[2]{2,3}, new int[2]{3,4},
                    new int[2] {4,5}, new int[2]{5,6}, new int[2]{6,7},
          };

int[][] nums1 = new int[29][]
{
new int[2] {22,19},new int[2] {16,17},new int[2] {10,7},new int[2] {27,16},new int[2] {9,9},new int[2] {21,4},new int[2] {24,2},new int[2] {12,11},new int[2] {2,5},new int[2] {24,12},new int[2] {25,7},new int[2] {7,13},new int[2] {14,9},new int[2] {23,15},new int[2] {18,17},new int[2] {22,16},new int[2] {4,14},new int[2] {14,17},new int[2] {25,11},new int[2] {12,16},new int[2] {29,3},new int[2] {22,11},new int[2] {29,2},new int[2] {24,2},new int[2] {24,15},new int[2] {7,14},new int[2] {7,3},new int[2] {7,14},new int[2] {1,3}
};


#region node

//ListNode eig = new ListNode(3);
//TreeNode sev = new TreeNode(4);
//TreeNode six = new TreeNode(3);
//TreeNode five = new TreeNode(2,null,sev);
//TreeNode list2 = new TreeNode(1, five, six);

//ListNode fifteen = new ListNode(0);
//ListNode fourtenn = new ListNode(0, fifteen);

//ListNode thirteen = new ListNode(0);
//ListNode twelve = new ListNode(5, thirteen);
//ListNode eleven = new ListNode(5, twelve);
//ListNode ten = new ListNode(2, eleven);
//ListNode nine = new ListNode(4, ten);
//ListNode eight = new ListNode(9, nine);
//ListNode seven = new ListNode(7, eight);
//ListNode six = new ListNode(1, seven);
//ListNode five = new ListNode(8, six);
//ListNode four = new ListNode(6, five);
//ListNode three = new ListNode(2, four);
//ListNode two = new ListNode(0, three);
//ListNode list1 = new ListNode(3, two);

#endregion

var paths = new List<IList<string>>()
            {
                new List<string>() { "London", "New York" },
                new List<string>() { "New York", "Lima" },
                new List<string>() { "Lima", "Sao Paulo" },
            };
var resW1 = new string[] { "lo", "eo" };
var resW2 = new string[]
{
"leetcode"
};

var res1 = new int[] { 1, 2, 2, 3, 1 };
var res2 = new int[] { 1, 2, 3, 4 };

Solution solution = new Solution();
Console.WriteLine(solution.FindShortestSubArray(res1));
public class Solution
{
    public int FindShortestSubArray(int[] nums)
    {
        var dic = GetFrequency(nums);
        var maxNum = dic.Select(x => x.Value).Max();
        var maxValues = dic.Where(x => x.Value == maxNum).OrderByDescending(x => x.Key).Select(x => x.Key).ToList();      

        var minVal = Int32.MaxValue;

        foreach (var max in maxValues)
        {
            var first = Int32.MinValue;
            var last = Int32.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == max)
                {
                    if (first == Int32.MinValue)
                    {
                        first = i;
                        last = i;
                    }
                    last = i;
                }
             
            }
            minVal = Math.Min(minVal, last - first + 1);
        }
        return minVal;
    }
    public static Dictionary<int, int> GetFrequency(int[] nums)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (map.ContainsKey(nums[i]))
            {
                map[nums[i]]++;
            }
            else
            {
                map[nums[i]] = 1;
            }
        }
        return map;
    }
}






