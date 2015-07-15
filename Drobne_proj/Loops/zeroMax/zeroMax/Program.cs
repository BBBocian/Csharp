using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zeroMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];                                                 // array to keep numbers from user
            List<int> lista = new List<int>();                                      // list to keep all odd numbers from users numbers

            Console.WriteLine("Values for the array:");

            for (int i = 0; i < arr.Length; i++)                                    // loop taking numbers from user
            {
                Console.Write("Value for index {0}:", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            foreach (int x in arr)                                                  // loop adding all odd numbers(taken from arr[])
            {                                                                       // to lista (doasn't working on page if not x!=1)
                if (x % 2 != 0 & x != 1)
                    lista.Add(x);
            }

            for (int i = 0; i < arr.Length; i++)                                    // if we meet zero in lista, loop is looking for a max odd number from lista
            {                                                                       // and replace zero this number, next remove this number from lista
                if (arr[i] == 0 & lista.Count > 0)
                {
                    arr[i] = lista.Max();
                    lista.Remove(lista.Max());
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
