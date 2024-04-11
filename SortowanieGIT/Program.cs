using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowanieGIT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 3, 1, 4, 6 };
            Console.WriteLine("Przed sortowaniem: " + string.Join(", ", array));

            BubbleSort(array);
            Console.WriteLine("Po sortowaniu: " + string.Join(", ", array));

            Console.ReadKey(true);
        }

        static void BubbleSort(int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
        }
    }
}
