
namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 9, 1, 8, 2, 7, 3, 6, 5, 4 };

            InsertationSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static void InsertationSort(int[] arr)
        {
            // Iterate through array.
            for (int i = 1; i < arr.Length; i++)
            {
                // Store current value into a temp variable.
                int temp = arr[i]; // VALUE: 1
                // Keep track of value left of current value;
                int j = i - 1;

                // Compare values to the left of the current value.
                while(j >= 0 && arr[j] > temp)
                {
                    // Move element to the right.
                    arr[j + 1] = arr[j];
                    j--;
                }
                // Move element to the left, or leave as is if COMPARISON value is SMALLER THAN temp.
                arr[j + 1] = temp;
            }
        }
    }
}
