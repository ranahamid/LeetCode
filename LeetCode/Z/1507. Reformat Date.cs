namespace LeetCode.Z
{
    public class _1507__Reformat_Date
    {
        /// <summary>
        /// Runtime: 126 ms, faster than 26.98% of C# online submissions for Reformat Date.
        /// Memory Usage: 35.7 MB, less than 65.08% of C# online submissions for Reformat Date.
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static string ReformatDate(string date)
        {
            var dates = date.Split(' ');
            var year = dates[2];
            var monthNames = new string[]
            {
                "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"
            };
            var monthNumber = 0;
            for (int i = 0; i < monthNames.Length; i++)
            {
                if (monthNames[i] == dates[1])
                {
                    monthNumber = i + 1;
                    break;
                }
            }

            var mn = monthNumber.ToString();
            if (mn.Length == 1)
            {
                mn = "0" + mn;
            }

            var dayN = dates[0].Remove(dates[0].Length - 2, 2);
            if (dayN.Length == 1)
            {
                dayN = "0" + dayN;
            }

            return $"{year}-{mn}-{dayN}";
        }

    }
}