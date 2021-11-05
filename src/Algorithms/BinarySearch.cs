using System;

namespace Algorithms.Search
{
    public class BinarySearch
    {
        public static int? Search(int[] sortedArray, int item)
        {
            if (sortedArray == null)
            {
                throw new ArgumentNullException($"The {nameof(sortedArray)} is null");
            }

            int low = 0;
            int high = sortedArray.Length;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = sortedArray[mid];

                if (guess == item)
                {
                    return mid;
                }

                if (guess > item)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return null;
        }
    }
}
