using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            var mergeSortres = mergeSort.margeSort(new List<int> { 12, 22, 1, 9, 10, 33, 8 }, 0, 6);
            var quickSort = QuickSort.QuickSortMethod(new List<int> { 12, 22, 1, 9, 10, 33, 8 },0,6);
            var result2 = InsertionSort.InsertionSortMethod(new List<int> { 12, 22, 1, 9, 10, 33, 8 });
            var result = BubbleSort.BubbleSortMethod(new List<int> { 12,22,1,9,10,33,8 });
            var result1 = SelectionSort.SelectionSortMethod(new List<int> { 12, 22, 1, 9, 10, 33, 8 });

        }
    }
}
