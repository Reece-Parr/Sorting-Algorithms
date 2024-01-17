namespace Quick_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 2, 8, 4, 9 };
            
            // Call the sort function.
            QuickSort(arr, 0, arr.Length - 1);

            // Display sorted array.
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
        }
        public static void Swap(int[] arr, int i, int j)
        {
            // Swap current element with comparison element
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

        public static int Partition(int[] arr, int left, int right)
        {
            // PivotPos used to increment the pivot up the array during search.
            int pivotPos = left;

            // Beginning position of pivot for referencing with other values in array.
            int pivot = arr[left];

            // Iterate through the array and check if the current value is less than the pivot value.
            for (int i = left + 1; i <= right; i++)
            {
                if (arr[i] < pivot)
                {
                    pivotPos++;
                    Swap(arr, pivotPos, i);
                }
            }
            Swap(arr, pivotPos, left);
            return pivotPos;
        }

        public static void QuickSort(int[] arr, int left, int right)
        {
            // Array must have atleast 2 elements for condition to run.
            if (left < right)
            {
                // Stores current pivot position for each array.
                var pivPos = Partition(arr, left, right);
                
                // Perform sort on the left sub array.
                QuickSort(arr, left, pivPos - 1);

                // again.. perform sort on the right sub array.
                QuickSort(arr, pivPos + 1, right);
            }
        }
    }
}
