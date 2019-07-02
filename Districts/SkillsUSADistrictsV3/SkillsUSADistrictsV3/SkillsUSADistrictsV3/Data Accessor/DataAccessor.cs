using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSADistrictsV3
{
    class DataAccessor
    {
        /****[ GetData ]****************************************
         * Expects: Int 0 or 1 - 0 is team stark, 1 is team cap
         * Returns: A paraelle array with a teams information
         * Tasks: Hold and return each teams data for later use
         *******************************************************/
        public static string[,] GetData(string teamInfoName)
        {
            //All information pertaining to team stark
            string[,] teamStarkInfo = new string[,] { {"Black Widow", "10"}, { "War Machine", "20" }, { "Spider Man", "30" },
                                                  {"Black Panther", "40"}, {"Iron Man", "50"}, {"Vision", "60"}};
            //All information pertaining to team cap
            string[,] teamCapInfo = new string[,] { {"Hawkeye", "10"}, { "Falcon", "20" }, { "Ant-Man", "30" },
                                                {"Winter Soldier", "40"}, {"Captain America", "50"}, {"Scarlet Witch", "60"}};
            //Used to return the information for one of the two teams
            if(teamInfoName == "stark")
            {
                return teamStarkInfo;
            }
            else
            {
                return teamCapInfo;
            }//End if / else
        }//End GetData Method
    }//End Class DataAccessor
}//End Namespace