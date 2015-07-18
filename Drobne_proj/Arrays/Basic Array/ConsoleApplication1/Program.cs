using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = new string[6];
            arr[0] = "PIKACHU";
            arr[1] = "CHARMELEON";
            arr[2] = "GEODUDE";
            arr[3] = "GYARADOS";
            arr[4] = "BUTTERFREE";
            arr[5] = "MANKEY";
            ///{Write your logic here


            string temp_pok;

            bool prawda = true;

            while (prawda)
            {

                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(i + "." + arr[i]);
                }

                Console.WriteLine("Choose a Pokemon (or -1 to quit):");

                int first_choice = int.Parse(Console.ReadLine());

                Console.WriteLine("Choose a Pokemon to exchange with:" + arr[first_choice]);

                int second_choice = int.Parse(Console.ReadLine());

                Console.WriteLine("Exchanging {0} with {1}.", arr[first_choice], arr[second_choice]);

                switch (second_choice)
                {
                    case 0:
                        temp_pok = arr[0];
                        arr[0] = arr[first_choice];
                        arr[first_choice] = temp_pok;
                        break;
                    case 1:
                        temp_pok = arr[1];
                        arr[1] = arr[first_choice];
                        arr[first_choice] = temp_pok;
                        break;
                    case 2:
                        temp_pok = arr[2];
                        arr[2] = arr[first_choice];
                        arr[first_choice] = temp_pok;
                        break;
                    case 3:
                        temp_pok = arr[3];
                        arr[3] = arr[first_choice];
                        arr[first_choice] = temp_pok;
                        break;
                    case 4:
                        temp_pok = arr[4];
                        arr[4] = arr[first_choice];
                        arr[first_choice] = temp_pok;
                        break;
                    case 5:
                        temp_pok = arr[5];
                        arr[5] = arr[first_choice];
                        arr[first_choice] = temp_pok;
                        break;
                    case -1:
                        prawda = false;
                        break;
                    default:
                        Console.WriteLine("Try Again!");
                        break;

                }




            }

        }
    }
}
