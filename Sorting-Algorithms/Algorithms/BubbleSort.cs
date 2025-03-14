﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms.Algorithms
{
    public class BubbleSort
    {
        public void Sorting(int[] arr, int n)
        {
            int i, j, temp;
            bool swap;

            for(i = 0; i < n - 1; i++)
            {
                swap = false;
                for (j = 0; j < n- i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp  = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        swap = true;
                    }
                }
                if (swap == false)
                {
                    break;
                } 
            }
        }

        public void PrintArray(int[] arr, int size)
        {
            int i;
            for(i = 0; i < size; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public void BubbleSortMain()
        {
            Console.Clear();

            Assistants randomArray = new Assistants();

            int[] array = randomArray.RandomArray(10);
            int n = array.Length;
            Console.WriteLine("Random Array");
            PrintArray(array, n);
            Sorting(array, n);
            Console.WriteLine("\n Sorted Array");    
            PrintArray(array, n);

            Console.ReadKey();
            Program program = new Program();
            program.MainMenu();
        }
    }
}
