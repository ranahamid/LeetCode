using System.Numerics;
using System.Text;

int[][] nums = new int[][]
          {
                new int[2] {9,4}, new int[2]{6,1}, new int[2]{3,8}, new int[2]{12,9}, new int[2]{11,4}, new int[2]{4,9}, new int[2]{2,7},
                 new int[2]{10,3}, new int[2]{13,1}, new int[2]{13,1}, new int[2]{6,1}, new int[2]{5,10}
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
 "8331019423839036903","2215783497319194533","3244863164120264914","2723857887888553250","1069645833408356268","3799170975306313470","3300849027471666477","8896469467436127218","9595084104356246555","4601424390471226348","2777623221871959897","2660664761264162910","4830224756337097853","2239177595019260973","5704104074606481922","5158962343348888307","4957489822885409209","5533958195540658313","6712811206814843536","9775503283462317096","1975389311819120035","1292135637676764140","9838972337538013522","7609294617007602893","0186572359592634437","9236053726818307461","7264888050655615544","4990296885039745852","1417868535147288083"
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
        var result = new List<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = nums[i].Trim();
        }
        foreach (var item in queries)
        {
            var listNum = new List<BigInteger>();
            for (int i = 0; i < nums.Length; i++)
            {
                var data = nums[i].Substring(nums[i].Length - item[1]);
                if (BigInteger.TryParse(data, out var val))
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
    public static int GetSmallestElement(List<BigInteger> listNum, int nTh)
    {
        var sorted = new List<BigInteger>();
        foreach (var item in listNum)
        {
            sorted.Add(item);
        }
        sorted.Sort();
        var temp = new List<BigInteger>();
        for (int i = 0; i < nTh - 1; i++)
        {
            temp.Add(sorted[i]);
        }

        for (int i = 0; i < listNum.Count; i++)
        {
            var a = listNum[i];
            var b = sorted[nTh - 1];
            if (a == b)
            {
                if (temp.Contains(a))
                {
                    temp.Remove(a);
                    continue;
                }
                return i;
            }
        }
        return -1;
    }
}