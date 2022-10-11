using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadatakZaVjezbu4
{
    internal class Program
    {

        class Sort
        {
            public static void QuickSort(int[] array, int left, int right)
            {
                int temp;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - 1 - i; j++)
                    {
                        if (array[j] < array[j + 1])
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                }
                array[0] = left;
                array[array.Length - 1] = right;

            }
        }

        static void Main(string[] args)
        {

            int left, right;
            int[] array = { 2, 4, 3, 7, 6, 6, 8, 1, 9 };
            left = array[0];
            right = array[array.Length - 1];
            Sort.QuickSort(array, left, right);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();

        }
    }
}
