using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{

    public class FoodRatings
    {
        public Dictionary<string, int> FoodRatingsDic = new Dictionary<string, int>();
        public Dictionary<string, string> FoodCuisinesDic = new Dictionary<string, string>();
        public Dictionary<string, SortedSet<(int, string)>> dic = new Dictionary<string, SortedSet<(int, string)>>();

        /// <summary>
        /// Runtime: 1057 ms, faster than 100.00% of C# online submissions for Design a Food Rating System.
        /// Memory Usage: 110.3 MB, less than 100.00% of C# online submissions for Design a Food Rating System.
        /// </summary>
        /// <param name="foods"></param>
        /// <param name="cuisines"></param>
        /// <param name="ratings"></param>

        public FoodRatings(string[] foods, string[] cuisines, int[] ratings)
        {
            for (int i = 0; i < foods.Length; i++)
            {
                var foodName = foods[i];
                var cuisinesName = cuisines[i];
                var rating = ratings[i];

                FoodCuisinesDic.Add(foodName, cuisinesName);
                FoodRatingsDic.Add(foodName, rating);
                if (!dic.ContainsKey(cuisinesName))
                    dic.Add(cuisinesName, new SortedSet<(int, string)>());
                dic[cuisinesName].Add((-rating, foodName));

            }

        }
        public void ChangeRating(string food, int newRating)
        {
            var oldRating = FoodRatingsDic[food];
            var oldCusinge = FoodCuisinesDic[food];

            FoodRatingsDic[food] = newRating;

            dic[oldCusinge].Remove((-oldRating, food));
            dic[oldCusinge].Add((-newRating, food));
        }

        public string HighestRated(string cuisine)
        {

            return dic[cuisine].Min.Item2;
        }
    }

    #region TLE



    public class Food
    {
        public string FoodName { get; set; }
        public string CuisinesName { get; set; }
        public int Rating { get; set; }

    }
    public class FoodRatings_TLE
    {
        public List<Food> Foods = new List<Food>();
        public FoodRatings_TLE(string[] foods, string[] cuisines, int[] ratings)
        {
            for (int i = 0; i < foods.Length; i++)
            {
                Food food = new Food();
                food.FoodName = foods[i];
                food.CuisinesName = cuisines[i];
                food.Rating = ratings[i];

                Foods.Add(food);
            }
        }
        public void ChangeRating(string food, int newRating)
        {
            var foodObj = Foods.Where(x => x.FoodName == food).FirstOrDefault();
            if (foodObj != null)
            {
                foodObj.Rating = newRating;
            }
        }

        public string HighestRated(string cuisine)
        {

            var foodObj = Foods.Where(x => x.CuisinesName == cuisine).OrderByDescending(x => x.Rating).ThenBy(x => x.FoodName).FirstOrDefault();
            if (foodObj != null)
            {
                return foodObj.FoodName;
            }
            return string.Empty;
        }
    }



    #endregion



}
