using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;


namespace ColumnSpacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            myGridControl1.DataSource = CreateTable(20);
            myGridView1.Columns[1].ColumnSpacing = 8;
            myGridView1.BestFitColumns();
        }

        private DataTable CreateTable(int RowCount)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Name", typeof(string));
            tbl.Columns.Add("ID", typeof(int));
            tbl.Columns.Add("Number", typeof(int));
            tbl.Columns.Add("Date", typeof(DateTime));
            for (int i = 0; i < RowCount; i++)
                tbl.Rows.Add(new object[] { String.Format("Name{0}", i), i, 3 - i, DateTime.Now.AddDays(i) });
            return tbl;
        }

        private void myGridView1_RowCellStyle(object sender, RowCellStyleEventArgs e)
        {
            if (cbRowCellStyle.Checked)
            {
                var view = myGridView1;
                if (e.RowHandle != view.FocusedRowHandle)
                {
                    if (e.RowHandle % 2 == 0)
                        e.Appearance.BackColor = Color.FromArgb(0xEB, 0xF9, 0xEB);
                    else
                        e.Appearance.BackColor = Color.FromArgb(0xED, 0xF9, 0xFA);
                }
                else
                    e.Appearance.BackColor = SystemColors.GradientInactiveCaption;
            }
        }

        private void myGridView1_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            btnEdit_colSpacing.EditValue = (e.FocusedColumn as MyGridColumn).ColumnSpacing;
        }

        private void btnEdit_colSpacing_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (myGridView1.FocusedColumn != null)
                (myGridView1.FocusedColumn as MyGridColumn).ColumnSpacing = Convert.ToInt32(btnEdit_colSpacing.EditValue);
        }

        private void btnEdit_colSpacing_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter) btnEdit_colSpacing_ButtonClick(this, null);
        }

        private void cbRowCellStyle_CheckedChanged(object sender, EventArgs e)
        {
            myGridView1.LayoutChanged();
        }
    }
}
