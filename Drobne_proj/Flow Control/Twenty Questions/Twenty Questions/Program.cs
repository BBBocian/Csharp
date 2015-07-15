using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Make a program which plays a game of 20 2 questions. The first question should be "animal, vegetable, or mineral?" Then, 
 * the second question should be "is it bigger than a breadbox?" Then, display one of the 7 possible responses, depending on their answers:
Size/Type                 Animal                       Vegetable                      Mineral

bigger than a breadbox    mouse             watermelon               camaro

smaller than a breadbox   squirrel            carrot                 paperclip

Question 1) Is it animal(1), vegetable(2), or mineral(3)?:
1
Question 2) Is it bigger than a breadbox? yes(1),no(2):
1
My guess is that you are thinking of a:mouse
 */
namespace Twenty_Questions
{
    class Program
    {
        static void Main()
        {
            int option1;
            int option2;
            string answer;

            Console.WriteLine("Question 1) Is it animal(1), vegetable(2), or mineral(3)?:");
            option1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Question 2) Is it bigger than a breadbox? yes(1),no(2):");
            option2 = int.Parse(Console.ReadLine());

            if (option1 == 1)
            {
                if (option2 == 1)
                    answer = "mouse";
                else
                    answer = "squirrel";
            }
            else if (option1 == 2)
            {
                if (option2 == 1)
                    answer = "watermelon";
                else
                    answer = "carrot";
            }
            else
            {
                if (option2 == 1)
                    answer = "camaro";
                else
                    answer = "paperclip";
            }


            Console.WriteLine("My guess is that you are thinking of a:{0}", answer);

        }
    }
}
