using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSADistrictsV3
{
    class TeamMember
    {
        private string name;
        private string powerRank;
        private string teamId;

        public string Name { get => name; set => name = value; }
        public string PowerRank { get => powerRank; set => powerRank = value; }
        public string TeamId { get => teamId; set => teamId = value; }

        /// <summary>
        /// Builds a team member with a name, power rank and team id.
        /// </summary>
        /// <param name="memberName"></param>
        /// <param name="memberPowerRank"></param>
        /// <param name="memberTeamId"></param>
        public TeamMember(string memberName, string memberPowerRank, string memberTeamId)
        {
            Name = memberName;
            PowerRank = memberPowerRank;
            TeamId = memberTeamId;
        }
    }//End Class TeamMember
}//End Namespace