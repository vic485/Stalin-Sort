using System;
using System.Collections.Generic;
using System.Linq;

namespace StalinSort
{
    public static class StalinSort
    {
        /// <summary>
        /// Sort in place. Members who are not in order will become defaulted
        /// </summary>
        public static void QuickSort<T>(T[] array) where T : IComparable
        {
            var checkIndex = array.Length - 1;

            for (var i = array.Length - 2; i >= 0; i--)
            {
                if (array[checkIndex].CompareTo(array[i]) < 0)
                {
                    array[i] = default(T);
                    continue;
                }

                checkIndex = i;
            }
        }

        public static void Sort<T>(ref T[] array) where T : IComparable
        {
            if (array.Length == 0) return;

            var checkIndex = 0;
            var inOrder = new List<T>();
            inOrder.Add(array[0]);

            for (var i = 1; i < array.Length; i++)
            {
                if (array[i].CompareTo(inOrder[checkIndex]) < 0)
                    continue;

                inOrder.Add(array[i]);
                checkIndex++;
            }

            array = inOrder.ToArray();
        }
    }
}
