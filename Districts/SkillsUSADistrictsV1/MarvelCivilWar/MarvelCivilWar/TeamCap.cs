/********************************
 * Name: Dylan Buehler
 * Date: 2/6/2019
 * FileName: TeamCap.cs
 * Copyright: SkillsUSA 2019
 ********************************/
using System;
using System.Collections;

namespace MarvelCivilWar
{
    class TeamCap
    {
        /****[ ChooseMembers ]*********************************
         * Expects: The total number of memebers for the theam
         * Returns: An arraylist of team members.
         * Tasks: Given the total amount of members on a team,
         * the method picks a random number then looks at that
         * location in the teamCapArray. If the member is on
         * theTeam then it picks again and if they are not the
         * member is added. It picks members until the amount
         * of members is reached. Then returns the arraylist.
         ******************************************************/
        public static ArrayList ChooseMembers(int numOfMembers, Random randNum)
        {
            //Variables
            string posTeamMember;
            int needNewMember = 0;
            bool memberOnTeam = false;
            int num;
            int totalScore = 0;

            //Instantiate the teamCapArray
            string[] teamCapArray = { "Hawkeye", "Falcon", "Ant-Man", "Winter Soldier", "Captain America", "Scarlet Witch" };

            //Instantiate theTeamArray
            ArrayList theTeam = new ArrayList();
            
            for (int i = 0; i < numOfMembers; i = needNewMember)
            {
                num = randNum.Next(0, 6);
                posTeamMember = teamCapArray[num];

                foreach (string member in theTeam)
                {
                    if (posTeamMember == member)
                    {
                        memberOnTeam = true;
                    }//End if

                }//End foreach loop

                if (memberOnTeam == false)
                {
                    theTeam.Add(posTeamMember);
                    needNewMember++;
                    totalScore = TeamScore(num, totalScore);
                }//End if

                memberOnTeam = false;
            }//End for loop

            theTeam.Add(Convert.ToString(totalScore));
            return theTeam;

        }//End ChooseMembers

        /****[ TeamScore ]*************************
         * Expects: The number randomly generated
         * Returns: The teams total score
         * Tasks: Add 1 to the generated number and
         * add a 0. then return the total score.
         ******************************************/
        public static int TeamScore(int memberScore, int totalScore)
        {
            memberScore += 1;
            memberScore = Convert.ToInt32($"{memberScore}0");
            totalScore += memberScore;

            return totalScore;
        }//End TeamScore
    }//End Class TeamCap
}//End Namespace MarvelCivilWar
