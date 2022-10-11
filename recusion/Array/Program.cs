using System;
using System.Collections.Generic;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
             FIrstMissingPositiveNumber.MethodToFindKMissingNumber(new List<int> { -3, -2, 1, 2, 4, 10, 11, 3, 5 },3);

            var FIrstMissingPositiveNumberAnswer = FIrstMissingPositiveNumber.Method(new List<int> { -3, -2, 1, 2, 4, 10, 11,3,5 });
            var oddEvenSegrate = SagretrateEvenOdd.Method(new List<int> { 1, 2, 3, 5, 6, 8, 9, 11, 15 });
            var SagregrateZeroOneAndTwo = SagregrateZeroOneTwo.Method(new List<int> {0,1,2,0,0,1,2,1,2,0,1,1,2,0,0 });
            var sagregrateOneAndZero = SagregrateOneZero.Method(new List<int> { 0, 1, 1, 0, 0, 0, 1, 1, 0, 1, 0, 1 });
            var maxSumOfArrayAllneg = MaxSumSubArray.MethodPositiveNegetive(new List<int> { -3, -2, -7, -6, -2, -4, -8, -5 });
            var maxSumOfArray = MaxSumSubArray.MethodPositiveNegetive(new List<int> { -3, 2, -7, 6, -2, 4, -8, 5 });
            FindSubArrayForEqualSum.findSubArrayPositiveNumbers(new int[] { 4, 2, 5, 3, 1, 8 }, 9);
            FindSubArrayForEqualSum.findSubArrayNeg(new int[] { 4, 2, -5, 3, 1, 8 }, -1);

            FindSubArrayForEqualSum.FindSubArray(new List<int> { 4,2,-5,3,1,8 },-1);
            MultiplicationPairMatch.FindPair(new List<int> { 7, 1, 5, 2, 4, 3, 0 }, 15);
            var unsortedInsertion = InsertionOfUnsortedArray.Insertion(new int[] { 4, 2, 3, 5, 4, 2, 3 }, new int[] { 9, 1, 7, 2, 4, 2, 1, 2 });
            var unionUnsortedArray = UnionUnSortedArray.Method(new int[] { 4, 2, 3, 5, 4, 2, 3 }, new int[] { 9, 1, 7, 2, 4, 2, 1, 2 });
            var insertion = InsertionOfTwoArray.Method(new int[] { 2, 2, 2, 3, 4, 7, 8 }, new int[] { 1, 2, 4, 4, 4, 6, 7, 8, 10 });

            var Union = UnionOfSortedArray.Union(new int[] { 2,2,2, 3, 4, 7, 8 }, new int[] { 1, 2, 4,4,4, 6, 7, 8, 10 });
            var FIrstRepeaingElement = FirstReaptingElementInArray.Method(new List<int> { 2, 3, 4, 4, 3, 5, 7,2 });
            var FIrstRepeaingElementTwo = FirstReaptingElementInArray.MethodTwo(new List<int> { 2, 3, 4, 4, 3, 5, 2 });

            var FirstOccurence = FirstOccurenceOfAdjacentArray.FindIndexWithADifferAtMostAdjocentValue(new List<int> { 1,4,5,7,9,12},12,3);
            var FirstOccurenceAnother = FirstOccurenceOfAdjacentArray.
                FindIndexWithADifferAtMostAdjocentValue(new List<int> { 2,3,4,5,6,7 },6,2);

            var leadersArryResult = LeadersInArray.LeadersInArrayMethod(new List<int> { 14, 15, 8, 9, 5, 2 });
            var EquilibriumPointResult = EquilibriumPoint.equilibriumPointMethod(new int[] { -7, 1, 5, 2, -4, 3, 0 },7);
            var missingNumber = FindMissingNumberFromUnsortedArray.FindMissing(new List<int> { 1, 2, 3, 5, 6, 7, 8 });
            var largeSoFar = LargestContiguousSumSubarray.Max(new int[] { -2, -3, 4, -1, -2, 1, 5, -3});
            var binarySearch = BinarySearch.BinarySearchMethod(new int[5] { 1, 3, 4, 5, 6 },6);
            var foundIndex = LinearSearch.LeanerSearchMethod(new int[5] { 1, 3, 4, 5, 6 }, 4);
            var delete = Deletation.DeletationMethod(new int[5] { 1, 3, 4, 5, 6 }, 4);
          var result =  ReverseArray.ReverseArrayMethod(new List<string> { "a", "b", "c", "d", "e" },5);
            var newArray = Insertion.insertionMethod(new int[5] { 1, 3, 4, 5, 6 },0, 2);
        }
    }
}
