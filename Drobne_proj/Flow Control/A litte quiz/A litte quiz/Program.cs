using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Write an interactive quiz. It should ask the user three multiple-choice or true/false questions about something. It must keep track of how many they get wrong, and print out a "score" at the end.

 

Q1) What is the capital of Alaska?:
         1)Melbourne:
         2)Anchorage: 
         3)Juneau:
>:3
Q2) Can you store the value 'cat' in a variable of type int?:
         1)yes:
         2)no:
>:2
Q3) What is the result of 9+6/3?:
         1)5:
         2)11:
         3)15/3:
>:2
Overall, you got a score:3
 */ 

namespace A_litte_quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer1;
            int answer2;
            int answer3;
            int score=0;

            Console.Write("Q1) What is the capital of Alaska?:\n\t1)Melbourne:\n\t2)Anchorage:\n\t3)Juneau:\n>:");
            answer1 = int.Parse(Console.ReadLine());
            Console.Write("Q2) Can you store the value 'cat' in a variable of type int?:\n\t1)yes:\n\t2)no:\n>:");
            answer2 = int.Parse(Console.ReadLine());
            Console.Write("Q3) What is the result of 9+6/3?:\n\t1)5:\n\t2)11:\n\t3)15/3:\n>:");
            answer3 = int.Parse(Console.ReadLine());

            int[] corr_answ = new int[] {3,2,2};
            
            if(answer1 == corr_answ[0])
                score+=1;
            if(answer2 == corr_answ[1])
                score+=1;
            if(answer3 == corr_answ[2])
                score+=1;
            
            Console.WriteLine("Overall, you got a score:{0}", score);            
        }
    }
}
