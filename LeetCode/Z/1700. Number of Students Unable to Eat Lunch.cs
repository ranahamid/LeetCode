using System.Collections.Generic;

namespace LeetCode.Z
{
    public class _1700__Number_of_Students_Unable_to_Eat_Lunch
    {
        /// <summary>
        /// Runtime: 117 ms, faster than 49.44% of C# online submissions for Number of Students Unable to Eat Lunch.
        /// Memory Usage: 36.9 MB, less than 86.52% of C# online submissions for Number of Students Unable to Eat Lunch.
        /// </summary>
        /// <param name="students"></param>
        /// <param name="sandwiches"></param>
        /// <returns></returns>
        public static int CountStudents(int[] students, int[] sandwiches)
        {
            Queue<int> std = new Queue<int>(students);
            Queue<int> sand = new Queue<int>(sandwiches);

            var canEat = 0;
            var counter = 0;
            while (true)
            {
                if (std.Count == 0 || sand.Count == 0)
                    break;
                if (std.Peek() == sand.Peek())
                {
                    canEat++;
                    std.Dequeue();
                    sand.Dequeue();
                    counter = 0;
                }
                else
                {
                    var s = std.Dequeue();
                    std.Enqueue(s);
                    counter++;
                    if (counter == students.Length)
                        break;
                }
            }
            return students.Length - canEat;
        }

    }
}