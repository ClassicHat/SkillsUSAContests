using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSADistrictsV3
{
    public class Battle
    {
        //Private Properties
        private int capWins;
        private int starkWins;
        private string civilWarBattleInfo;

        //Public Fields
        public string CivilWarBattleInfo { get => civilWarBattleInfo; set => civilWarBattleInfo = value; }
        public int CapWins { get => capWins; set => capWins = value; }
        public int StarkWins { get => starkWins; set => starkWins = value; }

        /****[ CivilWar Method ]*******************************
         * EXPECTS: The number of fighters in each battle, The
         *  number of battles for them to fight, and a randomly
         *  generated number.
         * RETURNS: Nothing
         * TASKS: Sets each teams wins to zero, loops through
         *  battles of the civil war. Calculates the winner and
         *  updates the wins for later use.
         ******************************************************/
        public void CivilWar(int numFighters, int numBattles, Random num)
        {
            //For each new civil war reset number of wins to 0
            CapWins = 0;
            StarkWins = 0;

            //loop for a number of battles
            for(int i = 0; i < numBattles; i++)
            {
                int winner = TheBattle(numFighters, num);

                if (winner == 0)
                {
                    StarkWins += 1;
                    CivilWarBattleInfo += "Winner Team Stark!;";
                }
                else if(winner == 1)
                {
                    CapWins += 1;
                    CivilWarBattleInfo += "Winner Team Cap!;";
                }
                else
                {
                    CivilWarBattleInfo += "Its A Tie;";
                }//End if / else if / else
            }//End for loop
        }//End Civil War

        public int TheBattle(int numFighters, Random num)
        {
            ArrayList memberListStark = new ArrayList();
            ArrayList memberListCap = new ArrayList();
            int winner = -1;
            //Create team stark
            Team stark = new Team(memberListStark, "stark");

            //Fill the team with fighters
            stark.FillTeam(numFighters, num, stark.TeamId, stark.TeamMemberList);

            //Calculate the teams power
            int starkPower = stark.CalcTeamPowerRank(stark.TeamMemberList);

            //Create team cap
            Team cap = new Team(memberListCap, "cap");

            //Fill the team with fighters
            cap.FillTeam(numFighters, num, cap.TeamId, cap.TeamMemberList);

            //Calculate the teams power
            int capPower = cap.CalcTeamPowerRank(cap.TeamMemberList);

            //Calculate the winner of the battle
            // return 0 for stark
            //return 1 for cap
            if(starkPower > capPower)
            {
                winner = 0;
            }
            else if (starkPower < capPower)
            {
                winner = 1;
            }//End if / else if
            else
            {
                winner = -1;
            }

            //Calculate the Battle Info String
            CivilWarBattleInfo += GetTeamData(stark.TeamMemberList);
            CivilWarBattleInfo += ";";
            CivilWarBattleInfo += GetTeamData(cap.TeamMemberList);
            CivilWarBattleInfo += ";";

            return winner;
        }//End TheBattle

        /****[ GetTeamData Method ]************************
         * EXPECTS: An arraylist of team members
         * RETURNS: A string of the teams info for display
         * TASKS: Loops through the list of team
         *  members and adds there name and power rank to 
         *  the string.
         **************************************************/
        public static string GetTeamData(ArrayList teamMemberList)
        {
            string info = "";
            int count = 0;
            //Create a string of information for team stark
            for (int i = 0; i < teamMemberList.Count; i++)
            {
                TeamMember member = (TeamMember)teamMemberList[i];
                info += ($"| {member.Name} {member.PowerRank} |");
                count += Convert.ToInt32(member.PowerRank);
            }//End for loop

            info += $"| Total: {count} |";
            return info;
        }//End PrintTeamData
    }//End Battle Class
}//End Namespace
