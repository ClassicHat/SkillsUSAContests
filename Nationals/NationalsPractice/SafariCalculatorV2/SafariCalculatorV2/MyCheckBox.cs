using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafariCalculatorV2
{
    class MyCheckBox
    {
        //Private Feilds
        private CheckBox theCheckBox;
        private NumericUpDown theNumericUpDown;
        private string animalName;
        private double animalPrice;

        //Public Properties
        public CheckBox TheCheckBox { get => theCheckBox; set => theCheckBox = value; }
        public string AnimalName { get => animalName; set => animalName = value; }
        public double AnimalPrice { get => animalPrice; set => animalPrice = value; }
        public NumericUpDown TheNumericUpDown { get => theNumericUpDown; set => theNumericUpDown = value; }

        /// <summary>
        /// Creates a CheckBox with a name for the animal and a price
        /// </summary>
        /// <param name="theChBx"></param>
        /// <param name="aName"></param>
        /// <param name="aPrice"></param>
        public MyCheckBox(CheckBox theChBx, NumericUpDown theNumUpDwn, string aName, double aPrice)
        {
            TheCheckBox = theChBx;
            TheNumericUpDown = theNumUpDwn;
            AnimalName = aName;
            AnimalPrice = aPrice;
        }//End Constructor
    }//End Class MyCheckBox
}//End Namespace
