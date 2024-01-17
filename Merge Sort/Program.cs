namespace Merge_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input array and parameter passing of array to function.
            int[] arr = new int[] { 2, 3, 1, 8, 1, 5, 7, 11 };
            MergeSort(arr, 0, arr.Length - 1);

            // Print the final array's values from the Merge Sorting function.
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }

            Console.ReadLine();
        }

        public static void MergeSort(int[] array, int left, int right)
        {
            // Check for more than 1 element in array.
            if (left < right)
            {
                // Defining middle index by taking the input array.
                int middle = (left + (right - 1)) / 2 + 1;

                // Uses recursion to then continuously split the arrays until its just single values.

                // Call a split on the left array.
                MergeSort(array, left, middle - 1);
                
                // Call a split on the right array.
                MergeSort(array, middle, right);

                // This is two merge the last two sorted sub arrays.
                Merge(array, left, middle, right);
            }
        }
        public static void Merge(int[] array, int left, int middle, int right)
        {
            // Three iterations for searching function.
            int leftIterator, rightIterator, arrayIterator;
            
            // Calculating the lengths of both sub arrays.
            int leftArrayLength = middle - left;
            int rightArrayLength = right - middle + 1;

            // Defining and intialising the sub arrays with the correct lengths.
            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            // Copy elements from main array to the sub/split arrays.
            for (leftIterator = 0; leftIterator < leftArrayLength; leftIterator++)
            {
                leftArray[leftIterator] = array[left + leftIterator];
            }

            for (rightIterator = 0; rightIterator < rightArrayLength; rightIterator++)
            {
                rightArray[rightIterator] = array[middle + rightIterator];
            }

            // Interators for all arrays to compare elements.
            leftIterator = 0;
            rightIterator = 0;
            arrayIterator = left;

            // Compares the two sub arrays. Continues running until they are empty.
            while (leftIterator < leftArrayLength && rightIterator < rightArrayLength)
            {
                // Compare left array element with right array element, if smaller add to final array.
                // Increments each index to pass through the different arrays sequentially.
                if (leftArray[leftIterator] <= rightArray[rightIterator])
                {
                    array[arrayIterator++] = leftArray[leftIterator++];
                }
                // If left array element is NOT smaller, the right element is added to the final array.
                else
                {
                    array[arrayIterator++] = rightArray[rightIterator++];
                }
            }

            // Check to see if either of the arrays contain a remainder value, this is usually to be the largest value.
            int remainderIterator;

            // If the left array is done, it will copy the value from the right array.
            if (leftIterator == leftArrayLength)
            {
                for (remainderIterator = rightIterator; remainderIterator < rightArrayLength; remainderIterator++)
                {
                    array[arrayIterator++] = rightArray[remainderIterator];
                }
            }
            // If the right array is done, it will copy the value from the left array.
            if (rightIterator == rightArrayLength)
            {
                for (remainderIterator = leftIterator; remainderIterator < leftArrayLength; remainderIterator++)
                {
                    array[arrayIterator++] = leftArray[remainderIterator];
                }
            }
        }
    }
}
