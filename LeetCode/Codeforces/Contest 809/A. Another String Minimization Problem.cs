//https://codeforces.com/contest/1706/problem/A
int intTemp = Convert.ToInt32(Console.ReadLine());
for (int index = 0; index < intTemp; index++)
{
    string[] numbers = Console.ReadLine().Split();
    int n = int.Parse(numbers[0]);
    int m = int.Parse(numbers[1]);

    string[] seq = Console.ReadLine().Split();
    var listOfSeq = new List<int>();
    for (int i = 0; i < n; i++)
    {
        listOfSeq.Add(int.Parse(seq[i]));
    }
    var result = new char[m];
    for (int i = 0; i < m; i++)
    {
        result[i] = 'B';
    }
    var counter = 0;
    foreach (var item in listOfSeq)
    {
        var len = item;
        var temp = m + 1 - item;
        if (temp < m)
        {
            len = Math.Min(len, temp);
        }
        result[len - 1] = 'A';
    }
    Console.WriteLine(result);
}