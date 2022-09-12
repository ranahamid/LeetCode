using System.Numerics;
using System.Runtime.Intrinsics;
using System.Text;



int intTemp = Convert.ToInt32(Console.ReadLine());
for (int index = 0; index < intTemp; index++)
{
    int n = Convert.ToInt32(Console.ReadLine());

    //Read line, and split it by whitespace into an array of strings
    string[] tokens = Console.ReadLine().Split();
    List<int> array1 = new List<int>();
    int i = 0;
    for (i = 0; i < n; i++)
    {
        array1.Add(int.Parse(tokens[i]));
    }

    tokens = Console.ReadLine().Split();
    List<int> array2 = new List<int>();
    for (i = 0; i < n; i++)
    {
        array2.Add(int.Parse(tokens[i]));
    }
    List<int> array3 = new List<int>();
    for (i = 0; i < n; i++)
    {
        array3.Add(array2[i] - array1[i]);
    }
    array3.Sort();
    i = 0;
    int j = array3.Count - 1;
    int counter = 0;
    while (i < j)
    {
        if (array3[i] + array3[j] < 0)
        {
            i++;
            continue;
        }

        counter++;
        i++;
        j--;

    }

    Console.WriteLine(counter);

}




public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
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
