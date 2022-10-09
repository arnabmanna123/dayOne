using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            TargetSumPair.TargetSumPairMethod(new List<int> { 7, 15, 3, 18, 6, 4, 19, 2, 12, 11, 9 }, 15);
            var zeroOneTwo = SortZeroOneTwo.SortZeroOneTwoMethod(new List<int> { 0,1,2,2,1,1,2,2,1,0,1,2,0,2 });

            var zeroOne = SortOneAndZero.SortOneAndZeroMethod(new List<int> { 1, 1, 0, 1, 0, 1, 1, 0, 1, 0, 0, 0, 1 });
            var resultDate = SortDates.SortDatesMethod(new List<string> { "05061997", "11081987", "12041996", "12041989", "20101996" });
            var ShellSortMethod = ShellSort.ShellSortMethod(new List<int> { 23, 29, 15, 19, 31, 7, 9, 5, 2 });
            var radixSort = RadixSort.RadixSortMethod(new List<int> { 213, 97, 718, 123, 37, 443, 982, 64, 375, 683 });
           var countSort= CountSort.CountSortMethod(new List<int> { 9, 6, 3, 5, 3, 4, 3, 9, 6, 4, 6, 5, 8, 9, 9 }, 3, 9);
            var mergeSortres = mergeSort.margeSort(new List<int> { 12, 22, 1, 9, 10, 33, 8 }, 0, 6);
            var quickSort = QuickSort.QuickSortMethod(new List<int> { 12, 22, 1, 9, 10, 33, 8 },0,6);
            var result2 = InsertionSort.InsertionSortMethod(new List<int> { 12, 22, 1, 9, 10, 33, 8 });
            var result = BubbleSort.BubbleSortMethod(new List<int> { 12,22,1,9,10,33,8 });
            var result1 = SelectionSort.SelectionSortMethod(new List<int> { 12, 22, 1, 9, 10, 33, 8 });

        }
    }
}
