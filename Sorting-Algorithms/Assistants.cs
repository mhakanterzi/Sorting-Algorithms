using System;
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
                randomArray[i] = random.Next(Min, Max + 1); //generatin random value between Min and Max values
            }
            return randomArray;
        }

    }
}
