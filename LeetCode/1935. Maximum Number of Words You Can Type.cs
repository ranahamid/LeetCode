namespace LeetCode
{
    public class _1935__Maximum_Number_of_Words_You_Can_Type {
        
        /// <summary>
        /// Runtime: 96 ms, faster than 53.97% of C# online submissions for Maximum Number of Words You Can Type.
        /// Memory Usage: 35.9 MB, less than 63.49% of C# online submissions for Maximum Number of Words You Can Type.
        /// </summary>
        /// <param name="text"></param>
        /// <param name="brokenLetters"></param>
        /// <returns></returns>
        public static int CanBeTypedWords(string text, string brokenLetters)
        {
            var words = text.Split(' ');
            var brokenChars = brokenLetters.ToCharArray();
            var counter = 0;
            foreach (var word in words)
            {
                var isWriteen = true;
                foreach (var brokenChar in brokenChars)
                {
                    if (word.Contains(brokenChar.ToString()))
                    {
                        isWriteen = false;
                        break;
                    }
                }

                if (isWriteen)
                    counter++;
            }

            return counter;
        }



    }
}