using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /// <summary>
    /// Runtime: 242 ms, faster than 46.67% of C# online submissions for Design Parking System.
    /// Memory Usage: 46.7 MB, less than 39.09% of C# online submissions for Design Parking System.
    /// </summary>
    public class ParkingSystem
    {
        private int bigCar = 0;
        private int mediumCar = 0;
        private int smallCar = 0;
        public ParkingSystem(int big, int medium, int small)
        {
            bigCar = big;
            mediumCar = medium;
            smallCar = small;
        }

        public bool AddCar(int carType)
        {
            if (carType == 1 && bigCar > 0)
            {
                bigCar--;
                return true;
            }
            if (carType == 2 && mediumCar > 0)
            {
                mediumCar--;
                return true;
            }
            if (carType == 3 && smallCar > 0)
            {
                smallCar--;
                return true;
            }
            return false;
        }
    }
}
