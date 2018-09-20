namespace DataBaseTest.FormsForPharmacy
{
    partial class CreateOrder
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDrugDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.warehouseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet = new DataBaseTest._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.warehouseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBMainDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseTableAdapter1 = new DataBaseTest._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSetTableAdapters.WarehouseTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMainDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDrugDataGridViewTextBoxColumn,
            this.countDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView1.DataSource = this.warehouseBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 461);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "№ id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDrugDataGridViewTextBoxColumn
            // 
            this.nameDrugDataGridViewTextBoxColumn.DataPropertyName = "NameDrug";
            this.nameDrugDataGridViewTextBoxColumn.HeaderText = "Name Drug";
            this.nameDrugDataGridViewTextBoxColumn.Name = "nameDrugDataGridViewTextBoxColumn";
            // 
            // countDataGridViewTextBoxColumn
            // 
            this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
            this.countDataGridViewTextBoxColumn.HeaderText = "Available quantity";
            this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Need quantity";
            this.Column1.Name = "Column1";
            // 
            // warehouseBindingSource1
            // 
            this.warehouseBindingSource1.DataMember = "Warehouse";
            this.warehouseBindingSource1.DataSource = this._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet;
            // 
            // _C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet
            // 
            this._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet.DataSetName = "_C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_D" +
    "ATABASE_DB_MAIN_MDFDataSet";
            this._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warehouseTableAdapter1
            // 
            this.warehouseTableAdapter1.ClearBeforeFill = true;
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CreateOrder";
            this.Text = "CreateOrder";
            this.Load += new System.EventHandler(this.CreateOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBMainDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource warehouseBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDrugDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dBMainDataSet1BindingSource;
        private _C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet _C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSet;
        private System.Windows.Forms.BindingSource warehouseBindingSource1;
        private _C__USERS_ВАДИМ_DOCUMENTS_VISUAL_STUDIO_2015_PROJECTS_DATABASETEST_DATABASETEST_DATABASE_DB_MAIN_MDFDataSetTableAdapters.WarehouseTableAdapter warehouseTableAdapter1;
    }
}