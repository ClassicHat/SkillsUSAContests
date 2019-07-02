/***********************************
 * Contestant: 503
 * Program: 1
 * Title: Food Program
 * Filename: FoodItems.cs
 * Skills USA Nationals
 ***********************************/
using System.Windows.Forms;

namespace FoodProgramApplication
{
    class FoodItem
    {
        //Private Class Feilds
        private CheckBox foodItemChkBx;
        private string itemName;
        private double itemPrice;
        private NumericUpDown foodItemUpDwn;

        //Public Properties
        public CheckBox FoodItemChkBx { get => foodItemChkBx; set => foodItemChkBx = value; }
        public string ItemName { get => itemName; set => itemName = value; }
        public double ItemPrice { get => itemPrice; set => itemPrice = value; }
        public NumericUpDown FoodItemUpDwn { get => foodItemUpDwn; set => foodItemUpDwn = value; }

        //Public Constructor
        //Creates an instance of a food item and contains all data needed about the food item
        public FoodItem(CheckBox chkBx, string name, double price, NumericUpDown numUpDwn)
        {
            FoodItemChkBx = chkBx; //Determines if the customer wants the item
            ItemName = name; //Name of food item
            ItemPrice = price; //Price of food item
            FoodItemUpDwn = numUpDwn; //How many the customer wants
        }//End FoodItem Constructor

    }//End Class FoodItems
}//End Namespace
