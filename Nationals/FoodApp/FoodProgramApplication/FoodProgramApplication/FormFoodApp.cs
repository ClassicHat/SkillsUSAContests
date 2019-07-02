/***********************************
 * Contestant: 503
 * Program: 1
 * Title: Food Program
 * Filename: FormFoodApp
 * Skills USA Nationals
 ***********************************/
using System;
using System.Collections;
using System.Windows.Forms;

namespace FoodProgramApplication
{
    public partial class FormFoodApp : Form
    {
        //Public Variables
        public ArrayList FoodItemsList = new ArrayList();

        public FormFoodApp()
        {
            InitializeComponent();
        }//End FormFoodApp

        /****[ FormFoodApp_Load ]********************
         * Expects: Nothing - Called when program is started
         * Returns: Nothing
         * Tasks: Load needed data into an array for later use,
         *  Call the CreateFoodItems Method
         ********************************************/
        private void FormFoodApp_Load(object sender, EventArgs e)
        {
            //Create an array to hold the name and price of food items
            string[,] namePriceArray = new string[,] { { "Cheeseburger Deluxe", "5.00" }, {"Cheeseburger", "4.00" },
            {"Hamburger", "3.00" }, {"Fries", "2.00" }, {"Soda", "2.00" }, {"Water", "0.00" } };

            //Adds the food items to the form
            CreateFoodItems(namePriceArray);
        }//End FormFoodApp_Load

        /****[ CreateFoodItems ]*********************
         * Expects: string[,] Array containing names and prices
         * Returns: Nothing
         * Tasks: Instantiate the nessisary items to create
         *  a foodItem. Then it throughs all the food items into
         *  an array for later use.
         ********************************************/
        public void CreateFoodItems(string[,] namePriceArray)
        {
            //Variables
            CheckBox checkBox;
            int drawPoint = 150;
            NumericUpDown numericUpDown;
            FoodItem item;
            
            //A for loop that creates food items
            for (int i = 0; i < namePriceArray.Length / 2; i++)
            {
                //Instatiates a checkBox
                checkBox = new System.Windows.Forms.CheckBox();
                checkBox.AutoSize = true;
                checkBox.Location = new System.Drawing.Point(90, drawPoint);
                checkBox.Text = namePriceArray[i, 0] + " - $" + namePriceArray[i, 1];
                checkBox.UseVisualStyleBackColor = true;
                Controls.Add(checkBox);

                //Instatiate numUpDown
                numericUpDown = new System.Windows.Forms.NumericUpDown();
                numericUpDown.Location = new System.Drawing.Point(400, drawPoint);
                Controls.Add(numericUpDown);
                drawPoint += 30;

                //Create an instance of a food Item
                item = new FoodItem(checkBox, namePriceArray[i, 0], Convert.ToDouble(namePriceArray[i, 1]), numericUpDown);

                //Add food item to an array
                FoodItemsList.Add(item);
            }//End for loop
        }//End CreateFoodItems

        /****[ btnCalculate ]***********************
         * Expects: the Calculate button to be clicked
         * Returns: nothing
         * Tasks: loop through all the food items and
         *  calculate the customers total and update
         *  the days running total.
         *******************************************/
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Variables
            double customerTotal = 0;

            //Loop through all items for sale
            foreach(FoodItem item in FoodItemsList)
            {
                //Check if any items are checked
                if(item.FoodItemChkBx.Checked == true)
                {
                    //Check if the quantity specified is not 0
                    if(item.FoodItemUpDwn.Value != 0)
                    {
                        //Adds the value of the items to the total
                        customerTotal += (item.ItemPrice * (double) item.FoodItemUpDwn.Value);
                    }//End if
                }//End if
            }//End foreach loop

            //Updates the total for the current custormer
            lblCustomerTotal.Text = customerTotal.ToString("c");

            //Update the Running total
            double runTotal = Convert.ToDouble(lblRunningTotal.Text.TrimStart('$'));
            runTotal += customerTotal;
            lblRunningTotal.Text = runTotal.ToString("c");

            //Turn off items for sale
            //false = off
            //true = on
            ItemsForSaleOnOff(false);

        }//End btnCalculate

        /****[ ItemsForSaleOnOff ]********************
         * Expects: bool - on = true / off = false
         * Returns: nothing
         * Tasks: Turn form controls on of off when called
         *********************************************/
        public void ItemsForSaleOnOff(bool onOff)
        {
            //loops through each item
            foreach(FoodItem item in FoodItemsList)
            {
                item.FoodItemChkBx.Enabled = onOff;
                item.FoodItemUpDwn.Enabled = onOff;
            }//End foreach

            //Turns Calculate btn on or off
            btnCalculate.Enabled = onOff;
        }//End ItemsForSaleOnOff

        /****[ btnClear ]**************************
         * Expects: The Clear button to be clicked
         * Returns: Nothing
         * Tasks: Reset the form for another customer
         ******************************************/
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Turn on items for sale
            ItemsForSaleOnOff(true);

            //loops through each item
            foreach (FoodItem item in FoodItemsList)
            {
                //Resets the food items
                item.FoodItemChkBx.Checked = false;
                item.FoodItemUpDwn.Value = 0;
            }//End foreach

            //Turn on btnCalculate
            btnCalculate.Enabled = true;

            //Reset Customer Total
            lblCustomerTotal.Text = 0.ToString("c");

        }//End btnClear

        /****[ btnExit ]**********************
         * Expects: the Exit btn to be clicked
         * Returns: Nothing
         * Tasks: End the application
         *************************************/
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the application
            Application.Exit();
        }//End btnExit
    }//End Class
}//End Namespace