using System;
using static System.Console;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSADistrictsV2
{
    class Driver
    {
        static void Main(string[] args)
        {
            //Random Number Generator placed here so we are always using the same one
            Random num = new Random();
            int starkBattleWins = 0;
            int capBattleWins = 0;
            Tuple<int, string> namePower = new Tuple<int, string>(5, "Dylan");
            /****[ Begin Main Method ]****/
            Write("How many fighters per team? 1 - 6 are valid answers: ");
            int numFighters = Convert.ToInt32(ReadLine());

            Write("How many battles should they fight? 1 - 10 are valid answers: ");
            int numBattles = Convert.ToInt32(ReadLine());
            WriteLine();

            for (int i = 0; i < numBattles; i++)
            {
                int winner = BattleGenerator(numFighters, num);

                if(winner == 0)
                {
                    starkBattleWins += 1;
                }
                else if (winner == 1)
                {
                    capBattleWins += 1;
                }//End if / else if
            }//End for loop

            CalcWarWinner(starkBattleWins, capBattleWins);
            
            //To Stop The Flow Of Code
            ReadKey();
        }
        
        /****[ BattleGenerator Method ]****************
         * EXPECTS: The number of team members, and a
         *  random number.
         * RETURNS: Nothing
         * TASKS:
         **********************************************/
        public static int BattleGenerator(int numOfMembers, Random num)
        {
            //These two paraelle arrays are for holding data for later use
            //Similar to a data base and pulling data from it.
            string[,] teamStark = new string[,] { {"Black Widow", "10"}, { "War Machine", "20" }, { "Spider Man", "30" },
                                                  {"Black Panther", "40"}, {"Iron Man", "50"}, {"Vision", "60"}};

            string[,] teamCap = new string[,] { {"Hawkeye", "10"}, { "Falcon", "20" }, { "Ant-Man", "30" },
                                                {"Winter Soldier", "40"}, {"Captain America", "50"}, {"Scarlet Witch", "60"}};
            
            //Create Team Stark
            ArrayList stark = CreateTeam(numOfMembers, num, teamStark);
            int starkPower = CalcTeamPowerRank(stark);
            //Create Team Cap
            ArrayList cap = CreateTeam(numOfMembers, num, teamCap);
            int capPower = CalcTeamPowerRank(cap);

            //Print Team Stark
            WriteLine("--------[ Team Stark ]--------\n");
            PrintTeamData(stark);

            //Print Team Cap
            WriteLine("---------[ Team Cap ]---------\n");
            PrintTeamData(cap);

            //Get the winner of the battle
            int winner = CalcBattleWinner(starkPower, capPower);

            return winner;
        }
        
        /****[ CreateTeam Method ]*********************
         * EXPECTS: The number of people on the team,
         *  a random number, and the teams information.
         * RETURNS: An arraylist of team members that
         *  are on the team and ready for battle.
         * TASKS: Create an arraylist to hold all the
         *  team members. Then create the number of
         *  team members specified. Do this by getting
         *  a random number, using that number to access
         *  out data in the paraelle array. Create a
         *  team member using the constructor. Call the
         *  'AddTeamMember' method to validate the team
         *  member. Return the list of team members for
         *  the battle.
         **********************************************/
        public static ArrayList CreateTeam(int numOfMembers, Random num, string[,] teamInfo)
        {
            //Declare an array list
            ArrayList teamMembers = new ArrayList();

            for (int i = 0; i < numOfMembers; i++)
            {
                bool memberAdded = false;

                while (memberAdded == false)
                {
                    //Generate a number
                    int arrayNum = num.Next(0, 6);

                    //Create a team member
                    TeamMember member = new TeamMember(teamInfo[arrayNum, 0], teamInfo[arrayNum, 1]);

                    //Call the add member method of the team class
                    memberAdded = AddTeamMember(member, teamMembers);
                }//End While
            }//End for loop

            return teamMembers;
        }//End Create Team

        /****[ AddTeamMember Method ]******************
         * EXPECTS: A new team member to add to the
         *  team and the list of current team members.
         * RETURNS: A bool true - Member was added to
         *  the team. bool false - Member is already on
         *  the team and we need to try again.
         * TASKS: Check if the new team member is on
         *  the team, if the new team member is return
         *  false and if not return true and also add
         *  the new team member to the list of team
         *  members.
         **********************************************/
        public static bool AddTeamMember(TeamMember memberToAdd, ArrayList teamMembers)
        {
            bool memberExists = false;

            for (int i = 0; i < teamMembers.Count; i++)
            {
                TeamMember currentTeamMember = (TeamMember) teamMembers[i];
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
                teamMembers.Add(memberToAdd);
                //true because the member was added to the team
                return true;
            }//End if / else
        }//End AddTeamMember
        
        /****[ PrintTeamData Method ]******************
         * EXPECTS: An arraylist of team members
         * RETURNS: Nothing
         * TASKS: Loops through the list of team
         *  members and prints there name and power rank
         **********************************************/
        public static void PrintTeamData(ArrayList teamMemberList)
        {
            for (int i = 0; i < teamMemberList.Count; i++)
            {
                TeamMember member = (TeamMember)teamMemberList[i];
                Write($"| {member.Name} {member.PowerRank} |");
            }
            WriteLine("\n");
        }//End PrintTeamData
        
        /****[ CalcTeamPowerRank Method ]**************
         * EXPECTS: The list of team members
         * RETURNS: The total power rank of the team
         * TASKS: Loop through the entire team adding
         *  up the total power rank for the team and
         *  then return the total score.
         **********************************************/
        public static int CalcTeamPowerRank(ArrayList team)
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
        
        /****[ CalcBattleWinner Method ]***************
         * EXPECTS: Starks total power rank and caps
         *  total power rank.
         * RETURNS: A int where -1 is a tie, 0 stark
         *  wins, and 1 cap wins.
         * TASKS: Calculate who won the battle by
         *  comparing the two teams power ranks.
         **********************************************/
        public static int CalcBattleWinner(int starkPower, int capPower)
        {
            if(starkPower == capPower)
            {
                WriteLine("*********[ It's A Tie ]*********");
                WriteLine($"Team Stark: {starkPower.ToString()} Vs Team Cap: {capPower.ToString()}");
                WriteLine("********************************\n");
                return -1;
            }
            else if(starkPower > capPower)
            {
                WriteLine("****[ Team Stark Wins ]*********");
                WriteLine($"Team Stark: {starkPower.ToString()} Vs Team Cap: {capPower.ToString()}");
                WriteLine("********************************\n");
                return 0;
            }
            else
            {
                WriteLine("******[ Team Cap Wins ]*********");
                WriteLine($"Team Stark: {starkPower.ToString()} Vs Team Cap: {capPower.ToString()}");
                WriteLine("********************************\n");
                return 1;
            }//End if / else if / else
        }//End CalcBattleWinner

        public static void CalcWarWinner(int starkWins, int capWins)
        {
            if (starkWins == capWins)
            {
                WriteLine("******[ The War Is A Tie ]******");
                WriteLine($"Team Stark: {starkWins.ToString()} Vs Team Cap: {capWins.ToString()}");
                WriteLine("********************************\n");
            }
            else if (starkWins > capWins)
            {
                WriteLine("**[ Team Stark Wins The War ]***");
                WriteLine($"Team Stark: {starkWins.ToString()} Vs Team Cap: {capWins.ToString()}");
                WriteLine("********************************\n");
            }
            else
            {
                WriteLine("***[ Team Cap Wins The War ]****");
                WriteLine($"Team Stark: {starkWins.ToString()} Vs Team Cap: {capWins.ToString()}");
                WriteLine("********************************\n");
            }//End if / else if / else
        }
    }//End Class
}//End Namespace  
                  