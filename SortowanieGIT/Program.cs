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

            Console.ReadKey(true);
        }
    }
}
