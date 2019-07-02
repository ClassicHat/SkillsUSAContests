/**********************************
 * Name: Dylan Buehler
 * Date: 4/5/2019
 * Contestant Number: 2493
 * Filename: EmployeePayRaise
 **********************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayRaise
{
    public class Employee
    {
        //Private Class Fields
        private string name;
        private double currentPay;
        private double yearsEmployed;
        private string jobCode;

        //Public Class Properties
        public string Name { get => name; set => name = value; }
        public double CurrentPay { get => currentPay; set => currentPay = value; }
        public double YearsEmployed { get => yearsEmployed; set => yearsEmployed = value; }
        public string JobCode { get => jobCode; set => jobCode = value; }

        //Constructor
        public Employee(string fullName, double curPay, double yrsEmployed, string jCode)
        {
            Name = fullName;
            CurrentPay = curPay;
            YearsEmployed = yrsEmployed;
            jobCode = jCode;
        }//End Constructor
    }//End Class Employee
}//End Namespace