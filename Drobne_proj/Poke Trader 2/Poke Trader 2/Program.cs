using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Make a program that gives a numbered list.

0. PIKACHU

1. CHARMELEON

2. GEODUDE

3. GYARADOS

4. BUTTERFREE

5. MANKEY

Then, choose a number of them or (-1) to quit. And then, choose a number to exchange with.

For choice out of bounds or same set of inputs, display "Try Again!". 

EXCHANGE POKEMON
0. PIKACHU
1. CHARMELEON
2. GEODUDE
3. GYARADOS
4. BUTTERFREE
5. MANKEY
Choose a Pokemon (or -1 to quit):1
Choose a Pokemon to exchange with CHARMELEON:5
Exchanging CHARMELEON with MANKEY.
EXCHANGE POKEMON
0. PIKACHU
1. MANKEY
2. GEODUDE
3. GYARADOS
4. BUTTERFREE
5. CHARMELEON
Choose a Pokemon (or -1 to quit):-1
 */

namespace Poke_Trader_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pokemony = { "PIKACHU", "CHARMELEON", "GEODUDE", "GYARADOS", "BUTTERFREE", "MANKEY" };          // Pokemons list

            bool condition = true;                                                                                      // while condition

            Program prog = new Program();                                                                               // object Program class
            
            while(condition)
            {
                prog.print_table(pokemony);                                                                             // printing pokemon's table

                int choosePok = int.Parse(Console.ReadLine());                                                          // taking int(table index) from input

                if (choosePok >= 0 & choosePok < 6)                                                                     // int condition
                {
                    Console.WriteLine("Choose a Pokemon to exchange with {0}:", pokemony[choosePok]);                    // asking about 2nd int to swap with

                    int choosePokToSwap = int.Parse(Console.ReadLine());                                                // taking 2nd int(table index) to swap with

                    if (choosePokToSwap >= 0 & choosePokToSwap < 6)                                                     // if 2nd int is ok..
                    {
                        Console.WriteLine("Exchanging {0} with {1}.", pokemony[choosePok], pokemony[choosePokToSwap]);  // print swaping results

                        prog.swap(choosePok, choosePokToSwap, pokemony);                                                // swap pokemon in table
                    }
                    else                                                                                                // if 2nd index is incorr.
                    {
                        Console.WriteLine("Try Again!");
                        continue;
                    }
                }
                else if (choosePok == -1)                                                                               // if 1st index==-1, change while condition and quit
                    condition = false;
                else
                    Console.WriteLine("Try Again!");                                                                    // if 1st index incorretc -> print try again.

                
            }
            
        }
        private void print_table(string [] tab)
        {
            Console.WriteLine("EXCHANGE POKEMON");
            for(int i=0;i<tab.Length;i++)
            {
                Console.WriteLine("{0}. {1}", i, tab[i]);
            }
            Console.WriteLine("Choose a Pokemon (or -1 to quit):");
        }                                                                      // function to print pokemon's table
            
        private void swap(int choosen_pok,int pok_to_swap_with,string [] pokemons_tab)
        {
            string temp_data = pokemons_tab[choosen_pok];
            pokemons_tab[choosen_pok] = pokemons_tab[pok_to_swap_with];
            pokemons_tab[pok_to_swap_with] = temp_data;
        }                               // function to swap pokemons in table
    }
}
