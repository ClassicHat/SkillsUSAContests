/***********************************
 * Contestant: 503
 * Program: 2
 * Title: Food Appraisal Program
 * Filename: FormFoodAppraisal
 * Skills USA Nationals
 ***********************************/
using System;
using System.Collections;
using System.Windows.Forms;

namespace FoodAppraisalApplication
{
    public partial class FormFoodAppraisal : Form
    {
        //Variables
        ArrayList AppraisalInfoList = new ArrayList();

        public FormFoodAppraisal()
        {
            InitializeComponent();
        }

        /****[ FormFoodApp_Load ]********************
         * Expects: Nothing - Called when program is started
         * Returns: Nothing
         * Tasks: Load needed data into an array for later use,
         *  Call the CreateFoodItems Method
         ********************************************/
        private void FormFoodAppraisal_Load(object sender, EventArgs e)
        {
            //Create an array to hold the name and price of food items
            string[] namePriceArray = new string[] {"Cheeseburger Deluxe","Cheeseburger","Hamburger","Fries","Soda" };

            //Adds the food items to the form
            CreateFoodItems(namePriceArray);
        }

        /****[ CreateFoodItems ]*********************
         * Expects: string[] Array containing names
         * Returns: Nothing
         * Tasks: Instantiate the nessisary items to create the
         * appraisalInfo for each food item.
         ********************************************/
        public void CreateFoodItems(string[] namePriceArray)
        {
            //Variables
            CheckBox checkBox;
            int drawPoint = 150;
            NumericUpDown numericUpDown;
            AppraisalInfo info;
            ArrayList scoreList;
            Label label;

            //A for loop that creates food items
            for (int i = 0; i < namePriceArray.Length; i++)
            {
                //Instatiates a checkBox
                checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(15, drawPoint);
                checkBox.Text = namePriceArray[i];
                checkBox.UseVisualStyleBackColor = true;
                Controls.Add(checkBox);

                //Instatiate numUpDown
                numericUpDown = new System.Windows.Forms.NumericUpDown();
                numericUpDown.Location = new System.Drawing.Point(250, drawPoint);
                numericUpDown.Minimum = new decimal(new int[] {1,0,0,0});
                numericUpDown.Value = new decimal(new int[] {100,0,0,0});
                Controls.Add(numericUpDown);

                //Instatiate Avg Lables
                label = new Label();
                Label lblAvg = DrawLabels(440, drawPoint, label, "100");

                //Instatiate High Score Lables
                label = new Label();
                Label lblHScore = DrawLabels(562, drawPoint, label, "0");

                //Instatiate Low Score Lables
                label = new Label();
                Label lblLScore = DrawLabels(673, drawPoint, label, "100");

                //Create a new arraylist to hold scores
                scoreList = new ArrayList();

                //Create an instance of an Appraisal Info
                info = new AppraisalInfo(checkBox, numericUpDown, scoreList, lblHScore, lblLScore, lblAvg);

                //Add The Appraisal Info to a ArrayList
                AppraisalInfoList.Add(info);

                //Add 30 to the draw point
                drawPoint += 30;
            }//End for loop
        }//End CreateFoodItems

        /****[ DrawLabels ]*******************
         * Expects: drawPointX, drawPointY, a label, label text
         * Returns: The Created label
         * Tasks: Using the provided information create, and add
         *  the label to the form, then return the created label
         *  for later use.
         *************************************/
        public Label DrawLabels(int drawPointX, int drawPointY,  Label label, string txt)
        {
            //Instatiates a Label and adds it to the form
            label.AutoSize = true;
            label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new System.Drawing.Point(drawPointX, drawPointY);
            label.Text = txt;
            Controls.Add(label);
            return label;
        }//End DrawLabels

        /****[ btnCalculate ]*********************
         * Expects: The calculate btn to be clicked
         * Returns: Nothing
         * Tasks: Calculate the average, high score and
         *  low score for all entries that are checked
         *****************************************/
        private void btnCalcuate_Click(object sender, EventArgs e)
        {
            //Turn appraisals OFF
            AppraisalOnOff(false);

            //Loop through all appraisal information
            foreach(AppraisalInfo info in AppraisalInfoList)
            {
                //Check if the customer reviewed this food item
                if(info.FoodItemChkBx.Checked == true)
                {
                    //Add the score to the score array
                    info.ScoreArray.Add(info.FoodItemNumUpDown.Value);
                    
                    //Check if the score is a high score
                    if((int)info.FoodItemNumUpDown.Value > Convert.ToInt32(info.HighScore.Text))
                    {
                        //Set the new high score
                        info.HighScore.Text = info.FoodItemNumUpDown.Value.ToString();
                    }//End if

                    //Check if the score is a low score
                    if((int)info.FoodItemNumUpDown.Value < Convert.ToInt32(info.LowScore.Text))
                    {
                        //Set the new low score
                        info.LowScore.Text = info.FoodItemNumUpDown.Value.ToString();
                    }//End if

                    int avg = 0;

                    //Loop each number to get a total for calculating the average
                    for (int i = 0; i < info.ScoreArray.Count; i++)
                    {
                        //Get a total to calculate the average with
                        avg += Convert.ToInt32(info.ScoreArray[i]);
                    }//End for loop

                    //Calculates the avg
                    avg = avg / info.ScoreArray.Count;

                    //Set the average on the form
                    info.CurrentAvg.Text = avg.ToString();

                }//End if
            }//End foreach loop
        }//End btnCalculate

        /****[ btnClear ]**********************
         * Expects: the clear btn to be clicked
         * Returns: Nothing
         * Tasks: Clears the appraisal board for
         *  another customer
         **************************************/
        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(AppraisalInfo info in AppraisalInfoList)
            {
                info.FoodItemChkBx.Checked = false;
                info.FoodItemNumUpDown.Value = 100;
            }//End foreach

            //Turn appraisal items back ON
            AppraisalOnOff(true);
        }//End btnClear

        /****[ AppraisalOnOff ]***********************
         * Expects: bool 'ON' = true / 'OFF' = false
         * Returns: Nothing
         * Tasks: Turns all form items related to apraisal
         *  on or off
         *********************************************/
        public void AppraisalOnOff(bool onOff)
        {
            //Loop through all appraisals and turn them on or off
            foreach (AppraisalInfo info in AppraisalInfoList)
            {
                info.FoodItemChkBx.Enabled = onOff;
                info.FoodItemNumUpDown.Enabled = onOff;
            }//End foreach

            //Turn btnCalculate on or off
            btnCalcuate.Enabled = onOff;

        }//End AppraisalOnOff

        /****[ btnExit ]******************************
         * Expects: the exit btn to be clicked
         * Returns: Nothing
         * Tasks: Close the program
         *********************************************/
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Close the application
            Application.Exit();
        }//End btnExit
    }//End Class
}//End Namespace