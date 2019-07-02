/***********************************
 * Name: Dylan Buehler
 * Date: 4/5/2019
 * Contestant Number: 2493
 * Filename: SafariCalculator
 ***********************************/
using System;
using System.Windows.Forms;

namespace SafariCalculator
{
    public partial class FormSafariCalc : Form
    {
        public FormSafariCalc()
        {
            InitializeComponent();
        }

        /************************************************
         * EXPECTS: A button press
         * RETURNS: Nothing
         * TASKS: Submit the users data and generate a bill
         ************************************************/
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Creating an instance of the hunter
            Hunter theHunter = new Hunter(txtBxFName.Text, txtBxLName.Text,
                (double)numUpDnDaysHunting.Value, (double)numUpDnAnimalsHunted.Value);

            //Validate the Animals hunted against the number checked
            if(NumAnimalsValid(theHunter) == true)
            {
                //The hunter is valid so calculate the price
                CalcPrice(theHunter);
                btnReset.Visible = true;
            }//End if
            
        }//End btnSubmit_Click

        /************************************************
         * EXPECTS: The Hunter
         * RETURNS: Returns A Bool
         * TASKS: Evaluate the number of animals checked
         *  Vs. the number hunted. Then returns true or
         *  false depending on the outcome.
         ************************************************/
        public bool NumAnimalsValid(Hunter theHunter)
        {
            double numAnimalsChecked = 0;

            //Adds up the number boxes and gets a total
            numAnimalsChecked += (double) numUpDnWildebeest.Value;
            numAnimalsChecked += (double)numUpDnBuffalo.Value;
            numAnimalsChecked += (double)numUpDnZebra.Value;
            numAnimalsChecked += (double)numUpDnImpala.Value;
            numAnimalsChecked += (double)numUpDnGemsbok.Value;
            numAnimalsChecked += (double)numUpDnWarthog.Value;
            numAnimalsChecked += (double)numUpDnHippo.Value;

            //Compares the total to the number of animals the hunter said he was hunting
            if(numAnimalsChecked == theHunter.AnimalsHunted)
            {
                lblMessage.Text = "";
                return true;
            }
            else
            {
                lblMessage.Text = "The Number Of Animals You Checked Do Not Equal The Animals Hunted!";
                return false;
            }//End if / else
        }//End NumAnimalsValid

        /************************************************
         * EXPECTS: The Hunter
         * RETURNS: Nothing
         * TASKS: Calculate the price of the safari
         ************************************************/
        public void CalcPrice(Hunter theHunter)
        {
            double discountPercent = 0;
            double finalTotal = 0;
            double huntDaysCost = 0;
            double costBeforeDis = 0;
            double discountAmt = 0;
            double tip = 0;

            //Check how many animals the hunter checked and gets total price
            Tuple<int, int> tuple = AnimalsChecked();

            //Calculate the cost of hunting days
            huntDaysCost = CalcCostOfHuntingDays(theHunter, tuple.Item1);

            //Set Cost before discount
            costBeforeDis = tuple.Item2 + huntDaysCost;
            txtBxCostB4Dis.Text = "$" + Convert.ToString(costBeforeDis);

            //Calculate discounts
            if (tuple.Item1 == 7)
            {
                discountPercent = 0.05;
                txtBxDisAmt.Text = "5%";

                //Calculate the tip cost
                discountAmt = (huntDaysCost + tuple.Item2) * discountPercent;
                tip = (((huntDaysCost + tuple.Item2) - discountAmt) * 0.14 );
                txtBxTip.Text = Convert.ToString(tip);
            }
            else
            {
                txtBxDisAmt.Text = "0%";
                //Calculate the tip cost
                tip = (huntDaysCost + tuple.Item2) * 0.14;
                txtBxTip.Text = tip.ToString("c");
            }//End if / else

            //Set cost of hunting days on the form
            txtBxCostHuntDays.Text = "$" + Convert.ToString(huntDaysCost);

            //Calculate the final total
            finalTotal = ((huntDaysCost + tuple.Item2) - discountAmt) + tip;
            txtBxFinalTotal.Text = "$" + Convert.ToString(finalTotal);

            

        }//End CalcPrice

        /************************************************
         * EXPECTS: The Hunter, and the numberOfANimalsChecked
         * RETURNS: A double
         * TASKS: Calculate the cost of hunting days and
         *  give free days if they hunt a certain amount
         *  of animals.
         ************************************************/
        public double CalcCostOfHuntingDays(Hunter theHunter, int numAnimalsChecked)
        {
            double costOfHuntDays = 0;
            double huntDaysFree = 0;

            if(numAnimalsChecked >= 5)
            {
                huntDaysFree = 840;
            }
            else if (numAnimalsChecked >= 3 && numAnimalsChecked < 5)
            {
                huntDaysFree = 600;
            }//End if / else

            costOfHuntDays = (theHunter.DaysHunted * 120) - huntDaysFree;
            if(costOfHuntDays <= 0)
            {
                return 0;
            }
            else
            {
                return costOfHuntDays;
            }//End if / else
        }//End CalcCostOfHuntingDays

        /************************************************
         * EXPECTS: Nothing
         * RETURNS: Returns A Tuple
         * TASKS: Counts the number of checked animals
         *  and totals the cost.
         ************************************************/
        public Tuple<int, int> AnimalsChecked()
        {
            int count = 0;
            int price = 0;

            if (chBxWildebeest.Checked == true)
            {
                count++;
                price += ((int)numUpDnWildebeest.Value * 1200);
            }
            if (chBxBuffalo.Checked == true)
            {
                count++;
                price += ((int)numUpDnBuffalo.Value * 14500);
            }
            if (chBxZebra.Checked == true)
            {
                count++;
                price += ((int)numUpDnZebra.Value * 1200);
            }
            if (chBxImpala.Checked == true)
            {
                count++;
                price += ((int)numUpDnImpala.Value * 250);
            }
            if (chBxGemsbok.Checked == true)
            {
                count++;
                price += ((int)numUpDnGemsbok.Value * 1800);
            }
            if (chBxWarthog.Checked == true)
            {
                count++;
                price += ((int)numUpDnWarthog.Value * 450);
            }
            if (chBxHippo.Checked == true)
            {
                count++;
                price += ((int)numUpDnHippo.Value * 12500);
            }
            //Makes a tuple to return the information
            Tuple<int, int> tuple = new Tuple<int, int>(count, price);
            return tuple;
        }//End AnimalsChecked

        /// <summary>
        /// Allows for the CheckBox and NumUpDown to be updated Dynamically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chBxWildebeest_CheckedChanged(object sender, EventArgs e)
        {
            if(chBxWildebeest.Checked == true)
            {
                numUpDnWildebeest.Enabled = true;
            }
            else
            {
                numUpDnWildebeest.Enabled = false;
                numUpDnWildebeest.Value = 0;
            }//End if / else
        }//End chBxWildebeest_CheckedChanged

        /// <summary>
        /// Allows for the CheckBox and NumUpDown to be updated Dynamically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chBxBuffalo_CheckedChanged(object sender, EventArgs e)
        {
            if(chBxBuffalo.Checked == true)
            {
                numUpDnBuffalo.Enabled = true;
            }
            else
            {
                numUpDnBuffalo.Enabled = false;
                numUpDnBuffalo.Value = 0;
            }//End if / else
        }//End chBxBuffalo_CheckedChanged

        /// <summary>
        /// Allows for the CheckBox and NumUpDown to be updated Dynamically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chBxZebra_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxZebra.Checked == true)
            {
                numUpDnZebra.Enabled = true;
            }
            else
            {
                numUpDnZebra.Enabled = false;
                numUpDnZebra.Value = 0;
            }//End if / else
        }//End chBxZebra_CheckedChanged

        /// <summary>
        /// Allows for the CheckBox and NumUpDown to be updated Dynamically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chBxImpala_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxImpala.Checked == true)
            {
                numUpDnImpala.Enabled = true;
            }
            else
            {
                numUpDnImpala.Enabled = false;
                numUpDnImpala.Value = 0;
            }//End if / else
        }//End chBxImpala_CheckedChanged

        /// <summary>
        /// Allows for the CheckBox and NumUpDown to be updated Dynamically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chBxGemsbok_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxGemsbok.Checked == true)
            {
                numUpDnGemsbok.Enabled = true;
            }
            else
            {
                numUpDnGemsbok.Enabled = false;
                numUpDnGemsbok.Value = 0;
            }//End if / else
        }//End chBxGemsbok_CheckedChanged

        /// <summary>
        /// Allows for the CheckBox and NumUpDown to be updated Dynamically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chBxWarthog_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxWarthog.Checked == true)
            {
                numUpDnWarthog.Enabled = true;
            }
            else
            {
                numUpDnWarthog.Enabled = false;
                numUpDnWarthog.Value = 0;
            }//End if / else
        }//End chBxWarthog_CheckedChanged

        /// <summary>
        /// Allows for the CheckBox and NumUpDown to be updated Dynamically
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chBxHippo_CheckedChanged(object sender, EventArgs e)
        {
            if (chBxHippo.Checked == true)
            {
                numUpDnHippo.Enabled = true;
            }
            else
            {
                numUpDnHippo.Enabled = false;
                numUpDnHippo.Value = 0;
            }//End if / else
        }//End chBxHippo_CheckedChanged

        /// <summary>
        /// Enables the submit button when the first name txtbox is not empty
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBxFName_TextChanged(object sender, EventArgs e)
        {
            if(txtBxFName.Text != "")
            {
                btnSubmit.Enabled = true;
            }
            else
            {
                btnSubmit.Enabled = false;
            }//End if / else
        }//End txtBxFName_TextChanged

        /// <summary>
        /// Reset the form for another hunter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Reset the buttons
            btnReset.Visible = false;
            btnSubmit.Enabled = false;

            //Reset the hunter info Groupbox
            txtBxFName.Text = "";
            txtBxLName.Text = "";
            numUpDnDaysHunting.Value = 1;
            numUpDnAnimalsHunted.Value = 1;

            //Reset the check boxes
            chBxWildebeest.Checked = false;
            chBxBuffalo.Checked = false;
            chBxZebra.Checked = false;
            chBxImpala.Checked = false;
            chBxGemsbok.Checked = false;
            chBxWarthog.Checked = false;
            chBxHippo.Checked = false;

            //Reset the Billing Information
            txtBxCostB4Dis.Text = "";
            txtBxCostHuntDays.Text = "";
            txtBxDisAmt.Text = "";
            txtBxTip.Text = "";
            txtBxFinalTotal.Text = "";
        }//End btnReset_Click
    }//End Class
}//End Namespace
