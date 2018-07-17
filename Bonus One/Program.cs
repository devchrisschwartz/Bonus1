using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_One
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Letter Grade Converter!");

            string ContinueUserInput;

            do
            {

                Console.Write("Please enter a numerical grade: ");
                string GradeInput = Console.ReadLine();
                int GradeNumber;
                Int32.TryParse(GradeInput, out GradeNumber);

                LetterGradeConversion(GradeNumber);

                Console.Write("Would you like to convert another grade? (Y/N): ");
                ContinueUserInput = Console.ReadLine();

            } while (ContinueUserInput.Equals("Y", StringComparison.InvariantCultureIgnoreCase));
        }

        public static void LetterGradeConversion(int GradeInput)
        {
            if (GradeInput >= 97 && GradeInput <= 100)
            {
                Console.WriteLine("Letter Grade: A+");
            }
            else if (GradeInput >=93)
            {
                Console.WriteLine("Letter Grade: A");
            }
            else if (GradeInput >= 90)
            {
                Console.WriteLine("Letter Grade: A-");
            }
            else if (GradeInput >= 87)
            {
                Console.WriteLine("Letter Grade: B+");
            }
            else if (GradeInput >= 83)
            {
                Console.WriteLine("Letter Grade: B");
            }
            else if (GradeInput >= 80)
            {
                Console.WriteLine("Letter Grade: B-");
            }
            else if (GradeInput >= 77)
            {
                Console.WriteLine("Letter Grade: C+");
            }
            else if (GradeInput >= 73)
            {
                Console.WriteLine("Letter Grade: C");
            }
            else if (GradeInput >= 70)
            {
                Console.WriteLine("Letter Grade: C-");
            }
            else if (GradeInput >= 67)
            {
                Console.WriteLine("Letter Grade: D+");
            }
            else if (GradeInput >= 63)
            {
                Console.WriteLine("Letter Grade: D");
            }
            else if (GradeInput >= 61)
            {
                Console.WriteLine("Letter Grade: D-");
            }
            else
            {
                Console.WriteLine("Letter Grade: F");
            }
        }
    }
}
