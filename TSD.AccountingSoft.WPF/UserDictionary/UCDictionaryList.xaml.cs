using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using TSD.AccountingSoft.Models;
using TSD.AccountingSoft.Models.BusinessObject.Dictionary;
using TSD.AccountingSoft.ViewModel.Dictionary;

namespace TSD.AccountingSoft.WPF.UserDictionary
{
    /// <summary>
    /// Interaction logic for UCDictionaryList.xaml
    /// </summary>
    public partial class UCDictionaryList : UserControl
    {
        public RefTypeViewModel RefTypeView { get; set; }
        public object Infor { get; set; }
        public UCDictionaryList()
        {
            InitializeComponent();
            RefTypeView = new RefTypeViewModel(new Provider());
            grdList.ItemsSource = RefTypeView.Display();
           
            grdControl.ItemsSource = RefTypeView.Display();
            grdControl.Columns["RefTypeID"].Header = "abc";
            
            
           // grdList.Columns[1].Header = "abc";
        }

        private void btnAdd_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            txtCaption.Text = Infor.ToString();

        }
    }
}
