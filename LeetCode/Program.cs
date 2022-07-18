using System.Text;

int[][] nums = new int[][]
          {
                new int[2] {9,4}, new int[2]{6,1}, new int[2]{3,8}, new int[2]{12,9}, new int[2]{11,4}, new int[2]{4,9}, new int[2]{2,7},
                 new int[2]{10,3}, new int[2]{13,1}, new int[2]{13,1}, new int[2]{6,1}, new int[2]{5,10}
          };

int[][] nums1 = new int[4][]
{
                new int[2] { 1, 1 },
                new int[2] { 2,3 },

                new int[2] { 4,2 },
                new int[2] { 1,2 },
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
  "102","473","251","814"
};

var res1 = new int[] { 2, 7, 11, 15 };
var res2 = new int[] { 8, 2, 6, 10 };
Solution solution = new Solution();
Console.WriteLine(solution.SmallestTrimmedNumbers(resW2, nums1));



Console.WriteLine("END");
Console.ReadKey();
Console.WriteLine("Hello, World!");

public class Solution
{ 
    public int[] SmallestTrimmedNumbers(string[] nums, int[][] queries)
    {
        var result=new List<int>();
        for(int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i].Trim();
        }
        foreach(var item in queries)
        {
            var listNum=new List<long>();
            for (int i = 0; i < nums.Length; i++)
            {
                var data= nums[i].Substring(nums[i].Length - item[1]);
                if(long.TryParse(data,out var val))
                {
                    listNum.Add(val);
                } 
            }
            //smallest number 2,3,1,4
            var index = GetSmallestElement(listNum, item[0]);
            result.Add(index);
        }
        return result.ToArray();
    }
    public static int GetSmallestElement(List<long> listNum, int nTh)
    {
        var result = -1;

        return result;
    }
}