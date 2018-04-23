Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports System.Drawing
Imports DevExpress.XtraGrid.Columns

Namespace ColumnSpacing
	Public Class MyGridViewInfo
		Inherits GridViewInfo
		Public Sub New(ByVal gridView As DevExpress.XtraGrid.Views.Grid.GridView)
			MyBase.New(gridView)
		End Sub

		Protected Overrides Sub CalcColumnsDrawInfo()
			MyBase.CalcColumnsDrawInfo()

			Dim count As Integer = View.VisibleColumns.Count + (If(AllowBehindColumn AndAlso (View.VisibleColumns.Count = 0 OrElse True), 1, 0))
			Dim firstIndex As Integer = If(ViewRects.IndicatorWidth > 0, -1, 0)
			For i As Integer = firstIndex To count-2
				Dim column As GridColumn = If(i > -1, View.GetVisibleColumn(i), Nothing)
				Dim space As Integer = 0
				If column IsNot Nothing Then
					space = (TryCast(column, MyGridColumn)).ColumnSpacing
				End If

				If (ColumnsInfo.Count <> 0) AndAlso (i >= 0) AndAlso (ColumnsInfo(i+1) IsNot Nothing) Then
					Dim rect As Rectangle = ColumnsInfo(i+1).Bounds
					If i > 0 Then
                        ColumnsInfo(i + 1).Bounds = New Rectangle(rect.Left + space, rect.Top, rect.Width - (space * 2), rect.Height)
					Else
                        ColumnsInfo(i + 1).Bounds = New Rectangle(rect.Left, rect.Top, rect.Width - space, rect.Height)
					End If
				End If
			Next i
		End Sub
	End Class
End Namespace
