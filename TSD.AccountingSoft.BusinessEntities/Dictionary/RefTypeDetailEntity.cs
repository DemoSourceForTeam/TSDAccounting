﻿


using System.Collections.ObjectModel;

namespace TSD.AccountingSoft.BusinessEntities.Dictionary
{
    public class RefTypeDetailEntity
    {
        public long RefTypeID { get; set; }
        public long RefTypeDetailID {get;set;}
        public int LayoutType { get; set; }
        public string ColumnName { get; set; }
        public string ColumnCaption { get; set; }
        public int  ColumnPosition { get; set; }
        public decimal ColumnWidth { get; set; }
        public int  DataType { get; set; }
        public string Repository { get; set; }
        public bool IsVisible { get; set; }


    }
}
