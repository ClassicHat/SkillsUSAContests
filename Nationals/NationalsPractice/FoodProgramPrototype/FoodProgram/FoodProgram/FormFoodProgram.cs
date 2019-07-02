using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FoodProgram
{
    public partial class FormFoodProgram : Form
    {
        public FormFoodProgram()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void foodItemsInfoTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodItemsInfoTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.foodProgramDBDataSet);

        }

        private void FormFoodProgram_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'foodProgramDBDataSet.FoodItemsInfoTable' table. You can move, or remove it, as needed.
            this.foodItemsInfoTableTableAdapter.Fill(this.foodProgramDBDataSet.FoodItemsInfoTable);

        }
    }
}
