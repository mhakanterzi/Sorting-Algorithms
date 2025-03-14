﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Assistants
    {

        public int[] RandomArray(int size, int Min = 0, int Max = 100)
        {

            int[] randomArray = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                randomArray[i] = random.Next(Min, Max + 1);
            }
            return randomArray;
        }

        public float[] RandomFloatArray(int size)
        {
            Random random = new Random();

            float[] array = new float[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = (float)random.NextDouble();
            }
            return array;
        }


        public void PrintArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public void PrintArrayFloat(float[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

    }
}
