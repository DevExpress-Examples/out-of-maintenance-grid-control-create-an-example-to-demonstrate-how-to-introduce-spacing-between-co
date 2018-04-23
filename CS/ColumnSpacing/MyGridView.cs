using System;
using System.Linq;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils.Serializing;
using System.Collections.Generic;
using System.ComponentModel;

namespace ColumnSpacing
{
    public class MyGridView : GridView
    {
        public MyGridView() : this(null) { }
        public MyGridView(GridControl grid) : base(grid) {}
        protected override GridColumnCollection CreateColumnCollection() { return new MyGridColumnCollection(this); }
        protected override string ViewName { get { return "MyGridView"; } }

        [Browsable(false)]
        [XtraSerializableProperty(XtraSerializationVisibility.Collection, true, true, true, 0, XtraSerializationFlags.DefaultValue)]
        [XtraSerializablePropertyId(2)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new MyGridColumnCollection Columns
        {
            get { return base.Columns as MyGridColumnCollection; }
        }

    }
}