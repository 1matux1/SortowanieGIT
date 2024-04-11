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
            int[] array = GetArrayFromUser();
            Console.WriteLine("Przed sortowaniem: " + string.Join(", ", array));
            BubbleSort(array);
            Console.WriteLine("Po sortowaniu: " + string.Join(", ", array));

            Console.ReadKey(true);
        }

        static int[] GetArrayFromUser()
        {
            Console.WriteLine("Podaj liczbę elementów tablicy:");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size))
            {
                Console.WriteLine("Nieprawidłowa liczba, spróbuj ponownie:");
            }

            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Podaj element {i + 1}:");
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    Console.WriteLine("Nieprawidłowa liczba, spróbuj ponownie:");
                }
            }

            return array;
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
