/***********************************
 * Name: Dylan Buehler
 * Date: 4/5/2019
 * Contestant Number: 2493
 * Filename: SafariCalculator
 ***********************************/
namespace SafariCalculator
{
    public class Hunter
    {
        //Private Class Fields
        private string fName;
        private string lName;
        private double daysHunted;
        private double animalsHunted;

        //Public Class Properties
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public double DaysHunted { get => daysHunted; set => daysHunted = value; }
        public double AnimalsHunted { get => animalsHunted; set => animalsHunted = value; }

        //Constructor
        /// <summary>
        /// Creates a Hunter based on the information entered on the form
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="numDaysHunted"></param>
        /// <param name="numAnimalsHunted"></param>
        public Hunter(string firstName, string lastName, double numDaysHunted, double numAnimalsHunted)
        {
            FName = firstName;
            LName = lastName;
            DaysHunted = numDaysHunted;
            AnimalsHunted = numAnimalsHunted;
        }//End Constructor
    }//End Class Hunter
}//End Namespace
