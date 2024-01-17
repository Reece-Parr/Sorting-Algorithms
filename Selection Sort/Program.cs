namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Intialise array with numbers.
            int[] arr = new int[] { 8, 7, 9, 2, 3, 1, 5, 4, 6 };

            // Call the function with the array paramter.
            SelectionSort(arr);

            // Output the array values after updated.
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }

        public static void SelectionSort(int[] arr)
        {
            // Iterate through the input array.
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[min] > arr[j])
                    {
                        min = j;
                    }
                }
                // Swap values around in array using TEMP storage.
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;
            }
        }
    }
}
