namespace LeetCode
{
    /// <summary>
    /// Runtime: 566 ms, faster than 13.17% of C# online submissions for Design HashSet.
    /// Memory Usage: 62.6 MB, less than 35.59% of C# online submissions for Design HashSet.
    /// </summary>
    public class MyHashSet
    {
        private bool[] arr;
        public MyHashSet()
        {
            arr = new bool[1000001];
        }
    
        public void Add(int key)
        {
            arr[key] = true;
        }
    
        public void Remove(int key) {
            arr[key] = false;
        }
    
        public bool Contains(int key) {
            return arr[key] ;
        }
    }
}