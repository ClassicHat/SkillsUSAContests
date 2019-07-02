using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSAClassPractice
{
    class Driver
    {
        public static void Main(string[] args)
        {
            int[] theArray = { 6, 7, 8, 9, 3, 5, 1, 8, 5, 7, 5, 2, 4, 6 };
            
            PrintArray(theArray);

            int bubble;  //temp variable to hold data

            for (int next = 0; next < theArray.Length - 1; next++)
            {
                for (int i = 0; i < theArray.Length - 1; i++)
                {
                    if (theArray[i] > theArray[i + 1])
                    {
                        bubble = theArray[i + 1];
                        theArray[i + 1] = theArray[i];
                        theArray[i] = bubble;
                    }//End if
                }//End for loop
                
            }//End for loop

            PrintArray(theArray);
            ////Variables
            //string ans;

            ////Prompt
            //Write("Please enter a positive whole number (-1 will return -1): ");
            //ans = ReadLine();

            //WriteLine("Answer Checker Returned: " + DataValidation.AnswerCheck(ans));

            ReadKey();
        }

        /****[ PrintArray ]**************************
         * Expects: An array of integers
         * Returns: Nothing
         * Tasks: Prints the array to the console.
         ********************************************/
        public static void PrintArray(int[] theArray)
        {
            foreach (int num in theArray)
            {
                Write(num + ", ");
            }

            WriteLine("\n\n\n");
        }
    }
}
