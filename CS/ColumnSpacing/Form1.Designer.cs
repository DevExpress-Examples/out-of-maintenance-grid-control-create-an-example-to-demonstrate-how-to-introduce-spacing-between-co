namespace ColumnSpacing
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
            this.btnEdit_colSpacing = new DevExpress.XtraEditors.ButtonEdit();
            this.lblColSpacing = new DevExpress.XtraEditors.LabelControl();
            this.cbRowCellStyle = new System.Windows.Forms.CheckBox();
            this.myGridControl1 = new ColumnSpacing.MyGridControl();
            this.myGridView1 = new ColumnSpacing.MyGridView();
            this.bandedGridView1 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit_colSpacing.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit_colSpacing
            // 
            this.btnEdit_colSpacing.EditValue = 0;
            this.btnEdit_colSpacing.Location = new System.Drawing.Point(86, 6);
            this.btnEdit_colSpacing.Name = "btnEdit_colSpacing";
            this.btnEdit_colSpacing.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.OK)});
            this.btnEdit_colSpacing.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.btnEdit_colSpacing.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.btnEdit_colSpacing.Size = new System.Drawing.Size(43, 20);
            this.btnEdit_colSpacing.TabIndex = 2;
            this.btnEdit_colSpacing.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_colSpacing_ButtonClick);
            this.btnEdit_colSpacing.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnEdit_colSpacing_KeyDown);
            // 
            // lblColSpacing
            // 
            this.lblColSpacing.Location = new System.Drawing.Point(5, 10);
            this.lblColSpacing.Name = "lblColSpacing";
            this.lblColSpacing.Size = new System.Drawing.Size(75, 13);
            this.lblColSpacing.TabIndex = 3;
            this.lblColSpacing.Text = "Column Spacing";
            // 
            // cbRowCellStyle
            // 
            this.cbRowCellStyle.AutoSize = true;
            this.cbRowCellStyle.Location = new System.Drawing.Point(12, 9);
            this.cbRowCellStyle.Name = "cbRowCellStyle";
            this.cbRowCellStyle.Size = new System.Drawing.Size(126, 17);
            this.cbRowCellStyle.TabIndex = 4;
            this.cbRowCellStyle.Text = "Custom RowCellStyle";
            this.cbRowCellStyle.UseVisualStyleBackColor = true;
            this.cbRowCellStyle.CheckedChanged += new System.EventHandler(this.cbRowCellStyle_CheckedChanged);
            // 
            // myGridControl1
            // 
            this.myGridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myGridControl1.Location = new System.Drawing.Point(2, 2);
            this.myGridControl1.MainView = this.myGridView1;
            this.myGridControl1.Name = "myGridControl1";
            this.myGridControl1.Size = new System.Drawing.Size(535, 345);
            this.myGridControl1.TabIndex = 5;
            this.myGridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.myGridView1,
            this.bandedGridView1});
            // 
            // myGridView1
            // 
            this.myGridView1.GridControl = this.myGridControl1;
            this.myGridView1.Name = "myGridView1";
            this.myGridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.myGridView1_RowCellStyle);
            this.myGridView1.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.myGridView1_FocusedColumnChanged);
            // 
            // bandedGridView1
            // 
            this.bandedGridView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1});
            this.bandedGridView1.GridControl = this.myGridControl1;
            this.bandedGridView1.Name = "bandedGridView1";
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.cbRowCellStyle);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 349);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(539, 34);
            this.panelControl1.TabIndex = 6;
            // 
            // panelControl3
            // 
            this.panelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl3.Controls.Add(this.lblColSpacing);
            this.panelControl3.Controls.Add(this.btnEdit_colSpacing);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(399, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(138, 30);
            this.panelControl3.TabIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.myGridControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(539, 349);
            this.panelControl2.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 383);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ColumnSpacing";
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit_colSpacing.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bandedGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ButtonEdit btnEdit_colSpacing;
        private DevExpress.XtraEditors.LabelControl lblColSpacing;
        private MyGridControl myGridControl1;
        private MyGridView myGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridView bandedGridView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private System.Windows.Forms.CheckBox cbRowCellStyle;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
    }
}

