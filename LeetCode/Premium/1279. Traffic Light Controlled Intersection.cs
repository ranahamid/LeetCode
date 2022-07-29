using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    /// <summary>
    /// out of memory
    /// </summary>
    public class TrafficLight
    {
        private object SyncRoot = new object();
        private int roadIdNum;
        public TrafficLight()
        {
            roadIdNum = 1;
        }

        public void CarArrived(
            int carId,         // ID of the car
            int roadId,        // ID of the road the car travels on. Can be 1 (road A) or 2 (road B)
            int direction,     // Direction of the car
            Action turnGreen,  // Use turnGreen() to turn light to green on current road
            Action crossCar    // Use crossCar() to make car cross the intersection
        )
        {
            lock (SyncRoot)
            {

                if (roadId == roadIdNum)
                {
                    crossCar();
                }
                else
                {
                    roadIdNum = roadId;
                    turnGreen();
                    crossCar();

                }
            }
        }
    }
}
