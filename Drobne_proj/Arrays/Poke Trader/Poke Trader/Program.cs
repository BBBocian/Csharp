using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Complete the code which trades the Pokemon at position 0 with the Pokemon selected by the user. If the user enters 0, stop trading.

 

EXCHANGE POKEMON:
0:PIKACHU
1:CHARMELEON
2:GEODUDE
3:GYARADOS
4:BUTTERFREE
5:MANKEY
Choose a Pokemon to exchange with PIKACHU:1
0:CHARMELEON
1:PIKACHU
2:GEODUDE
3:GYARADOS
4:BUTTERFREE
5:MANKEY
Choose a Pokemon to exchange with CHARMELEON:2
0:GEODUDE
1:PIKACHU
2:CHARMELEON
3:GYARADOS
4:BUTTERFREE
5:MANKEY
Choose a Pokemon to exchange with GEODUDE:0
 

EXCHANGE POKEMON:
0:PIKACHU
1:CHARMELEON
2:GEODUDE
3:GYARADOS
4:BUTTERFREE
5:MANKEY
Choose a Pokemon to exchange with PIKACHU:5
0:MANKEY
1:CHARMELEON
2:GEODUDE
3:GYARADOS
4:BUTTERFREE
5:PIKACHU
Choose a Pokemon to exchange with MANKEY:0
 */

namespace Poke_Trader_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pokemony = { "PIKACHU", "CHARMELEON", "GEODUDE", "GYARADOS", "BUTTERFREE", "MANKEY" };             // Pokemons list

            bool condition = true;                                                                                      // while condition

            Program prog = new Program();                                                                               // object Program class

            while (condition)
            {
                prog.print_table(pokemony);                                                                             // printing pokemon's table

                int choosePok = 0;                                                                                     // first int = 0 ;


                    int choosePokToSwap = int.Parse(Console.ReadLine());                                                // taking 2nd int(table index) to swap with

                    if (choosePokToSwap > 0 & choosePokToSwap < 6)                                                     // if 2nd int is ok..
                    {
                        prog.swap(choosePok, choosePokToSwap, pokemony);                                                // swap pokemon in table
                    }
                    else if (choosePokToSwap==0)                                                                        // if input == 0, exit
                    {
                        condition = false;
                    }
                    else                                                                                                // if 2nd index is incorr.
                    {
                        Console.WriteLine("Try Again!");
                        continue;
                    }
                }
  

        }
        private void print_table(string[] tab)
        {
            for (int i = 0; i < tab.Length; i++)
            {
                Console.WriteLine(tab[i]);
            }
            
        }                                                                      // function to print pokemon's table

        private void swap(int choosen_pok, int pok_to_swap_with, string[] pokemons_tab)
        {
            string temp_data = pokemons_tab[choosen_pok];
            pokemons_tab[choosen_pok] = pokemons_tab[pok_to_swap_with];
            pokemons_tab[pok_to_swap_with] = temp_data;
        }                               // function to swap pokemons in table
    }
}
