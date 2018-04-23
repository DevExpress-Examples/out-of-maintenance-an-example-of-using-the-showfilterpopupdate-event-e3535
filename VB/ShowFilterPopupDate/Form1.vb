Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraTreeList
Imports DevExpress.Data.Filtering


Namespace ShowFilterPopupDate
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.table1TableAdapter.Fill(Me._treelistdb__2_DataSet.Table1)
		End Sub

		Private Sub treeList1_ShowFilterPopupDate(ByVal sender As Object, ByVal e As FilterPopupDateEventArgs) Handles treeList1.ShowFilterPopupDate
			If e.Column.FieldName <> "Hired" Then
				Return
			End If
			Dim firstDayOfFirstYear As New DateTime(1982, 1, 1)
			Dim lastDayOfFirstYear As New DateTime(1982, 12, 31)

			Dim firstDay As CriteriaOperator = New BinaryOperator(e.Column.FieldName, firstDayOfFirstYear, BinaryOperatorType.GreaterOrEqual)
			Dim lastDay As CriteriaOperator = New BinaryOperator(e.Column.FieldName, lastDayOfFirstYear, BinaryOperatorType.Less)
			Dim crit As CriteriaOperator = New GroupOperator(GroupOperatorType.And, firstDay, lastDay)

			e.List.Add(New DevExpress.XtraEditors.FilterDateElement("Year of Foundation", "", crit))

		End Sub
	End Class
End Namespace
