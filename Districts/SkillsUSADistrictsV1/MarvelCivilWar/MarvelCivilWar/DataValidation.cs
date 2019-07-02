using System;
using static System.Console;

namespace MarvelCivilWar
{
    class DataValidation
    {
        /****[ ValidateData ]*************************
         * Expects: the users first answer
         * Returns: a valid answer
         * Tasks: Validate the users input.
         *********************************************/
        public static int ValidateData(string userAnswer , int maxValue, int defaultNum)
        {
            //Variables
            int result = 0;
            bool valid = false;

            if (userAnswer != "")
            {
                while (valid == false)
                {
                    if (int.TryParse(userAnswer, out result) == false)
                    {
                        Write($"Invalid input! Please enter a number between 1 and {maxValue}: ");
                        userAnswer = ReadLine();
                    }
                    else
                    {
                        if (result <= maxValue && result >= 1)
                        {
                            valid = true;
                        }
                        else
                        {
                            Write($"Invalid input! Please enter a number between 1 and {maxValue}: ");
                            userAnswer = ReadLine();
                        } //End if / else
                    } //End if / else
                } //End While loop
            }
            else
            {
                result = defaultNum;
            }

            WriteLine();
            return result;
        }//End ValidateData

        /***************************************
         * Expects: the users answer
         * Returns: the valid user answer
         * Tasks: validates the input.
         ***************************************/
        public static string ValidYN(string userAnswer)
        {
            bool notValidAnswer = true;

            while (notValidAnswer)
            {
                userAnswer = userAnswer.ToUpper();

                if (userAnswer == "Y" || userAnswer == "N")
                {
                    notValidAnswer = false;
                }
                else
                {
                    Write("Continue Y / N : ");
                    userAnswer = ReadLine();
                }//End if / else
            }//End while

            return userAnswer;
        }//End ValidYN
    }//End Class DataValidation
}//End Namespace MarvelCivilWar
