using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System.Drawing;
using DevExpress.XtraGrid.Columns;

namespace ColumnSpacing
{
    public class MyGridViewInfo : GridViewInfo
    {
        public MyGridViewInfo(DevExpress.XtraGrid.Views.Grid.GridView gridView) : base(gridView) { }

        protected override void CalcColumnsDrawInfo()
        {
            base.CalcColumnsDrawInfo();

            int count = View.VisibleColumns.Count + (AllowBehindColumn && (View.VisibleColumns.Count == 0 || true) ? 1 : 0);
            int firstIndex = ViewRects.IndicatorWidth > 0 ? -1 : 0;
            for (int i = firstIndex; i < count-1; i++)
            {
                GridColumn column = i > -1 ? View.GetVisibleColumn(i) : null;
                int space = 0;
                if (column != null) space = (column as MyGridColumn).ColumnSpacing;

                if ((ColumnsInfo.Count != 0) && (i >= 0) && (ColumnsInfo[i+1] != null))
                {
                    Rectangle rect = ColumnsInfo[i+1].Bounds;
                    if (i > 0)
                        ColumnsInfo[i + 1].Bounds = new Rectangle(rect.Left + space, rect.Top, rect.Width - (space * 2), rect.Height);
                    else
                        ColumnsInfo[i + 1].Bounds = new Rectangle(rect.Left, rect.Top, rect.Width - (space)-1, rect.Height);
                }
            }
        }
    }
}
