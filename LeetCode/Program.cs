using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{


 

    internal class Program
    {
        static void Main(string[] args)
        {
            //int[][] nums = new int[3][]{
            //    new int[4]{1,3, 5,7},
            //    new int[4]{10,11,16,20},
            //    new int[4]{23,30,34,60}
            //};
            //ListNode six = new ListNode(4);
            //ListNode five = new ListNode(6, six);
            //ListNode list2 = new ListNode(5, five);


            //ListNode three = new ListNode(3);
            //ListNode two = new ListNode(4, three);
            //ListNode list1 = new ListNode(2, two);


           

            //ListNode list1 = new ListNode(5);

            //Console.Write(MyAtoi2("words and 987"));
            //Console.Write(MyAtoi2("-91283472332"));
            //Console.Write(MyAtoi("4193 with words"));

            var res = new int [] { 2, 3, 5, 1, 3 };

            Console.WriteLine(KidsWithCandies(res,3));

            Console.WriteLine("Hello");
            Console.ReadKey();
        }


        

    }
    /// <summary>
    /// Runtime: 242 ms, faster than 46.67% of C# online submissions for Design Parking System.
    /// Memory Usage: 46.7 MB, less than 39.09% of C# online submissions for Design Parking System.
    /// </summary>
    public class ParkingSystem
    {
        private int bigCar=0;
        private int mediumCar = 0;
        private int smallCar = 0;
        public ParkingSystem(int big, int medium, int small)
        {
            bigCar=big;
            mediumCar=medium;
            smallCar=small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1 && bigCar >0)
            {
                bigCar--;
                return true;
            }
            if (carType == 2 && mediumCar > 0)
            {
                mediumCar--;
                return true;
            }
            if (carType == 3 && smallCar >0)
            {
                smallCar--;
                return true;
            }
            return false;
        }
    }

}
