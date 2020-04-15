using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSD.AccountingSoft.WPF.ViewModel
{
    public class DynamicMenuItem
    {
        public DynamicMenuItem(string header, List<SubItem> subItems)
        {
            Header = header;
            SubItems = subItems;
          
        }
        public string Header { get; set; }
        public List<SubItem> SubItems{get;set;}
    }
    public class SubItem
    {
        public SubItem(string name, string text)
        {
            Name = name;
            Text = text;
        }
        public string Name { get; set; }
        public string Text { get; set; }
    }

}
