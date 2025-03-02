using System;
using Xunit;
using Sorting_Algorithms.Algorithms;
using System.Diagnostics;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sorting_Algorithms.Tests
{
    public class BubbleSortTests
    {
        private readonly BubbleSort _bubbleSort = new BubbleSort();
        private readonly Assistants _assistants = new Assistants();

        [Fact]
        public void Sorting_SortsArrayCorrectly()
        {
            // Arrange
            int[] arr = { 5, 2, 9, 1, 5, 6 };
            int[] expected = { 1, 2, 5, 5, 6, 9 };

            // Act
            _bubbleSort.Sorting(arr, arr.Length);

            // Assert
            Assert.Equal(expected, arr);
        }

        [Fact]
        public void Sorting_BestCasePerformance()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            var stopwatch = Stopwatch.StartNew();
            _bubbleSort.Sorting(arr, arr.Length);
            stopwatch.Stop();

            long elapsedMs = stopwatch.ElapsedMilliseconds;

            Assert.True(elapsedMs < 1); 
        }

        [Fact]
        public void SortPerformanceAverageCase()
        {
            int size = 5000;
            // Arrange
            int[] arr = _assistants.RandomArray(size);
            var stopwatch = Stopwatch.StartNew();

            // Act
            _bubbleSort.Sorting(arr, size);

            // Stop timer
            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMs < size * size * 0.05);
        }

        [Fact]
        public void SortPerformanceWorstCase()
        {
            int size = 10000;
            // Arrange
            int[] arr = _assistants.RandomArray(size);
            var stopwatch = Stopwatch.StartNew();

            // Act
            _bubbleSort.Sorting(arr, size);

            // Stop timer
            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMs < size * size * 0.05);
        }
    }

    public class InsertionSortTest
    {
        private readonly Assistants _assistants = new Assistants();
        private readonly InsertionSort _insertionSort = new InsertionSort();

        [Fact]
        public void Sorting_BestCasePerformance()
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            var stopwatch = Stopwatch.StartNew();
            _insertionSort.Sorting(arr);
            stopwatch.Stop();

            long elapsedMs = stopwatch.ElapsedMilliseconds;

            Assert.True(elapsedMs < 1);
        }

        [Fact]
        public void SortPerformanceAverageCase()
        {
            int size = 5000;
            int[] arr = _assistants.RandomArray(size);
            var stopwatch = Stopwatch.StartNew();

            _insertionSort.Sorting(arr);

            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMs < size * size * 0.05);
        }

        [Fact]
        public void SortPerformanceWorstCase()
        {
            int size = 10000;
            int[] arr = _assistants.RandomArray(size);
            var stopwatch = Stopwatch.StartNew();

            _insertionSort.Sorting(arr);

            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMs < size * size * 0.05);
        }

    }

    public class MergeSortTest
    {
        private readonly Assistants _assistants = new Assistants();
        private readonly MergeSort _mergeSort = new MergeSort();

        [Fact]
        public void Sorting_BestCasePerformance()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int size = arr.Length;

            var stopwatch = Stopwatch.StartNew();
            _mergeSort.Sorting(arr, 0, arr.Length - 1);
            stopwatch.Stop();

            long elapsedMs = stopwatch.ElapsedMilliseconds;

            Assert.True(elapsedMs < size * Math.Log2(size) * 0.05);
        }

        [Fact]
        public void SortPerformanceAverageCase()
        {
            int size = 5000;
            int[] arr = _assistants.RandomArray(size);
            var stopwatch = Stopwatch.StartNew();

            _mergeSort.Sorting(arr, 0, arr.Length - 1);

            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMs < size * Math.Log2(size) * 0.05);
        }

        [Fact]
        public void SortPerformanceWorstCase()
        {
            int size = 10000;
            int[] arr = _assistants.RandomArray(size);
            var stopwatch = Stopwatch.StartNew();

            _mergeSort.Sorting(arr, 0, arr.Length - 1);

            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMs < size * Math.Log2(size) * 0.05);
        }

    }

    public class QuickSortTest
    {
        private readonly Assistants _assistants = new Assistants();
        private readonly QuickSort _quickSort = new QuickSort();

        [Fact]
        public void Sorting_BestCasePerformance()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int size = arr.Length;

            var stopwatch = Stopwatch.StartNew();
            _quickSort.Sorting(arr, 0, arr.Length - 1);
            stopwatch.Stop();

            long elapsedMs = stopwatch.ElapsedMilliseconds;

            Assert.True(elapsedMs < size * Math.Log2(size) * 0.05);
        }

        [Fact]
        public void SortPerformanceAverageCase()
        {
            int size = 5000;
            int[] arr = _assistants.RandomArray(size);
            var stopwatch = Stopwatch.StartNew();

            _quickSort.Sorting(arr, 0, arr.Length - 1);

            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMs < size * Math.Log2(size) * 0.05);
        }

        [Fact]
        public void SortPerformance_WorstCase()
        {
            int size = 5000;
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i + 1; 
            }

            var stopwatch = Stopwatch.StartNew();

            _quickSort.Sorting(arr, 0, arr.Length - 1);

            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;

            Assert.True(elapsedMs < size * size * 0.05);

        } 
    }

    public class BucketSortTests
    {
        private readonly BucketSort _bucketSort = new BucketSort();
        private readonly Assistants _assistants = new Assistants();

        [Fact]
        public void Sorting_BestCasePerformance()
        {
            float[] arr = { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f };

            var stopwatch = Stopwatch.StartNew();
            _bucketSort.Sorting(arr);
            stopwatch.Stop();

            long elapsedMs = stopwatch.ElapsedMilliseconds;

            Assert.True(elapsedMs < 1); 
        }

        [Fact]
        public void SortPerformance_AverageCase()
        {
            int size = 5000;
            float[] arr = _assistants.RandomFloatArray(size);
            var stopwatch = Stopwatch.StartNew();

            _bucketSort.Sorting(arr);

            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;

            Assert.True(elapsedMs < size * Math.Log2(size) * 0.05);
        }

        [Fact]
        public void SortPerformance_WorstCase()
        {
            int size = 100000;
            float[] arr = _assistants.RandomFloatArray(size);
            var stopwatch = Stopwatch.StartNew();

            _bucketSort.Sorting(arr);

            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;

            Assert.True(elapsedMs < size * size * 0.05);
        }
    }
}
