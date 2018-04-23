Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports DevExpress.XtraGrid.Views.Grid.Drawing
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Base

Namespace ColumnSpacing
	Friend Class MyGridPainter
		Inherits GridPainter
		Public Sub New(ByVal view As GridView)
			MyBase.New(view)
		End Sub

		Protected Overrides Sub DrawContents(ByVal e As GridViewDrawArgs)
			MyBase.DrawContents(e)
			DrawSpacingColumns(e)
		End Sub


		Protected Overridable Sub DrawSpacingColumns(ByVal e As GridViewDrawArgs)
			Dim columnBounds As RectangleF
			Dim columnSpacing As RectangleF

			For i As Integer = 0 To View.VisibleColumns.Count - 1
				Dim myColumn = TryCast(View.VisibleColumns(i), MyGridColumn)
				columnBounds = GetColumnBounds(TryCast(View, MyGridView), myColumn)
                If columnBounds.IsEmpty Then
                    columnBounds.Height -= 2
                    If i > 0 Then
                        columnSpacing = New RectangleF(columnBounds.Left - myColumn.ColumnSpacing, columnBounds.Top, myColumn.ColumnSpacing, columnBounds.Height)
                        e.Graphics.FillRectangle(e.ViewInfo.PaintAppearance.Empty.GetBackBrush(e.Cache), columnSpacing)
                    End If

                    If (i = View.VisibleColumns.Count - 1) AndAlso (myColumn.ColumnSpacing <> 0) Then
                        columnSpacing = New RectangleF(columnBounds.Left + columnBounds.Width, columnBounds.Top, View.ViewRect.Width, columnBounds.Height)
                    Else
                        columnSpacing = New RectangleF(columnBounds.Left + columnBounds.Width, columnBounds.Top, myColumn.ColumnSpacing, columnBounds.Height)
                    End If
                    e.Graphics.FillRectangle(e.ViewInfo.PaintAppearance.Empty.GetBackBrush(e.Cache), columnSpacing)
                End If

                columnBounds.X = columnBounds.Left - 1
                columnBounds.Width = 1
                columnBounds.Height += 1
                e.Graphics.FillRectangle(e.ViewInfo.PaintAppearance.VertLine.GetBackBrush(e.Cache), columnBounds)
            Next i
		End Sub

		Private Function GetColumnHeaderBounds(ByVal view As MyGridView, ByVal col As MyGridColumn) As RectangleF
			Dim viewInfo As GridViewInfo = TryCast(view.GetViewInfo(), GridViewInfo)
			If viewInfo.IsReady AndAlso (Not viewInfo.IsDataDirty) Then
				For Each info As GridColumnInfoArgs In viewInfo.ColumnsInfo
					If info.Column Is col Then
						Return info.Bounds
					End If
				Next info
			End If
			Return RectangleF.Empty
		End Function

		Private Function GetColumnBounds(ByVal view As MyGridView, ByVal col As MyGridColumn) As RectangleF
			Dim result As RectangleF = GetColumnHeaderBounds(view, col)
			If result.IsEmpty Then
				Return result
			End If
			Dim viewInfo As GridViewInfo = TryCast(view.GetViewInfo(), GridViewInfo)
			Dim rowsHeight As Integer = viewInfo.RowsLoadInfo.ResultRowsHeight
			result.Height += rowsHeight
			Return result
		End Function
	End Class
End Namespace
