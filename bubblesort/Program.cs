using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    class BubbleSort
    {
        public void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
        }

        public void PrintArray(int[] array)
        {
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main()
        {
            int[] array = { 12, 54, 9, 19, 28, 43, 33 };
            BubbleSort bubbleSort = new BubbleSort();

            Console.WriteLine("Unsorted array: ");
            bubbleSort.PrintArray(array);

            bubbleSort.Sort(array);

            Console.WriteLine("Sorted array: ");
            bubbleSort.PrintArray(array);
        }
    }
}
