

using System;
using System.ComponentModel.Design;


namespace TSD.AccountingSoft.WindowsForm.FormBase.PropertyGrid
{
    public class XtraColumnCollectionEditor : CollectionEditor
    {
        public XtraColumnCollectionEditor(Type type)
            : base(type)
        {
        }

        protected override string GetDisplayText(object value)
        {
            return base.GetDisplayText(string.Format("[Name=], [Caption=]"));
        }
    }
}