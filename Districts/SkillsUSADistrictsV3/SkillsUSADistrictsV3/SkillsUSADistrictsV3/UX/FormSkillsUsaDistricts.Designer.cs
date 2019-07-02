namespace SkillsUSADistrictsV3
{
    partial class FormSkillsUsaDistricts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumFighters = new System.Windows.Forms.Label();
            this.lblNumBattles = new System.Windows.Forms.Label();
            this.numUpDnFighter = new System.Windows.Forms.NumericUpDown();
            this.numUpDnBattles = new System.Windows.Forms.NumericUpDown();
            this.btnBegin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lstBxTeams = new System.Windows.Forms.ListBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFighter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBattles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumFighters
            // 
            this.lblNumFighters.AutoSize = true;
            this.lblNumFighters.Location = new System.Drawing.Point(29, 26);
            this.lblNumFighters.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumFighters.Name = "lblNumFighters";
            this.lblNumFighters.Size = new System.Drawing.Size(188, 25);
            this.lblNumFighters.TabIndex = 0;
            this.lblNumFighters.Text = "Number of Fighters: ";
            // 
            // lblNumBattles
            // 
            this.lblNumBattles.AutoSize = true;
            this.lblNumBattles.Location = new System.Drawing.Point(351, 26);
            this.lblNumBattles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumBattles.Name = "lblNumBattles";
            this.lblNumBattles.Size = new System.Drawing.Size(177, 25);
            this.lblNumBattles.TabIndex = 1;
            this.lblNumBattles.Text = "Number of Battles: ";
            // 
            // numUpDnFighter
            // 
            this.numUpDnFighter.Location = new System.Drawing.Point(224, 24);
            this.numUpDnFighter.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDnFighter.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnFighter.Name = "numUpDnFighter";
            this.numUpDnFighter.Size = new System.Drawing.Size(120, 30);
            this.numUpDnFighter.TabIndex = 2;
            this.numUpDnFighter.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // numUpDnBattles
            // 
            this.numUpDnBattles.Location = new System.Drawing.Point(535, 24);
            this.numUpDnBattles.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numUpDnBattles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUpDnBattles.Name = "numUpDnBattles";
            this.numUpDnBattles.Size = new System.Drawing.Size(120, 30);
            this.numUpDnBattles.TabIndex = 3;
            this.numUpDnBattles.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.DimGray;
            this.btnBegin.Location = new System.Drawing.Point(661, 16);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(135, 44);
            this.btnBegin.TabIndex = 4;
            this.btnBegin.Text = "Begin Battles";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.DimGray;
            this.btnReset.Enabled = false;
            this.btnReset.Location = new System.Drawing.Point(336, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lstBxTeams
            // 
            this.lstBxTeams.FormattingEnabled = true;
            this.lstBxTeams.ItemHeight = 25;
            this.lstBxTeams.Location = new System.Drawing.Point(12, 123);
            this.lstBxTeams.Name = "lstBxTeams";
            this.lstBxTeams.Size = new System.Drawing.Size(881, 354);
            this.lstBxTeams.TabIndex = 7;
            this.lstBxTeams.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(29, 70);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(746, 25);
            this.lblMessage.TabIndex = 8;
            this.lblMessage.Text = "Marvel Civil War: Pick the number of fighters and battles and then click \'Begin B" +
    "attles\'";
            // 
            // FormSkillsUsaDistricts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(905, 553);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lstBxTeams);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.numUpDnBattles);
            this.Controls.Add(this.numUpDnFighter);
            this.Controls.Add(this.lblNumBattles);
            this.Controls.Add(this.lblNumFighters);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormSkillsUsaDistricts";
            this.Text = "Skills USA Districts";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnFighter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDnBattles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumFighters;
        private System.Windows.Forms.Label lblNumBattles;
        private System.Windows.Forms.NumericUpDown numUpDnFighter;
        private System.Windows.Forms.NumericUpDown numUpDnBattles;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListBox lstBxTeams;
        private System.Windows.Forms.Label lblMessage;
    }
}

