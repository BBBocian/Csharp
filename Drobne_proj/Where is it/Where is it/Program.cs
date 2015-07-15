using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create an array that can hold ten integers, and fill each slot with a value from 1-50. 
 * Prompt the user for an integer. Search through the array, and if the item is present, 
 * give the slot number where it is located. If the value is not in the array, display a 
 * single message saying so. If the value is present more than once, you may display the 
 * message as many times as necessary. */

namespace Where_is_it
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();                                          // Creating List for int's

            for (int i = 0; i < 10; i++)                                                //  filling a List using for loop
            {
                lista.Add(int.Parse(Console.ReadLine()));
            }
            int user_value;

            user_value = int.Parse(Console.ReadLine());

            for (int i = 0; i < lista.Count; i++)                                       //finding a index of user_value in list
            {
                if (lista[i] == user_value)
                {
                    Console.WriteLine("{0} is in slot {1}.", user_value, i);
                }
            }
            if (!lista.Contains(user_value))                                            //If user_value is not in a list, return message
                Console.WriteLine("{0} is not in the array.", user_value);

            Console.ReadLine();
        }
    }

}
