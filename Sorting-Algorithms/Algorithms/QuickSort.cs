using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Algorithms
{
    public class QuickSort
    {
        public void Swap(int[]array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }

        public int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];

            int i = low - 1;

            for(int j = low; j <= high -1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap (array, i + 1, high);
            return i + 1;
        }

        public void Sorting(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = Partition(array, low, high);

                Sorting(array, low, pivot - 1);
                Sorting (array, pivot + 1, high);
            }
        }

        public void QuickMain()
        {
            Console.Clear();

            Assistants assistants = new Assistants();

            int[] array = assistants.RandomArray(10);
            Console.WriteLine("There is a Random array");
            assistants.PrintArray(array);

            Sorting(array, 0, array.Length - 1);
            Console.WriteLine("There is a Sorted array");
            assistants.PrintArray(array);


            Console.ReadKey();
            Program program = new Program();
            program.MainMenu();
        }
    }
}
