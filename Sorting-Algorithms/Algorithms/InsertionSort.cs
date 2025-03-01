using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Algorithms
{
    public class InsertionSort
    {
        public void Sorting(int[] array)
        {
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                int key = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
                Console.WriteLine($"Step {i}: {string.Join(" ", array)}\n");
            }
        }


        public void InsertionMain()
        {
            Console.Clear();

            Assistants assistants = new Assistants();

            int[] array = assistants.RandomArray(10);
            Console.WriteLine("There is a Random array");
            assistants.PrintArray(array);

            Sorting(array);
            Console.WriteLine("There is a Sorted array");
            assistants.PrintArray(array);


            Console.ReadKey();
            Program program = new Program();
            program.MainMenu();
        }
    }
}
