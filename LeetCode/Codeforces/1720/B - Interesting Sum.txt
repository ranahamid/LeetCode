using System.Numerics;
using System.Text;



int intTemp = Convert.ToInt32(Console.ReadLine());
for (int index = 0; index < intTemp; index++)
{
    int n = Convert.ToInt32(Console.ReadLine());

    //Read line, and split it by whitespace into an array of strings
    string[] tokens = Console.ReadLine().Split();
    List<int> array = new List<int>();
    for (int i = 0; i < n; i++)
    {
        array.Add(int.Parse(tokens[i]));
    }
    array.Sort();
    var res = array[n - 1] + array[n - 2] - array[0] - array[1];
    Console.WriteLine(res);
}