/**********************************
 * Name: Dylan Buehler
 * Date: 5/18/2019
 * Filename: ArrayBasedFormObjects
 * Copyright: DilCoInc 2019
 **********************************/
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

namespace ArrayBasedFormObjects
{
    public partial class FormArrayBasedFormObjects : Form
    {
        public ArrayList myCheckBoxes = new ArrayList();

        public FormArrayBasedFormObjects()
        {
            InitializeComponent();

            //Instead of letting the Above Initializer create our form objects we create them below to make
            //the code alot shorter. By doing it this way you do not need a checked changed event for each
            //different checkbox. Instead we just loop through the array list.

            CheckBox box;

            for(int i = 1; i <= 5; i++)
            {
                box = new CheckBox();
                box.Tag = i.ToString();
                box.Text = i.ToString();
                box.AutoSize = true;
                box.Location = new Point(10, i * 50);
                this.Controls.Add(box);
                myCheckBoxes.Add(box);
            }//End for loop
        }//End Form

        private void btnGetResults_Click(object sender, EventArgs e)
        {
            //Clear the listbox so the information can refresh
            lstBxResults.Items.Clear();

            //Loop through each check box and see if it is Checked or not
            foreach(CheckBox box in myCheckBoxes)
            {
                lstBxResults.Items.Add("CheckBox" + box.Text + " Checked: " + box.Checked);

                //This is to add a space after each checkbox
                lstBxResults.Items.Add("");
            }//End foreach
        }//End btnGetResults
    }//End Class
}//End namespace
