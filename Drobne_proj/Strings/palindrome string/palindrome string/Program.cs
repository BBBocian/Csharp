using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write a function to complete the program. The program receives a string, then it must return if the string given is a palindrome or not.

Enter string:anitalavalatina
anitalavalatina is palindrome?:True
 

Enter string:robocop
robocop is palindrome?:False
 */

namespace palindrome_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string:");
            string s = Console.ReadLine();
            Console.WriteLine("{0} is palindrome?:{1}", s, checkPalindrome(s));
        }
        static bool checkPalindrome(string s)
        {
            //write your code here
           char[] char_array = s.ToCharArray();
           Array.Reverse(char_array);
           string a = new string(char_array);
           
            if(s==a)
                return true;
            else
                return false;
    }
}
