using System;
using System.Linq;
using DevExpress.XtraGrid.Columns;
using System.Collections.Generic;
using DevExpress.XtraGrid.Views.Base;
using System.ComponentModel;
using DevExpress.Utils.Serializing;

namespace ColumnSpacing
{
    public class MyGridColumn : GridColumn
    {
        public MyGridColumn() : base() {}

        int columnSpacing = 0;
        [Category("Appearance"),
        DefaultValue(0), XtraSerializableProperty(), Localizable(true)]
        public int ColumnSpacing {
            get {return columnSpacing;}
            set { columnSpacing = value; View.LayoutChanged(); }
        }
    }

    public class MyGridColumnCollection : GridColumnCollection
    {
        public MyGridColumnCollection(ColumnView view) : base(view) { }
        protected override GridColumn CreateColumn()
        {
            return new MyGridColumn();
        }
        public new MyGridColumn this[string fieldName] { get { return ColumnByFieldName(fieldName) as MyGridColumn; } }
        public new MyGridColumn this[int index] { get { return (MyGridColumn)List[index]; } }
    }
}
