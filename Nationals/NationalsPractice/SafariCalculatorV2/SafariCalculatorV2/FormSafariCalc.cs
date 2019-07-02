/********************************
 * Name: Dylan Buehler
 * Date: 5/25/2019
 * Filename: SafariCalculatorV2
 * Copyright: DilCoInc 2019
 ********************************/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafariCalculatorV2
{
    public partial class FormSafariCalc : Form
    {
        public ArrayList MyChBoxArray = new ArrayList();

        public FormSafariCalc()
        {
            InitializeComponent();

            //Array to hold the animal names
            string[] animalNames = new string[] {"WildeBeest", "Buffalo", "Zebra",
                "Impala", "Gemsbok", "Warthog", "Hippo"};

            //Array to hold animal prices
            double[] animalPrices = new double[] { 1200, 14500, 1200, 250, 1800, 450, 12500 };

            //Create a instance of a checkBox and nermericUpDown
            CheckBox checkBox1;
            NumericUpDown numericUpDown1;

            //Create the list of check boxes with the desired components
            for(int i = 0; i < 7; i++)
            {
                //Creates a CheckBox
                checkBox1 = new CheckBox();
                checkBox1.AutoSize = true;
                checkBox1.Location = new Point(147, i * 30);
                checkBox1.Text = $"{animalNames[i]} - {animalPrices[i].ToString("c")}";
                Controls.Add(checkBox1);

                //Create a numericUpDown
                numericUpDown1 = new NumericUpDown();
                numericUpDown1.Location = new Point(353, i * 30);
                Controls.Add(numericUpDown1);

                //Create a MyCheckBox
                MyCheckBox box = new MyCheckBox(checkBox1, numericUpDown1, animalNames[i], animalPrices[i]);

                //Add the MyCheckBox to the arraylist
                MyChBoxArray.Add(box);
            }//End for loop
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Variables
            double totalCost = 0;

            //Loop through all MyCheckBoxes in the arraylist
            foreach(MyCheckBox box in MyChBoxArray)
            {
                //Check to see if the box is checked and numUpDown is not 0
                if(box.TheCheckBox.Checked == true && box.TheNumericUpDown.Value != 0)
                {
                    totalCost += (double)box.TheNumericUpDown.Value * box.AnimalPrice;
                }//End if
            }//End foreach

            //Update the lblTotalCost
            lblTotalCost.Text = totalCost.ToString("c");

        }//End btnSubmit
    }//End Class
}//End Namespace
