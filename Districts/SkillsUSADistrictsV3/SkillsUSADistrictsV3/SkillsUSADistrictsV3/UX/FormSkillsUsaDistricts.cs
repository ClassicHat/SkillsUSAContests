/***************************************
 * Author: Dylan Buehler
 * Date: 3/24/2019
 * Filename: FormSkillsUsaDistricts.cs
 * Copyright: DilCoInc 2019
 ***************************************/
using System;
using System.Windows.Forms;

namespace SkillsUSADistrictsV3
{
    public partial class FormSkillsUsaDistricts : Form
    {
        //Random number generator for use throughout the project
        private Random num = new Random();

        public FormSkillsUsaDistricts()
        {
            InitializeComponent();
        }

        /****[ btnReset_Click Method ]*************************
         * EXPECTS: The begin battle button to be pressed.
         * RETURNS: Nothing
         * TASKS: Disable some form items, start the civil war
         *  based on inputed values, update the listbox, and
         *  update the lblMessage to display the War winner.
         ******************************************************/
        private void btnBegin_Click(object sender, EventArgs e)
        {
            //Disable form items
            numUpDnBattles.Enabled = false;
            numUpDnFighter.Enabled = false;
            btnBegin.Enabled = false;
            btnReset.Enabled = true;
            lstBxTeams.Visible = true;

            //Starts a Civil War Battle
            Battle beginBattles = new Battle();
            beginBattles.CivilWar((int)numUpDnFighter.Value, (int)numUpDnBattles.Value, num);

            //Update the LstBxTeams
            ListBxUpdater(beginBattles);

            //Update the lblMessage
            ChangeMessage(beginBattles);
        }//End btnBegin_Click

        /****[ btnReset_Click Method ]*************************
         * EXPECTS: The reset button to be pressed
         * RETURNS: Nothing
         * TASKS: Reset the form so another Civil War can take
         *  place.
         ******************************************************/
        private void btnReset_Click(object sender, EventArgs e)
        {
            lstBxTeams.Items.Clear();
            lblMessage.Text = "";

            //Enable form items
            numUpDnBattles.Enabled = true;
            numUpDnFighter.Enabled = true;
            btnBegin.Enabled = true;
            btnReset.Enabled = false;
        }//End btnReset_Click

        /****[ ListBxUpdater Method ]**************************
         * EXPECTS: A battle
         * RETURNS: Nothing
         * TASKS: Updates the LstBxTeams by adding each teams
         *  information and power ranking. It also displays the
         *  winner of each fight.
         ******************************************************/
        public void ListBxUpdater(Battle beginBattles)
        {
            int count = 0;
            //Remove the last semicolon
            beginBattles.CivilWarBattleInfo = beginBattles.CivilWarBattleInfo.TrimEnd(';');
            string[] teams = beginBattles.CivilWarBattleInfo.Split(';');

            foreach (var team in teams)
            {
                if (count == 0)
                {
                    lstBxTeams.Items.Add($"Team Stark: {team}");
                    count = 1;
                }
                else if (count == 1)
                {

                    lstBxTeams.Items.Add($"Team Cap: {team}");
                    count = 2;
                }//End if / else if
                else if (count == 2)
                {
                    //In this case team is actually the winner
                    lstBxTeams.Items.Add(team);
                    lstBxTeams.Items.Add("");
                    count = 0;
                }
            }//End foreach
        }//End ListBxUpdater Method

        /****[ ChangeMessage Method ]**************************
         * EXPECTS: A battle
         * RETURNS: Nothing
         * TASKS: Updates the lblMessage to display the winner
         *  and score of the civil war.
         ******************************************************/
        public void ChangeMessage(Battle beginBattles)
        {
            if (beginBattles.CapWins < beginBattles.StarkWins)
            {
                lblMessage.Text = $"Stark Wins The Civil War - {beginBattles.StarkWins} Vs. {beginBattles.CapWins}";
            }
            else if (beginBattles.CapWins > beginBattles.StarkWins)
            {
                lblMessage.Text = $"Cap Wins The Civil War - {beginBattles.CapWins} Vs. {beginBattles.StarkWins}";
            }
            else
            {
                lblMessage.Text = $"The Civil War Is A Tie - {beginBattles.StarkWins} Vs. {beginBattles.CapWins}";
            }//End if / else if / else
        }//End ChangeMessage Method
    }//End Class
}//End Namespace