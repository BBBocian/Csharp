using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Write a C# program that converts a number in the range [0...999] to words.

Examples:
    0 ? "Zero"
    273 ? "Two Hundred and Seventy Three"
    400 ? "Four Hundred"
    501 ? "Five Hundred and One"
    711 ? "Seven Hundred and Eleven" */

namespace from_numbers_to_english_words
{
    class Program
    {
        static string from0to19(int num)
        {
            switch (num)
            {
                case 1: return "One";
                case 2: return "Two";
                case 3: return "Three";
                case 4: return "Four";
                case 5: return "Five";
                case 6: return "Six";
                case 7: return "Seven";
                case 8: return "Eight";
                case 9: return "Nine";
                case 10: return "Ten";
                case 11: return "Eleven";
                case 12: return "Twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "Sixteen";
                case 17: return "Seventeen";
                case 18: return "Eighteen";
                case 19: return "Nineteen";
                default: return "Invalid Input";
            }
        }

        static string digitTimes10(int num)
        {
            switch (num)
            {
                case 2: return "Twenty ";
                case 3: return "Thirty ";
                case 4: return "Forty ";
                case 5: return "Fifty ";
                case 6: return "Sixty ";
                case 7: return "Seventy ";
                case 8: return "Eighty ";
                case 9: return "Ninety ";
                default: return "Invalid Input77777";
            }

        }

        static void Main()
        {
            string outputexpression = "";
            Console.WriteLine("Enter a number in the range [0...999] :");
            int num = int.Parse(Console.ReadLine());
            if ((num <= 999) && (num > 0))
            {
                string number = num.ToString();



                if (num > 100 && num < 1000)
                {
                    

                    if (num % 100 == 0)
                        Console.WriteLine("{0} Hundred ", from0to19((int)Char.GetNumericValue(number[0])));
                    else if (num % 10 == 0)
                        Console.WriteLine("{0} Hundred {1}", from0to19((int)Char.GetNumericValue(number[0])), digitTimes10((int)Char.GetNumericValue(number[1])));
                    else
                        Console.WriteLine("{0} Hundred {1}{2}", from0to19((int)Char.GetNumericValue(number[0])), digitTimes10((int)Char.GetNumericValue(number[1])), from0to19((int)Char.GetNumericValue(number[2])));
                }

                if (num > 19 && num < 100)
                {
                    if (num % 10 != 0)
                        Console.WriteLine("{0}{1}", digitTimes10((int)Char.GetNumericValue(number[0])), from0to19((int)Char.GetNumericValue(number[1])));
                    else
                        Console.WriteLine(digitTimes10((int)Char.GetNumericValue(number[0])));
                }

                if (num > 0 && num <20)
                {
                    Console.WriteLine("{0}", from0to19(int.Parse(number)));
                }

                //}    
                Console.WriteLine("The number in words is :");
                Console.WriteLine(outputexpression);
            }
            else
                Console.WriteLine("Out of range Input");

            Console.ReadLine();
        }
    }




}
