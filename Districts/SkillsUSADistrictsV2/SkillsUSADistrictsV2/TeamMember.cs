using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsUSADistrictsV2
{
    class TeamMember
    {
        private string name;
        private string powerRank;

        public string Name { get => name; set => name = value; }
        public string PowerRank { get => powerRank; set => powerRank = value; }

        //Default Constructor
        public TeamMember(string memberName, string memberPowerRank)
        {
            Name = memberName;
            PowerRank = memberPowerRank;
        }
    }//End Class TeamMember
}//End Namespace