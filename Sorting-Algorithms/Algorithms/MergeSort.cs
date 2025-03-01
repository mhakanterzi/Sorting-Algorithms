using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Algorithms
{
    public class MergeSort
    {
        public void Merge(int[] array, int left, int right, int middle)
        {
            int n1 = middle - left + 1;
            int n2 = right - middle;

            int[]Left = new int[n1];
            int[]Right = new int[n2];
            int i, j;

            for(i = 0; i < n1; ++i)
            {
                Left[i] = array[left+ i];
            }
            for(j = 0; j < n2; ++j)
            {
                Right[j] = array[middle + 1+ j];
            }

            i=0;
            j = 0;

            int k = left;
            while(i  < n1 && j < n2)
            {
                if (Left[i] <= Right[j])
                {
                    array[k] = Left[i];
                    i++;
                }
                else
                {
                    array[k] = Right[j];
                    j++;
                }
                k++;
            }

            while(i < n1)
            {
                array[k] = Left[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                array[k] = Right[j];
                j++;
                k++;
            }
        }

        public void Sorting(int[] array, int left, int right)
        {
            if(left < right)
            {
                int middle = left + (right - left)/2;   

                Sorting (array, left, middle);  
                Sorting (array, middle + 1, right);

                Merge(array, left, right, middle);
            }
        }

        public void MergeMain()
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
