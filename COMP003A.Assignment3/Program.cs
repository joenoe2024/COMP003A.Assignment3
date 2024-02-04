/*
 * Author: Joseph sandoval
 * Course: COMP003A-l01
 * Purpose: Conditional statements 
 */

namespace COMP003A.Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numeric to letter grade using an if-else statement");
            Console.WriteLine("enter a numeric grade (0-100)");
            double numericGrade = Convert.ToDouble(Console.ReadLine());

            if (numericGrade >= 100)
            {
                Console.WriteLine("Letter Grade:A+");
            }
            else if (numericGrade >= 90)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (numericGrade >= 80)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (numericGrade >= 70)
            {
                Console.WriteLine("Letter grade: C");
            }
            else if (numericGrade >= 60)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else if (numericGrade >= 50)
            {
                Console.WriteLine("Letter Grade: f");
            }

            /*****************************************************************/
            Console.WriteLine("Enter an integer day of the week (1-7)");
            int numericDay = Convert.ToInt32(Console.ReadLine());

            switch (numericDay)
            {
                case 1: Console.WriteLine("End of the World Monday"); break;
                    case 2: Console.WriteLine("Kill me Tuesday"); break;
                    case 3: Console.WriteLine("Hopeful Wednesday"); break;
                    case 4: Console.WriteLine("Depression Thursday"); break;
                    case 5: Console.WriteLine("Happy Hour Friday"); break;
                    case 6: Console.WriteLine("Saturday"); break;
                    case 7: Console.WriteLine("Lazy Sunday"); break;
                    default: Console.WriteLine("INVALID INPUT"); break;


            }
  
            
        }
    }
}
