using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TSD.AccountingSoft.WPF.FormsBase
{
    /// <summary>
    /// Interaction logic for BaseList.xaml
    /// </summary>
    public partial class UserControlBaseList : UserControl
    {
        
        public UserControlBaseList()
        {
            InitializeComponent();
            
        }
        protected virtual void chan() {
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            chan();
        }
    }
}
