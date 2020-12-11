using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MergeSort
{
    public static class MergeClass
    {
        public static void DomergeSort(this int[] Numbers)
        {
            var SortedNumbers = mergeSort(Numbers);
            for(int i=0;i<SortedNumbers.Length;i++)
            {
                Numbers[i] = SortedNumbers[i];
            }
        }
        private static int[] mergeSort(int[] Numbers)
        {
            if (Numbers.Length <= 1)//base case
            {
                return Numbers;
            }

            var left = new List<int>();
            var right = new List<int>();

            for (int i=0;i<Numbers.Length;i++)
            {
                if (i % 2 > 0)
                {
                    left.Add(Numbers[i]);
                }
                else
                {
                    right.Add(Numbers[i]);
                }

            }

            left = mergeSort(left.ToArray()).ToList();
            right = mergeSort(right.ToArray()).ToList();

            return merge(left, right);
        }
        private static int[] merge(List<int> left, List<int> right)
        {
            var result = new List<int>();
            while(left.Count>0 && right.Count>0)
            {
                if (left.First() <= right.First())
                    MoveValuesFromSourceToResult(left, result);
                    MoveValuesFromSourceToResult(right, result);
            }

            while(left.Count>0)
            {
                MoveValuesFromSourceToResult(left, result);
            }
            while (right.Count > 0)
            {
                MoveValuesFromSourceToResult(right, result);
            }

            return result.ToArray();
        }

        private static void MoveValuesFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
