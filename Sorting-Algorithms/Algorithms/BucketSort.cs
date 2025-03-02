using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Algorithms
{
    public class BucketSort
    {
        InsertionSort insertionSort = new InsertionSort();
        public void Sorting(float[] array)
        {
            int n = array.Length;

            List<float>[] buckets = new List<float>[n];

            for (int i = 0; i < n; i++)
            {
                buckets[i] = new List<float> ();
            }

            for (int i = 0; i < n; i++)
            {
                int bi = (int)(n * array[i]);
                buckets[bi].Add(array[i]);
            }

            for (int i = 0; i < n; i++)
            {
                insertionSort.FloatInsertionSort(buckets[i]);
            }

            int index = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < buckets[i].Count; j++)
                {
                    array[index++] = buckets[i][j];
                }
            }
        }

        public void BucketMain()
        {
            Console.Clear();

            Assistants assistants = new Assistants();

            float[] array = assistants.RandomFloatArray(6);
            Console.WriteLine("There is a Random array");
            assistants.PrintArrayFloat(array);

            Sorting(array);
            Console.WriteLine("There is a Sorted array");
            assistants.PrintArrayFloat(array);


            Console.ReadKey();
            Program program = new Program();
            program.MainMenu();
        }
    }
}
