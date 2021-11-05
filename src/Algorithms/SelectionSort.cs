using System;

namespace Algorithms.Sort
{
    public class SelectionSort
    {
        public static int[] Sort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException($"The {nameof(array)} is null");
            }

            for (int i = 0; i < array.Length; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }

                Swap(array, i, smallest);
            }

            return array;
        }

        private static void Swap(int[] array, int x, int y)
        {
            int temp = array[x];
            array[x] = array[y];
            array[y] = temp;
        }
    }
}
