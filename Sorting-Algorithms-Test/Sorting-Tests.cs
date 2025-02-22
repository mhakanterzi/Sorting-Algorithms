using System;
using Xunit;
using Sorting_Algorithms.Algorithms;
using System.Diagnostics;
using System.Drawing;

namespace Sorting_Algorithms.Tests
{
    public class BubbleSortTests
    {
        private readonly BubbleSort _bubbleSort = new BubbleSort();

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
            int[] arr = _bubbleSort.RandomArray(size);
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
            int[] arr = _bubbleSort.RandomArray(size);
            var stopwatch = Stopwatch.StartNew();

            // Act
            _bubbleSort.Sorting(arr, size);

            // Stop timer
            stopwatch.Stop();
            long elapsedMs = stopwatch.ElapsedMilliseconds;


            Assert.True(elapsedMs < size * size * 0.05);
        }
    }
}
