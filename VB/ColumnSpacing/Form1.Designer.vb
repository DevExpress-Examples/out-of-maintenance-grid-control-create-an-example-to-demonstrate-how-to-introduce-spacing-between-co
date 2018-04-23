Imports Microsoft.VisualBasic
Imports System
Namespace ColumnSpacing
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
			Me.btnEdit_colSpacing = New DevExpress.XtraEditors.ButtonEdit()
			Me.lblColSpacing = New DevExpress.XtraEditors.LabelControl()
			Me.cbRowCellStyle = New System.Windows.Forms.CheckBox()
			Me.myGridControl1 = New ColumnSpacing.MyGridControl()
			Me.myGridView1 = New ColumnSpacing.MyGridView()
			Me.bandedGridView1 = New DevExpress.XtraGrid.Views.BandedGrid.BandedGridView()
			Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand()
			Me.panelControl1 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl3 = New DevExpress.XtraEditors.PanelControl()
			Me.panelControl2 = New DevExpress.XtraEditors.PanelControl()
			CType(Me.btnEdit_colSpacing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl1.SuspendLayout()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl3.SuspendLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelControl2.SuspendLayout()
			Me.SuspendLayout()
			' 
			' btnEdit_colSpacing
			' 
			Me.btnEdit_colSpacing.EditValue = 0
			Me.btnEdit_colSpacing.Location = New System.Drawing.Point(86, 6)
			Me.btnEdit_colSpacing.Name = "btnEdit_colSpacing"
			Me.btnEdit_colSpacing.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)})
			Me.btnEdit_colSpacing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.btnEdit_colSpacing.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
			Me.btnEdit_colSpacing.Size = New System.Drawing.Size(43, 20)
			Me.btnEdit_colSpacing.TabIndex = 2
'			Me.btnEdit_colSpacing.ButtonClick += New DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(Me.btnEdit_colSpacing_ButtonClick);
'			Me.btnEdit_colSpacing.KeyDown += New System.Windows.Forms.KeyEventHandler(Me.btnEdit_colSpacing_KeyDown);
			' 
			' lblColSpacing
			' 
			Me.lblColSpacing.Location = New System.Drawing.Point(5, 10)
			Me.lblColSpacing.Name = "lblColSpacing"
			Me.lblColSpacing.Size = New System.Drawing.Size(75, 13)
			Me.lblColSpacing.TabIndex = 3
			Me.lblColSpacing.Text = "Column Spacing"
			' 
			' cbRowCellStyle
			' 
			Me.cbRowCellStyle.AutoSize = True
			Me.cbRowCellStyle.Location = New System.Drawing.Point(12, 9)
			Me.cbRowCellStyle.Name = "cbRowCellStyle"
			Me.cbRowCellStyle.Size = New System.Drawing.Size(126, 17)
			Me.cbRowCellStyle.TabIndex = 4
			Me.cbRowCellStyle.Text = "Custom RowCellStyle"
			Me.cbRowCellStyle.UseVisualStyleBackColor = True
'			Me.cbRowCellStyle.CheckedChanged += New System.EventHandler(Me.cbRowCellStyle_CheckedChanged);
			' 
			' myGridControl1
			' 
			Me.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.myGridControl1.Location = New System.Drawing.Point(2, 2)
			Me.myGridControl1.MainView = Me.myGridView1
			Me.myGridControl1.Name = "myGridControl1"
			Me.myGridControl1.Size = New System.Drawing.Size(535, 345)
			Me.myGridControl1.TabIndex = 5
			Me.myGridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.myGridView1, Me.bandedGridView1})
			' 
			' myGridView1
			' 
			Me.myGridView1.GridControl = Me.myGridControl1
			Me.myGridView1.Name = "myGridView1"
'			Me.myGridView1.RowCellStyle += New DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(Me.myGridView1_RowCellStyle);
'			Me.myGridView1.FocusedColumnChanged += New DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(Me.myGridView1_FocusedColumnChanged);
			' 
			' bandedGridView1
			' 
			Me.bandedGridView1.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() { Me.gridBand1})
			Me.bandedGridView1.GridControl = Me.myGridControl1
			Me.bandedGridView1.Name = "bandedGridView1"
			' 
			' gridBand1
			' 
			Me.gridBand1.Caption = "gridBand1"
			Me.gridBand1.Name = "gridBand1"
			' 
			' panelControl1
			' 
			Me.panelControl1.Controls.Add(Me.panelControl3)
			Me.panelControl1.Controls.Add(Me.cbRowCellStyle)
			Me.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.panelControl1.Location = New System.Drawing.Point(0, 349)
			Me.panelControl1.Name = "panelControl1"
			Me.panelControl1.Size = New System.Drawing.Size(539, 34)
			Me.panelControl1.TabIndex = 6
			' 
			' panelControl3
			' 
			Me.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
			Me.panelControl3.Controls.Add(Me.lblColSpacing)
			Me.panelControl3.Controls.Add(Me.btnEdit_colSpacing)
			Me.panelControl3.Dock = System.Windows.Forms.DockStyle.Right
			Me.panelControl3.Location = New System.Drawing.Point(399, 2)
			Me.panelControl3.Name = "panelControl3"
			Me.panelControl3.Size = New System.Drawing.Size(138, 30)
			Me.panelControl3.TabIndex = 5
			' 
			' panelControl2
			' 
			Me.panelControl2.Controls.Add(Me.myGridControl1)
			Me.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill
			Me.panelControl2.Location = New System.Drawing.Point(0, 0)
			Me.panelControl2.Name = "panelControl2"
			Me.panelControl2.Size = New System.Drawing.Size(539, 349)
			Me.panelControl2.TabIndex = 7
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(539, 383)
			Me.Controls.Add(Me.panelControl2)
			Me.Controls.Add(Me.panelControl1)
			Me.Name = "Form1"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "ColumnSpacing"
			CType(Me.btnEdit_colSpacing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.myGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bandedGridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.panelControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl1.ResumeLayout(False)
			Me.panelControl1.PerformLayout()
			CType(Me.panelControl3, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl3.ResumeLayout(False)
			Me.panelControl3.PerformLayout()
			CType(Me.panelControl2, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelControl2.ResumeLayout(False)
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents btnEdit_colSpacing As DevExpress.XtraEditors.ButtonEdit
		Private lblColSpacing As DevExpress.XtraEditors.LabelControl
		Private myGridControl1 As MyGridControl
		Private WithEvents myGridView1 As MyGridView
		Private bandedGridView1 As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView
		Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand
		Private WithEvents cbRowCellStyle As System.Windows.Forms.CheckBox
		Private panelControl1 As DevExpress.XtraEditors.PanelControl
		Private panelControl2 As DevExpress.XtraEditors.PanelControl
		Private panelControl3 As DevExpress.XtraEditors.PanelControl
	End Class
End Namespace

