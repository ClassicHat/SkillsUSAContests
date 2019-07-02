using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSADistrictsV3
{
    class Team
    {
        private ArrayList teamMemberList;
        private string teamId;
        private TeamMember member;

        public ArrayList TeamMemberList { get => teamMemberList; set => teamMemberList = value; }
        public string TeamId { get => teamId; set => teamId = value; }
        public TeamMember Member { get => member; set => member = value; }

        /// <summary>
        /// Builds a Team with an arraylist to hold the members, a team Id and the number of wins
        /// </summary>
        /// <param name="memberList"></param>
        /// <param name="teamId"></param>
        /// <param name="numberWins"></param>
        public Team(ArrayList memberList, string teamId)
        {
            TeamMemberList = memberList;
            TeamId = teamId;
        }//End Team Constructor

        /****[ FillTeam Method ]*******************************
         * EXPECTS: The number of fighters, a random number, and
         *  the team Id.
         * RETURNS: Nothing
         * TASKS: Fill the teams with fighters.
         ***********************************************************/
        public void FillTeam(int numFighters, Random num, string teamId, ArrayList memberList)
        {
            //Get the teams general info from data accessor
            string[,] teamInfo = DataAccessor.GetData(teamId);

            //Loops untill the number of fighters is reached / created
            for(int i = 0; i < numFighters; i++)
            {
                bool memberAdded = false;

                while (memberAdded == false)
                {
                    //Generate a number
                    int arrayNum = num.Next(0, 6);

                    //Create a team member
                    TeamMember member = new TeamMember(teamInfo[arrayNum, 0], teamInfo[arrayNum, 1], teamId);
                    
                    //Call the add member method of the team class
                    memberAdded = AddTeamMember(member, memberList);
                }//End While
            }//End for loop
        }//End FillTeam Method

        /****[ AddTeamMember Method ]*******************************
         * EXPECTS: A new team member to add to the team
         * RETURNS: A bool true or false
         * TASKS: Adds the team member to the list if the member is
         *  not on the team.
         ***********************************************************/
        public bool AddTeamMember(TeamMember memberToAdd, ArrayList teamMemberList)
        {
            bool memberExists = false;

            //Checking if the member in the list exists or not
            for (int i = 0; i < teamMemberList.Count; i++)
            {
                TeamMember currentTeamMember = (TeamMember)TeamMemberList[i];
                if (memberToAdd.Name == currentTeamMember.Name)
                {
                    memberExists = true;
                }//End if
            }//End for loop

            if (memberExists == true)
            {
                //false because the team member is on the team so we need to try again
                return false;
            }
            else
            {
                TeamMemberList.Add(memberToAdd);
                //true because the member was added to the team
                return true;
            }//End if / else
        }//End AddTeamMember

        /****[ CalcTeamPowerRank Method ]**************
         * EXPECTS: The list of team members
         * RETURNS: The total power rank of the team
         * TASKS: Loop through the entire team adding
         *  up the total power rank for the team and
         *  then return the total score.
         **********************************************/
        public int CalcTeamPowerRank(ArrayList team)
        {
            int totalScore = 0;

            for (int i = 0; i < team.Count; i++)
            {
                TeamMember member = (TeamMember)team[i];
                //Gets each members power rank
                totalScore += Convert.ToInt32(member.PowerRank);
            }
            return totalScore;
        }//End CalcTeamPowerRank
    }//End Team Class
}//End namespace