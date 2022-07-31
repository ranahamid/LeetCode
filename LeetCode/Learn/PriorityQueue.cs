using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Learn
{
    #region queue
    public class HospitalQueueComparer : IComparer<Patient>
    {
        public int Compare(Patient x, Patient y)
        {
            if (x.Age == y.Age)
                return 0;
            if (x.Age > y.Age)
                return -1;
            else
                return 1;
        }
    }
    public class Patient
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public Patient(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
    #endregion

    public class QueueLearn
    {
        public static void Display()
        {


            #region priority queue-1


            var dataList = new List<(Patient, int)>()
{
    (new ("Sarah",23),4),
      (new("Joe", 50), 2),
    (new("Elizabeth", 60), 1),
    (new("Natalie", 16), 5),
    (new("Angie", 25), 3),
};

            var hosQueue = new PriorityQueue<Patient, int>(dataList);

            hosQueue.Clear();

            hosQueue.Enqueue(new Patient("Roy", 66), 99);
            while (hosQueue.Count > 0)
                Console.WriteLine(hosQueue.Dequeue().Name);
            #endregion
            #region queue-2
            Console.WriteLine("Hello, World!");
            var patients = new List<Patient>()
{
    new("Sarah", 23),
    new("Joe", 50),
    new("Elizabeth", 60),
    new("Natalie", 16),
    new("Angie", 25),
};
            var hosCustQUeue = new PriorityQueue<Patient, Patient>(new HospitalQueueComparer());
            patients.ForEach(x =>
            {
                hosCustQUeue.Enqueue(x, x);

            });

            while (hosCustQUeue.Count > 0)
                Console.WriteLine(hosCustQUeue.Dequeue().Name);
            #endregion

        }
    }

}