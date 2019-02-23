using System;

namespace PadawansTask5
{
    public static class ArrayHelper
    {
        public static string CheckIfSymmetric(int[] source)
        {
            int i = 0, j = source.Length - 1;
            if (source.Length == 0)
            {
                throw new ArgumentNullException();
            }
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            while (i < j)
            {
                if (source[i++] != source[j--])
                {
                    return "No";
                }
            }
            return "Yes";
            // put your code here
            throw new NotImplementedException();
        }
    }
}
