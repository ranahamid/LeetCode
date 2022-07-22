
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
   "bob", "hit"
};

var res1 = new int[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 };
var res2 = new int[] { 3, 6, 2, 3 };

Solution s = new Solution();
var list = new List<int> { 3, 9, 2, 5, 2, 19 };
var str = "pageCount";
Console.WriteLine(Solution.CustomSortString("cba", "abcd"));
//Console.ReadKey();

Console.WriteLine("Hello, World!");


class Solution
{
    
    public static int flippingMatrix(List<List<int>> matrix)
    {
        int n = matrix.Count / 2;
        int[] arrayStorage = new int[4];
        List<int> result = new List<int>();

        // There would only be 3 other points that can be flipped into a specific point in the upper-left quadrant.
        // So for  each point in the upper-left quadrant, we have to compare 4 points
        for (int x = 0; x < n; x++)
            for (int y = 0; y < n; y++)
            {
                arrayStorage[0] = matrix[x][y];
                arrayStorage[1] = matrix[2 * n - 1 - x][y];
                arrayStorage[2] = matrix[x][2 * n - 1 - y];
                arrayStorage[3] = matrix[2 * n - 1 - x][2 * n - 1 - y];

                result.Add(arrayStorage.Max());
            }

        return result.Sum();
    }


}