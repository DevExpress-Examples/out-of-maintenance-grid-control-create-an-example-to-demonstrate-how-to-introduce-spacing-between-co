using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.Grid;
using System.Drawing;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Base;

namespace ColumnSpacing
{
    class MyGridPainter : GridPainter
    {
        public MyGridPainter(GridView view) : base(view) {}

        protected override void DrawContents(GridViewDrawArgs e)
        {
            base.DrawContents(e);
            DrawSpacingColumns(e);
        }


        protected virtual void DrawSpacingColumns(GridViewDrawArgs e)
        {
            RectangleF columnBounds;
            RectangleF columnSpacing;

            for (int i = 0; i < View.VisibleColumns.Count; i++)
            {
                var myColumn = View.VisibleColumns[i] as MyGridColumn;
                columnBounds = GetColumnBounds(View as MyGridView, myColumn);
                if (columnBounds != null)
                {
                    columnBounds.Height -= 2;
                    if (i > 0)
                    {
                        columnSpacing = new RectangleF(columnBounds.Left - myColumn.ColumnSpacing, columnBounds.Top, myColumn.ColumnSpacing, columnBounds.Height);
                        e.Graphics.FillRectangle(e.ViewInfo.PaintAppearance.Empty.GetBackBrush(e.Cache), columnSpacing);
                    }

                    if ((i == View.VisibleColumns.Count - 1) && (myColumn.ColumnSpacing != 0))
                    {
                        columnSpacing = new RectangleF(columnBounds.Left + columnBounds.Width, columnBounds.Top, View.ViewRect.Width, columnBounds.Height);
                    }
                    else
                    {
                        columnSpacing = new RectangleF(columnBounds.Left + columnBounds.Width, columnBounds.Top, myColumn.ColumnSpacing, columnBounds.Height);
                    }
                    e.Graphics.FillRectangle(e.ViewInfo.PaintAppearance.Empty.GetBackBrush(e.Cache), columnSpacing);

                    columnBounds.X = columnBounds.Left - 1;
                    columnBounds.Width = 1;
                    columnBounds.Height += 1;

                    e.Graphics.FillRectangle(e.ViewInfo.PaintAppearance.VertLine.GetBackBrush(e.Cache), columnBounds);
                }
            }
        }

        RectangleF GetColumnHeaderBounds(MyGridView view, MyGridColumn col)
        {
            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            if (viewInfo.IsReady && !viewInfo.IsDataDirty)
            {
                foreach (GridColumnInfoArgs info in viewInfo.ColumnsInfo)
                {
                    if (info.Column == col)
                        return info.Bounds;
                }
            }
            return RectangleF.Empty;
        }

        RectangleF GetColumnBounds(MyGridView view, MyGridColumn col)
        {
            RectangleF result = GetColumnHeaderBounds(view, col);
            if (result.IsEmpty)
                return result;
            GridViewInfo viewInfo = view.GetViewInfo() as GridViewInfo;
            int rowsHeight = viewInfo.RowsLoadInfo.ResultRowsHeight;
            result.Height += rowsHeight;
            return result;
        }
    }
}
