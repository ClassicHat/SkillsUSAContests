namespace FoodProgramApplication
{
    partial class FormFoodApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCustomerTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRunningTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contestant: 503    Program 1    Food Program";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(190, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Items For Sale";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(529, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 52);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Location = new System.Drawing.Point(298, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 52);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DimGray;
            this.btnCalculate.Location = new System.Drawing.Point(169, 402);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(123, 52);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 359);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Your Total Is: ";
            // 
            // lblCustomerTotal
            // 
            this.lblCustomerTotal.AutoSize = true;
            this.lblCustomerTotal.Location = new System.Drawing.Point(342, 359);
            this.lblCustomerTotal.Name = "lblCustomerTotal";
            this.lblCustomerTotal.Size = new System.Drawing.Size(61, 25);
            this.lblCustomerTotal.TabIndex = 6;
            this.lblCustomerTotal.Text = "$0.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(408, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total For Day: ";
            // 
            // lblRunningTotal
            // 
            this.lblRunningTotal.AutoSize = true;
            this.lblRunningTotal.Location = new System.Drawing.Point(591, 77);
            this.lblRunningTotal.Name = "lblRunningTotal";
            this.lblRunningTotal.Size = new System.Drawing.Size(61, 25);
            this.lblRunningTotal.TabIndex = 8;
            this.lblRunningTotal.Text = "$0.00";
            // 
            // FormFoodApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(684, 510);
            this.Controls.Add(this.lblRunningTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblCustomerTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFoodApp";
            this.Text = "Food Program";
            this.Load += new System.EventHandler(this.FormFoodApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCustomerTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRunningTotal;
    }
}

