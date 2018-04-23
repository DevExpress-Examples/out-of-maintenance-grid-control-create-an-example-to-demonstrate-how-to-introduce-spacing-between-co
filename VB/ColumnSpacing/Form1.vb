Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid


Namespace ColumnSpacing
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			myGridControl1.DataSource = CreateTable(20)
			myGridView1.Columns(1).ColumnSpacing = 8
			myGridView1.BestFitColumns()
		End Sub

		Private Function CreateTable(ByVal RowCount As Integer) As DataTable
			Dim tbl As New DataTable()
			tbl.Columns.Add("Name", GetType(String))
			tbl.Columns.Add("ID", GetType(Integer))
			tbl.Columns.Add("Number", GetType(Integer))
			tbl.Columns.Add("Date", GetType(DateTime))
			For i As Integer = 0 To RowCount - 1
				tbl.Rows.Add(New Object() { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) })
			Next i
			Return tbl
		End Function

		Private Sub myGridView1_RowCellStyle(ByVal sender As Object, ByVal e As RowCellStyleEventArgs) Handles myGridView1.RowCellStyle
			If cbRowCellStyle.Checked Then
				Dim view = myGridView1
				If e.RowHandle <> view.FocusedRowHandle Then
					If e.RowHandle Mod 2 = 0 Then
						e.Appearance.BackColor = Color.FromArgb(&HEB, &HF9, &HEB)
					Else
						e.Appearance.BackColor = Color.FromArgb(&HED, &HF9, &HFA)
					End If
				Else
					e.Appearance.BackColor = SystemColors.GradientInactiveCaption
				End If
			End If
		End Sub

		Private Sub myGridView1_FocusedColumnChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs) Handles myGridView1.FocusedColumnChanged
			btnEdit_colSpacing.EditValue = (TryCast(e.FocusedColumn, MyGridColumn)).ColumnSpacing
		End Sub

		Private Sub btnEdit_colSpacing_ButtonClick(ByVal sender As Object, ByVal e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btnEdit_colSpacing.ButtonClick
			If myGridView1.FocusedColumn IsNot Nothing Then
				TryCast(myGridView1.FocusedColumn, MyGridColumn).ColumnSpacing = Convert.ToInt32(btnEdit_colSpacing.EditValue)
			End If
		End Sub

		Private Sub btnEdit_colSpacing_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles btnEdit_colSpacing.KeyDown
			If e.KeyData = Keys.Enter Then
				btnEdit_colSpacing_ButtonClick(Me, Nothing)
			End If
		End Sub

		Private Sub cbRowCellStyle_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbRowCellStyle.CheckedChanged
			myGridView1.LayoutChanged()
		End Sub
	End Class
End Namespace
