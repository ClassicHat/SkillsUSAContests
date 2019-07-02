/********************************
 * Name: Dylan Buehler
 * Date: 2/6/2019
 * FileName: Driver.cs
 * Copyright: SkillsUSA 2019
 ********************************/
using System;
using System.Collections;
using static System.Console;

namespace MarvelCivilWar
{
    class Driver
    {
        /****[ Main ]***************************
         * Expects: Nothing
         * Returns: Nothing
         * Tasks: Control the settings for the
         * civil war, loops until the user says
         * otherwise, and display the winner.
         ***************************************/
        static void Main(string[] args)
        {
            //Variables
            int numOfMembers = 4;
            int numOfBattles = 5;
            int winnerNum;
            string continueYN = "Y";

            //Instantiate the random number generator
            Random randNum = new Random();

            //Instantiate the two array lists
            ArrayList teamCap = new ArrayList();
            ArrayList teamStark = new ArrayList();

            while (continueYN == "Y")
            {
                //Variables to reset each loop
                int capWin = 0;
                int starkWin = 0;
                int completedBattles = 0;

                Write("How many combatants from each team do you want. Valid numbers are 1 - 6 : ");
                numOfMembers = DataValidation.ValidateData(ReadLine(), 6, 4);

                Write("How many battles should they fight? Valid numbers are 1 - 10: ");
                numOfBattles = DataValidation.ValidateData(ReadLine(), 10, 5);

                while (numOfBattles != completedBattles)
                {
                    teamCap = TeamCap.ChooseMembers(numOfMembers, randNum);
                    teamStark = TeamStark.ChooseMembers(numOfMembers, randNum);
                    Write("Team Stark: ");
                    PrintArrayList(teamStark);
                    Write("Team Cap: ");
                    PrintArrayList(teamCap);
                    winnerNum = CalculateWinner(teamCap, teamStark);

                    if (winnerNum == -1)
                    {
                        capWin++;
                    }
                    else
                    {
                        starkWin++;
                    }//End if / else

                    WriteLine("\n\n");
                    completedBattles++;
                } //End While

                CalcWarWinner(starkWin, capWin);

                Write("Continue Y / N : ");
                continueYN = DataValidation.ValidYN(ReadLine());
                WriteLine("\n\n");
            }//End while
        }//End Main Method

        /****[ PrintArrayList ]************************
         * Expects: the team arraylist
         * Returns: Nothing
         * tasks: Print the elements in the array list
         **********************************************/
        public static void PrintArrayList(ArrayList team)
        {
            foreach (string member in  team)
            {
                Write($"|{member}| ");
            }//End foreach loop
            WriteLine();
        }//End PrintArrayList

        /****[ CalculateWinner ]*****************************
         * Expects: the teams arraylists for cap and stark,
         * and capWins and starkWins.
         * Returns: Nothing
         * Tasks: compare the scores and declare the winner.
         ****************************************************/
        public static int CalculateWinner(ArrayList teamCap, ArrayList teamStark)
        {
            int scoreStark = Convert.ToInt32(teamStark[teamStark.Count-1]);
            int scoreCap = Convert.ToInt32(teamCap[teamCap.Count-1]);

            // -1 returns that cap won
            //  1 returns that stark won
            if (scoreCap > scoreStark)
            {
                WriteLine("Team Cap Wins The Battle");
                return -1;
            }
            else
            {
                WriteLine("Team Stark Wins The Battle");
                return 1;
            }//End if / else
        }//End CalculateWinner

        /****[ CalcWarWinner ]***********************************
         * Expects: the number of wins stark had and
         * the number of wins cap had.
         * Returns: Nothing
         * Tasks: compares the win numbers and displays a winner.
         ********************************************************/
        public static void CalcWarWinner(int starkWin, int capWin)
        {
            if (starkWin > capWin)
            {
                WriteLine("***********************************************");
                WriteLine("* THE WINNER OF THE CIVIL WAR IS STARK'S TEAM *");
                WriteLine($"*        TEAM STARK: {starkWin} VS. TEAM CAP: {capWin}        *");
                WriteLine("***********************************************");
            }
            else if (capWin > starkWin)
            {
                WriteLine("***********************************************");
                WriteLine("* THE WINNER OF THE CIVIL WAR IS CAP'S TEAM   *");
                WriteLine($"*        TEAM CAP: {capWin} VS. TEAM STARK: {starkWin}        *");
                WriteLine("***********************************************");
            }
            else
            {
                WriteLine("***********************************************");
                WriteLine("* THE WINNER OF THE CIVIL WAR IS A TIE        *");
                WriteLine($"*        TEAM CAP: {capWin} VS. TEAM STARK: {starkWin}        *");
                WriteLine("***********************************************");
            }//End if / else if / else
        }//End CalcWarWinner

    }//End Class Driver
}//End Namespace MarvelCivilWar
