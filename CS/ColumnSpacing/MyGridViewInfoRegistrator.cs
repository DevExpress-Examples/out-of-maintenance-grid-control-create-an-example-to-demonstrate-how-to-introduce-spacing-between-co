using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base.ViewInfo;

namespace ColumnSpacing
{
    public class MyGridViewInfoRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return "MyGridView"; } }
        public override BaseView CreateView(GridControl grid) { return new MyGridView(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new MyGridViewInfo(view as MyGridView); }
        public override BaseViewPainter CreatePainter(BaseView view) { return new MyGridPainter(view as MyGridView); }
    }
}
