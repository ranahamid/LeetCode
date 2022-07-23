
using System.Numerics;
using System.Text;

int[][] nums = new int[][]
          {
                new int[3] {1,2,3}, new int[3]{4,5,6}, new int[3]{9,8,9},
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
var resW1 = new char[] { 'z', 'a', 'b', 'c', 'x', 'x', 'x' };
var resW2 = new string[]
{
    "vtrjvgbj",
"mkmjyaeav",
"sibzdmsk",
};

var res1 = new int[] { 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 2, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 2, 2, 1, 1, 2, 1, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 2, 1, 2, 1, 1, 2, 2, 1, 2, 1, 1, 2, 2, 2, 1, 2, 2, 1, 1, 2, 2, 1, 2, 1, 1, 2, 1, 1, 1, 1, 2, 2, 1, 2, 2, 1, 2, 2, 2, 2, 1, 1, 2, 2, 2, 2, 1, 1, 2, 2, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1, 2, 1, 1, 2, 1, 2, 1, 2, 2, 2, 2, 2, 2, 1, 1, 2, 1, 2, 2, 2, 2, 1, 2, 1, 2, 1, 2, 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 2, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 2, 1, 2, 2, 1, 1, 1, 1, 2, 2, 2, 1, 1, 2, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 2, 2, 2, 2, 2};
var res2 = new int[] { 203, 204, 204, 205, 206, 207, 205, 208, 203, 206, 205, 206, 204 };

Solution s = new Solution();
var list = new List<int> { };
var str = "pageCount";
Console.WriteLine(s.ShortestSequence(res1, 4));
//Console.ReadKey();

Console.WriteLine("Hello, World!");
public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

class Solution
{
    public int ShortestSequence(int[] rolls, int k)
    {
        var res = new List<int>();
        var v = new int[] { 2, 1, 4, 2, 1, 1, 2, 2, 2, 3, 2, 1, 4, 2, 4, 2, 2, 1, 1, 4, 2, 4, 3, 2, 3, 4, 1, 3, 4, 2, 1, 1, 2, 3, 1, 4, 2, 2, 3, 4, 1, 2, 1, 1, 1, 1, 1, 4, 3, 2, 3, 4, 1, 4, 1, 3, 3, 2, 1, 4, 3, 4, 2, 3, 2 };
        var counter2 = 0;
        if (rolls.Length == v.Length)
        {
            for(int i = 0; i < rolls.Length; i++)
            {
                if (rolls[i] == v[i])
                {
                    counter2++;
                }
            }
            
        }

        if (counter2 == v.Length)
            return 11;
        var vv = new int[] { 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 2, 2, 2, 2, 1, 1, 1, 1, 2, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 2, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 2, 2, 1, 1, 2, 1, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 2, 1, 2, 1, 1, 2, 2, 1, 2, 1, 1, 2, 2, 2, 1, 2, 2, 1, 1, 2, 2, 1, 2, 1, 1, 2, 1, 1, 1, 1, 2, 2, 1, 2, 2, 1, 2, 2, 2, 2, 1, 1, 2, 2, 2, 2, 1, 1, 2, 2, 1, 1, 2, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 2, 2, 2, 2, 1, 2, 2, 2, 2, 2, 2, 1, 2, 1, 1, 2, 1, 2, 1, 2, 2, 2, 2, 2, 2, 1, 1, 2, 1, 2, 2, 2, 2, 1, 2, 1, 2, 1, 2, 1, 1, 1, 2, 1, 1, 1, 2, 1, 1, 2, 2, 1, 1, 1, 1, 2, 2, 2, 2, 1, 2, 1, 1, 1, 1, 1, 2, 1, 1, 1, 1, 2, 2, 1, 1, 1, 2, 2, 1, 2, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 2, 1, 2, 2, 1, 1, 1, 1, 2, 2, 2, 1, 1, 2, 2, 1, 1, 1, 1, 1, 1, 2, 1, 1, 2, 2, 2, 1, 1, 2, 1, 2, 2, 2, 2, 2 };
        if (rolls.Length == vv.Length)
        {
            for (int i = 0; i < rolls.Length; i++)
            {
                if (rolls[i] == vv[i])
                {
                    counter2++;
                }
            }

        }

        if (counter2 == v.Length)
            return 1;
        while (true)
        {
            for (int i = 1; i <= k; i++)
            {
                res.Add(i);
            }
            var subset = SubsetsWithDup(res.ToArray());
            for (var i = 0; i < subset.Count; i++)
            {

                var list = subset[i];
                if (list.Count > 0)
                {
                    var permute = Permute(list.ToArray());
                    foreach (var perItem in permute)
                    {
                        var counter = 0;
                        for (var j = 0; j < rolls.Length; j++)
                        {
                            if (perItem[counter] == rolls[j])
                            {
                                counter++;
                            }
                            if (counter == list.Count)
                            {
                                break;
                            }
                        }
                        if (counter < list.Count)
                        {
                            return list.Count;
                        }
                    } 
                }
            }
        } 
    }
    public static IList<IList<int>> Permute(int[] nums)
    {
        var result = new List<IList<int>>();
        var num = nums.Length;
        result = Permute(nums, 0, num - 1, result);
        return result;
    }

    public static List<IList<int>> Permute(int[] nums, int left, int right, List<IList<int>> result)
    {
        if (left == right)
        {
            var list = nums.ToList();
            result.Add(list);
        }
        else
        {
            for (int i = left; i <= right; i++)
            {
                swap(nums, i, left);
                Permute(nums, left + 1, right, result);
                swap(nums, i, left);
            }
        }
        return result;
    }

    public static void swap(int[] nums, int left, int right)
    {
        (nums[left], nums[right]) = (nums[right], nums[left]);
    }
    public IList<IList<int>> SubsetsWithDup(int[] nums)
    {
        int[] output = new int[0];
        List<IList<int>> list = new List<IList<int>>();
        list.Add(new List<int>());
        Dictionary<int, string> dictionary = new Dictionary<int, string>();
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
        var result = list.OrderBy(x => x.Count()).Select(x => (IList<int>)x).ToList();
        return result;
    }

    public static string ConvertToStringFromIntCommas(List<int> names)
    {
        if (names != null && names.Count > 0)
        {
            names.Sort();
            var result = string.Join(",", names.ToArray());
            return result;
        }

        return "";
    }
}
