/**********************************
 * Name: Dylan Buehler
 * Date: 4/5/2019
 * Contestant Number: 2493
 * Filename: EmployeePayRaise
 **********************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeePayRaise
{
    public partial class FormPayRaise : Form
    {
        public FormPayRaise()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Employee theEmp = new Employee(txtBxName.Text, Convert.ToDouble(txtBxCurrentPay.Text),
                Convert.ToDouble(txtBxYrsEmploy.Text), txtBxJobCode.Text);

            txtBxNameFinal.Text = txtBxName.Text;
            txtBxJobTitle.Text = GetTitle(theEmp);
            txtBxCurrentFinalPay.Text = txtBxCurrentPay.Text;

        }//End btnSubmit_Click

        public string GetTitle(Employee theEmp)
        {
            if(theEmp.JobCode == "S")
            {
                return "Sales";
            }
            else if(theEmp.JobCode == "L")
            {
                return "Labor";
            }
            else if(theEmp.JobCode == "M")
            {
                return "Management";
            }
            else
            {
                return "Job Title Unknown";
            }//End if / else if / else if / else
        }//End GetTitle
    }//End Class
}//End Namespace
