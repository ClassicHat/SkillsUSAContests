namespace FoodProgram
{
    partial class FormFoodProgram
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFoodProgram));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.foodProgramDBDataSet = new FoodProgram.FoodProgramDBDataSet();
            this.foodItemsInfoTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodItemsInfoTableTableAdapter = new FoodProgram.FoodProgramDBDataSetTableAdapters.FoodItemsInfoTableTableAdapter();
            this.tableAdapterManager = new FoodProgram.FoodProgramDBDataSetTableAdapters.TableAdapterManager();
            this.foodItemsInfoTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.foodItemsInfoTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.foodItemsInfoTableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.foodProgramDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsInfoTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsInfoTableBindingNavigator)).BeginInit();
            this.foodItemsInfoTableBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsInfoTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DimGray;
            this.btnExit.Location = new System.Drawing.Point(524, 538);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 57);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DimGray;
            this.btnClear.Location = new System.Drawing.Point(396, 538);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 57);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DimGray;
            this.btnCalculate.Location = new System.Drawing.Point(268, 538);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(122, 57);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // foodProgramDBDataSet
            // 
            this.foodProgramDBDataSet.DataSetName = "FoodProgramDBDataSet";
            this.foodProgramDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodItemsInfoTableBindingSource
            // 
            this.foodItemsInfoTableBindingSource.DataMember = "FoodItemsInfoTable";
            this.foodItemsInfoTableBindingSource.DataSource = this.foodProgramDBDataSet;
            // 
            // foodItemsInfoTableTableAdapter
            // 
            this.foodItemsInfoTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FoodItemsInfoTableTableAdapter = this.foodItemsInfoTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = FoodProgram.FoodProgramDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // foodItemsInfoTableBindingNavigator
            // 
            this.foodItemsInfoTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.foodItemsInfoTableBindingNavigator.BindingSource = this.foodItemsInfoTableBindingSource;
            this.foodItemsInfoTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.foodItemsInfoTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.foodItemsInfoTableBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.foodItemsInfoTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.foodItemsInfoTableBindingNavigatorSaveItem});
            this.foodItemsInfoTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.foodItemsInfoTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.foodItemsInfoTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.foodItemsInfoTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.foodItemsInfoTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.foodItemsInfoTableBindingNavigator.Name = "foodItemsInfoTableBindingNavigator";
            this.foodItemsInfoTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.foodItemsInfoTableBindingNavigator.Size = new System.Drawing.Size(930, 27);
            this.foodItemsInfoTableBindingNavigator.TabIndex = 3;
            this.foodItemsInfoTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // foodItemsInfoTableBindingNavigatorSaveItem
            // 
            this.foodItemsInfoTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.foodItemsInfoTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("foodItemsInfoTableBindingNavigatorSaveItem.Image")));
            this.foodItemsInfoTableBindingNavigatorSaveItem.Name = "foodItemsInfoTableBindingNavigatorSaveItem";
            this.foodItemsInfoTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.foodItemsInfoTableBindingNavigatorSaveItem.Text = "Save Data";
            this.foodItemsInfoTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.foodItemsInfoTableBindingNavigatorSaveItem_Click);
            // 
            // foodItemsInfoTableDataGridView
            // 
            this.foodItemsInfoTableDataGridView.AutoGenerateColumns = false;
            this.foodItemsInfoTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodItemsInfoTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.foodItemsInfoTableDataGridView.DataSource = this.foodItemsInfoTableBindingSource;
            this.foodItemsInfoTableDataGridView.Location = new System.Drawing.Point(116, 105);
            this.foodItemsInfoTableDataGridView.Name = "foodItemsInfoTableDataGridView";
            this.foodItemsInfoTableDataGridView.RowTemplate.Height = 24;
            this.foodItemsInfoTableDataGridView.Size = new System.Drawing.Size(581, 220);
            this.foodItemsInfoTableDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Item";
            this.dataGridViewTextBoxColumn2.HeaderText = "Item";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Price";
            this.dataGridViewTextBoxColumn3.HeaderText = "Price";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FormFoodProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(930, 619);
            this.Controls.Add(this.foodItemsInfoTableDataGridView);
            this.Controls.Add(this.foodItemsInfoTableBindingNavigator);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LimeGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormFoodProgram";
            this.Text = "Food Program";
            this.Load += new System.EventHandler(this.FormFoodProgram_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodProgramDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsInfoTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsInfoTableBindingNavigator)).EndInit();
            this.foodItemsInfoTableBindingNavigator.ResumeLayout(false);
            this.foodItemsInfoTableBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsInfoTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private FoodProgramDBDataSet foodProgramDBDataSet;
        private System.Windows.Forms.BindingSource foodItemsInfoTableBindingSource;
        private FoodProgramDBDataSetTableAdapters.FoodItemsInfoTableTableAdapter foodItemsInfoTableTableAdapter;
        private FoodProgramDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator foodItemsInfoTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton foodItemsInfoTableBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView foodItemsInfoTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}

