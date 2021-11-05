using System;

namespace Algorithms
{
    public class BinarySearch
    {
        public static int? Search(int[] list, int item)
        {
            if (list == null)
            {
                throw new ArgumentNullException("The list is null");
            }

            int low = 0;
            int high = list.Length;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                int guess = list[mid];

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
