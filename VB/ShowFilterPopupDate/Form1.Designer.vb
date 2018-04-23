Imports Microsoft.VisualBasic
Imports System
Namespace ShowFilterPopupDate
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.treeList1 = New DevExpress.XtraTreeList.TreeList()
			Me.colName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colDepartment = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colHired = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me.colPosition = New DevExpress.XtraTreeList.Columns.TreeListColumn()
			Me._treelistdb__2_DataSet = New ShowFilterPopupDate._treelistdb__2_DataSet()
			Me.table1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.table1TableAdapter = New ShowFilterPopupDate._treelistdb__2_DataSetTableAdapters.Table1TableAdapter()
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me._treelistdb__2_DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.table1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' treeList1
			' 
			Me.treeList1.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.colName, Me.colDepartment, Me.colHired, Me.colPosition})
			Me.treeList1.DataSource = Me.table1BindingSource
			Me.treeList1.Location = New System.Drawing.Point(12, 12)
			Me.treeList1.Name = "treeList1"
			Me.treeList1.OptionsBehavior.EnableFiltering = True
			Me.treeList1.Size = New System.Drawing.Size(554, 319)
			Me.treeList1.TabIndex = 0
'			Me.treeList1.ShowFilterPopupDate += New DevExpress.XtraTreeList.FilterPopupDateEventHandler(Me.treeList1_ShowFilterPopupDate);
			' 
			' colName
			' 
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			Me.colName.Width = 134
			' 
			' colDepartment
			' 
			Me.colDepartment.FieldName = "Department"
			Me.colDepartment.Name = "colDepartment"
			Me.colDepartment.Visible = True
			Me.colDepartment.VisibleIndex = 1
			Me.colDepartment.Width = 134
			' 
			' colHired
			' 
			Me.colHired.FieldName = "Hired"
			Me.colHired.Name = "colHired"
			Me.colHired.Visible = True
			Me.colHired.VisibleIndex = 2
			Me.colHired.Width = 134
			' 
			' colPosition
			' 
			Me.colPosition.FieldName = "Position"
			Me.colPosition.Name = "colPosition"
			Me.colPosition.Visible = True
			Me.colPosition.VisibleIndex = 3
			Me.colPosition.Width = 134
			' 
			' _treelistdb__2_DataSet
			' 
			Me._treelistdb__2_DataSet.DataSetName = "_treelistdb__2_DataSet"
			Me._treelistdb__2_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' table1BindingSource
			' 
			Me.table1BindingSource.DataMember = "Table1"
			Me.table1BindingSource.DataSource = Me._treelistdb__2_DataSet
			' 
			' table1TableAdapter
			' 
			Me.table1TableAdapter.ClearBeforeFill = True
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(578, 343)
			Me.Controls.Add(Me.treeList1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.treeList1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me._treelistdb__2_DataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.table1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents treeList1 As DevExpress.XtraTreeList.TreeList
		Private colName As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colDepartment As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colHired As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private colPosition As DevExpress.XtraTreeList.Columns.TreeListColumn
		Private _treelistdb__2_DataSet As _treelistdb__2_DataSet
		Private table1BindingSource As System.Windows.Forms.BindingSource
		Private table1TableAdapter As _treelistdb__2_DataSetTableAdapters.Table1TableAdapter
	End Class
End Namespace

