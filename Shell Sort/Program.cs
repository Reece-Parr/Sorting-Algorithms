namespace Shell_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare array and intialise with values.
            int[] arr = new int[] { 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            // Print array before sort.
            PrintArray(arr);

            // Call Shell Sort on array.
            ShellSort(arr, arr.Length);

            // Print array after sort.
            PrintArray(arr);

        }

        public static void ShellSort(int[] arr, int size)
        {
            int i, j, increment, temp;
            increment = 3;

            while(increment > 0)
            {
                // Iterate through the array.
                for(i = 0; i < size; i++)
                {
                    j = i;
                    // Each element saved into temp to move its location in array.
                    temp = arr[i];

                    // Check each value and save last value into the array
                    while (j >= increment && arr[j - increment] > temp)
                    {
                        arr[j] = arr[j - increment];
                        j = j - increment;
                    }
                    arr[j] = temp;
                }

                if (increment /2 != 0)
                {
                    increment /= 2;
                } 
                else if (increment == 1)
                {
                    increment = 0;
                }
                else
                {
                    increment = 1;
                }
            }
        }
        public static void PrintArray(int[] arr) 
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.Write("\n");
        }
    }
}
