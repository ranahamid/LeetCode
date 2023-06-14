//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LeetCode.Z
//{

//    class Street
//    {
//        public Street(int[] doors);
//        public void OpenDoor();
//        public void CloseDoor();
//        public bool IsDoorOpen();
//        public void MoveRight();
//        public void MoveLeft();
//    }
//    internal class _2728
//    {
//        public class Solution
//        {
//            public int HouseCount(Street street, int k)
//            {
//                for (int i = 0; i < k; i++)
//                {
//                    if (street.IsDoorOpen())
//                    {
//                        street.CloseDoor();
//                    }
//                    street.MoveRight();
//                }


//                street.OpenDoor();
//                street.MoveRight();

//                int ans = 1;
//                while (!street.IsDoorOpen())
//                {
//                    ans++;
//                    street.MoveRight();
//                }
//                return ans;
//            }
//        }
//    }
