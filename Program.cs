using System;

namespace StalinSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var comrades = new int[] { 1, 5, 23, 8, 9 };
            PrintComrades(comrades);

            StalinSort.Sort(ref comrades);

            PrintComrades(comrades);
        }

        private static void PrintComrades(int[] comrades) {
            foreach (var c in comrades)
                Console.Write($"{c} ");
            Console.WriteLine();
        }
    }
}
