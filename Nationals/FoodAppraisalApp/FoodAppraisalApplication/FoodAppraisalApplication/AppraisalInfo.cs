/***********************************
 * Contestant: 503
 * Program: 2
 * Title: Food Appraisal Program
 * Filename: AppraisalInfo.cs
 * Skills USA Nationals
 ***********************************/
using System.Collections;
using System.Windows.Forms;

namespace FoodAppraisalApplication
{
    class AppraisalInfo
    {
        //Private Feilds
        private CheckBox foodItemChkBx;
        private NumericUpDown foodItemNumUpDown;
        private ArrayList scoreArray;
        private Label currentAvg;
        private Label highScore;
        private Label lowScore;

        //Public Properties
        public CheckBox FoodItemChkBx { get => foodItemChkBx; set => foodItemChkBx = value; }
        public NumericUpDown FoodItemNumUpDown { get => foodItemNumUpDown; set => foodItemNumUpDown = value; }
        public ArrayList ScoreArray { get => scoreArray; set => scoreArray = value; }
        public Label CurrentAvg { get => currentAvg; set => currentAvg = value; }
        public Label HighScore { get => highScore; set => highScore = value; }
        public Label LowScore { get => lowScore; set => lowScore = value; }

        //Public Constructor
        //  Creates an instance of the Appraisal Info
        public AppraisalInfo(CheckBox chkBx, NumericUpDown numUpDwn, ArrayList scores, Label hScore, Label lScore, Label curtAvg)
        {
            FoodItemChkBx = chkBx;
            FoodItemNumUpDown = numUpDwn;
            ScoreArray = scores;
            HighScore = hScore;
            LowScore = lScore;
            CurrentAvg = curtAvg;
        }//End AppraisalInfo

    }//End Class AppraisalInfo
}//End Namespace
