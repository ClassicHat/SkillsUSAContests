namespace ArrayBasedFormObjects
{
    partial class FormArrayBasedFormObjects
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
            this.btnGetResults = new System.Windows.Forms.Button();
            this.lstBxResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetResults
            // 
            this.btnGetResults.Location = new System.Drawing.Point(674, 384);
            this.btnGetResults.Name = "btnGetResults";
            this.btnGetResults.Size = new System.Drawing.Size(114, 54);
            this.btnGetResults.TabIndex = 0;
            this.btnGetResults.Text = "Get Results";
            this.btnGetResults.UseVisualStyleBackColor = true;
            this.btnGetResults.Click += new System.EventHandler(this.btnGetResults_Click);
            // 
            // lstBxResults
            // 
            this.lstBxResults.FormattingEnabled = true;
            this.lstBxResults.ItemHeight = 16;
            this.lstBxResults.Location = new System.Drawing.Point(539, 55);
            this.lstBxResults.Name = "lstBxResults";
            this.lstBxResults.Size = new System.Drawing.Size(249, 324);
            this.lstBxResults.TabIndex = 1;
            // 
            // FormArrayBasedFormObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstBxResults);
            this.Controls.Add(this.btnGetResults);
            this.Name = "FormArrayBasedFormObjects";
            this.Text = "Array Based Form Objects";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnGetResults;
        private System.Windows.Forms.ListBox lstBxResults;
    }
}

