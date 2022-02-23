using System;

namespace BinarySearch.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 1, 3, 5, 7, 9, 10, 14, 17, 20, 55 };

            var position = BinarySearch(values, 89);

            Console.WriteLine($@"The position is {position}");

            static int? BinarySearch(int[] values, int item)
            {
                var low = 0;
                var high = values.Length - 1;

                while (low <= high)
                {
                    var middle = (low + high) / 2;
                    var hypothesis = values[middle];

                    if (hypothesis == item)
                    {
                        return middle;
                    }
                    else if (hypothesis > item)
                    {
                        high = middle - 1;
                    }
                    else
                    {
                        low = middle + 1;
                    }
                }

                return null;
            }
        }
    }
}