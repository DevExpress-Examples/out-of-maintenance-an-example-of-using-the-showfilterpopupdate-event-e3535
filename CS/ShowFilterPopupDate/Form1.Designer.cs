namespace ShowFilterPopupDate
{
    partial class Form1
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
            this.treeList1 = new DevExpress.XtraTreeList.TreeList();
            this.colName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colDepartment = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colHired = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colPosition = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this._treelistdb__2_DataSet = new ShowFilterPopupDate._treelistdb__2_DataSet();
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table1TableAdapter = new ShowFilterPopupDate._treelistdb__2_DataSetTableAdapters.Table1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._treelistdb__2_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // treeList1
            // 
            this.treeList1.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colName,
            this.colDepartment,
            this.colHired,
            this.colPosition});
            this.treeList1.DataSource = this.table1BindingSource;
            this.treeList1.Location = new System.Drawing.Point(12, 12);
            this.treeList1.Name = "treeList1";
            this.treeList1.OptionsBehavior.EnableFiltering = true;
            this.treeList1.Size = new System.Drawing.Size(554, 319);
            this.treeList1.TabIndex = 0;
            this.treeList1.ShowFilterPopupDate += new DevExpress.XtraTreeList.FilterPopupDateEventHandler(this.treeList1_ShowFilterPopupDate);
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            this.colName.Width = 134;
            // 
            // colDepartment
            // 
            this.colDepartment.FieldName = "Department";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Visible = true;
            this.colDepartment.VisibleIndex = 1;
            this.colDepartment.Width = 134;
            // 
            // colHired
            // 
            this.colHired.FieldName = "Hired";
            this.colHired.Name = "colHired";
            this.colHired.Visible = true;
            this.colHired.VisibleIndex = 2;
            this.colHired.Width = 134;
            // 
            // colPosition
            // 
            this.colPosition.FieldName = "Position";
            this.colPosition.Name = "colPosition";
            this.colPosition.Visible = true;
            this.colPosition.VisibleIndex = 3;
            this.colPosition.Width = 134;
            // 
            // _treelistdb__2_DataSet
            // 
            this._treelistdb__2_DataSet.DataSetName = "_treelistdb__2_DataSet";
            this._treelistdb__2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table1";
            this.table1BindingSource.DataSource = this._treelistdb__2_DataSet;
            // 
            // table1TableAdapter
            // 
            this.table1TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 343);
            this.Controls.Add(this.treeList1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.treeList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._treelistdb__2_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList treeList1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colName;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colDepartment;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colHired;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colPosition;
        private _treelistdb__2_DataSet _treelistdb__2_DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private _treelistdb__2_DataSetTableAdapters.Table1TableAdapter table1TableAdapter;
    }
}

