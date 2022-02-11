using System;
using System.Linq;

namespace Combination
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] set = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] array = new int[k];

            Generate(array, 0, 0, set);
        }
        private static void Generate(int[] array, int index,  int start, int[] set)
        {
            if(index > array.Length - 1)
            {
                Console.WriteLine(string.Join(" ", array));
                return;
            }
            for(int i = start; i < set.Length; i++)
            {
                array[index] = set[i];
                Generate(array, index + 1, i + 1, set);
            }
        }
    }
}
