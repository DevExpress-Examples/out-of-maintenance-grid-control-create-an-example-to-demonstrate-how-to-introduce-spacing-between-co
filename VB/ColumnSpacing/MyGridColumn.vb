Imports Microsoft.VisualBasic
Imports System
Imports System.Linq
Imports DevExpress.XtraGrid.Columns
Imports System.Collections.Generic
Imports DevExpress.XtraGrid.Views.Base
Imports System.ComponentModel
Imports DevExpress.Utils.Serializing

Namespace ColumnSpacing
	Public Class MyGridColumn
		Inherits GridColumn
		Public Sub New()
			MyBase.New()
		End Sub

		Private columnSpacing_Renamed As Integer = 0
		<Category("Appearance"), DefaultValue(0), XtraSerializableProperty(), Localizable(True)> _
		Public Property ColumnSpacing() As Integer
			Get
				Return columnSpacing_Renamed
			End Get
			Set(ByVal value As Integer)
				columnSpacing_Renamed = value
				View.LayoutChanged()
			End Set
		End Property
	End Class

	Public Class MyGridColumnCollection
		Inherits GridColumnCollection
		Public Sub New(ByVal view As ColumnView)
			MyBase.New(view)
		End Sub
		Protected Overrides Function CreateColumn() As GridColumn
			Return New MyGridColumn()
		End Function
		Default Public Shadows ReadOnly Property Item(ByVal fieldName As String) As MyGridColumn
			Get
				Return TryCast(ColumnByFieldName(fieldName), MyGridColumn)
			End Get
		End Property
		Default Public Shadows ReadOnly Property Item(ByVal index As Integer) As MyGridColumn
			Get
				Return CType(List(index), MyGridColumn)
			End Get
		End Property
	End Class
End Namespace
