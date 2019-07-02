using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSAClassPractice
{
    class DataValidation
    {
        public static int AnswerCheck(string answer)
        {
            int intNumber = 0;
            bool valid = true;

            while (valid)
            {
                // Checks if the value entered is a integer
                // Integer 'NO' goes to if statement
                // Integer 'YES' goes to else statement
                if (int.TryParse(answer, out intNumber) == false)
                {
                    Write("Invalid input. ");
                    Write("Please enter a positive whole number (-1 will return -1): ");
                    answer = ReadLine();
                }
                else
                {
                    intNumber = Convert.ToInt32(answer);
                    // Checks if the value is a negative number starting at 0
                    if (intNumber <= 0)
                    {
                        if (intNumber == -1)
                        {
                            valid = false;
                        }
                        else
                        {
                            Write("Invalid input. ");
                            Write("Please enter a positive whole number (-1 will return -1): ");
                            answer = ReadLine();
                        }
                    }
                    else
                    {
                        valid = false;
                    }
                }
            }
            return intNumber;
        }//End Answer Checker
    }
}
