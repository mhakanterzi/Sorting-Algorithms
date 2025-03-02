using Sorting_Algorithms.Algorithms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.MainMenu();
        }


        public void MainMenu()
        {
            BubbleSort bubbleSort = new BubbleSort();
            InsertionSort insertionSort = new InsertionSort();
            MergeSort mergeSort = new MergeSort();
            QuickSort quickSort = new QuickSort();

            string prompt = " ";

            string[] options = { "1- Bubble Sort", "2- Insertion Sort", "3- Merge Sort ", "4- Quick Sort ", "5- Bucket Sort ", "Çıkış" };
            MenuControl main = new MenuControl(options, prompt);
            int SelectedIndex = main.Run();

            switch (SelectedIndex)
            {
                case 0:
                    bubbleSort.BubbleSortMain();
                    break;
                case 1:
                    insertionSort.InsertionMain();
                    break;
                case 2:
                    mergeSort.MergeMain();
                    break;
                case 3:
                    quickSort.QuickMain();
                    break;
                case 4:
                    break;
                case 5:
                    Console.Write("\nÇıkmak için herhangi bir tuşa basınız... ");
                    Console.ReadKey(true);
                    Environment.Exit(0);
                    break;
            }
        }


        internal class MenuControl
        {
            private int SelectedIndex;

            private string[] Options;

            private string Prompt;

            public MenuControl(string[] options, string prompt)
            {
                Prompt = prompt;
                Options = options;
                SelectedIndex = 0;
            }

            private void DisplayOptions()
            {
                Console.WriteLine(Prompt);
                for (int i = 0; i < Options.Length; i++)
                {
                    string currentOption = Options[i];
                    string prefix;

                    if (i == SelectedIndex)
                    {
                        prefix = ">";
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        prefix = " ";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine($"{prefix} {currentOption}");
                }

                Console.ResetColor();
            }



            public int Run()
            {
                ConsoleKey keyPressed;

                do
                {
                    Console.Clear();
                    DisplayOptions();
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                    keyPressed = keyInfo.Key;

                    if (keyPressed == ConsoleKey.UpArrow)
                    {
                        SelectedIndex--;

                        if (SelectedIndex == -1)
                        {
                            SelectedIndex = Options.Length - 1;
                        }
                    }
                    else if (keyPressed == ConsoleKey.DownArrow)
                    {
                        SelectedIndex++;

                        if (SelectedIndex == Options.Length)
                        {
                            SelectedIndex = 0;
                        }
                    }
                    else if (keyPressed == ConsoleKey.Escape)
                    {
                        Program app = new Program();
                        app.MainMenu();
                    }
                } while (keyPressed != ConsoleKey.Enter);
                return SelectedIndex;
            }
        }
    }
}