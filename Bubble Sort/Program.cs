namespace Bubble_Sorting
{
    public class BubbleSort
    {
        public void Sort(int[] arr)
        {
            int size = arr.Length;
            int i, j, temp;
            for (i = 0; i < (size - 1); i++)
            {
                for (j = 0; j < size - i - 1; j++)
                {
                    if ((arr[j] > arr[j + 1]))
                    {
                        /* Swapping */
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            BubbleSort b = new BubbleSort();
            b.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ReadLine();

        }
    }
}
