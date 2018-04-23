Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.Utils.Serializing
Imports System.Collections.Generic
Imports System.ComponentModel

Namespace ColumnSpacing
	Public Class MyGridView
		Inherits GridView
		Public Sub New()
			Me.New(Nothing)
		End Sub
		Public Sub New(ByVal grid As GridControl)
			MyBase.New(grid)
		End Sub
		Protected Overrides Function CreateColumnCollection() As GridColumnCollection
			Return New MyGridColumnCollection(Me)
		End Function
		Protected Overrides ReadOnly Property ViewName() As String
			Get
				Return "MyGridView"
			End Get
		End Property

		<Browsable(False), XtraSerializableProperty(XtraSerializationVisibility.Collection, True, True, True, 0, XtraSerializationFlags.DefaultValue), XtraSerializablePropertyId(2), DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Columns() As MyGridColumnCollection
			Get
				Return TryCast(MyBase.Columns, MyGridColumnCollection)
			End Get
		End Property

	End Class
End Namespace