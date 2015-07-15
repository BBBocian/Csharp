using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome_number
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number:");
            int n = 999;
            while (n < 1000 || n >= 10000)
            {
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("is {0} a palindrome number?:{1}", n, isPalindrome(n));

        }

        static bool isPalindrome(int n)                                                    // bool function to check isPalindrome
        {
            string a = n.ToString();                                                       // converting int number to string
            int count = 0;                                                                 // counter to cout positive comparison 
            int val = a.Length / 2;                                                        // int used to loop condition and count comparison
                                                                                            
            for (int i = 0; i < val; i++)                                                  // Loop is working val-times where val is str.Length/2
            {                                                                              // if we have number 1221 --> ToString --> "1221"
                if (a[i] == a[a.Length - i - 1])                                           // then we gonna check (i=0) if the first char from string
                    count += 1;                                                            // (index=i=0) is the same like the last one (index=3=str.Length-1-i)
            }                                                                              // if so --> count+=1, and we gonna check again (i=1) (index = i+1 =1) and 
                                                                                           // (index = 2 = str.Length-1-i).   
            if (count == val)                                                              // If we have length of str=3, we need to check only one time fe. 121 (if 1==1)
                return true;                                                               // If we have length of str=4, we need to check only 2 times fe. 3223 (if 3==3 and 2==2)
            else                                                                           // if checking is ok, count+1, if count== val(max number of checking) value is palindrome
                return false;

        }
    }
}
