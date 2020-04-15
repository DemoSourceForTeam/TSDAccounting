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
using TSD.AccountingSoft.WPF.UserDictionary;
using TSD.AccountingSoft.WPF.ViewModel;

namespace TSD.AccountingSoft.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var menuRegister = new List<SubItem>();
            menuRegister.Add(new SubItem("btnProc","Quy Trinh"));
            menuRegister.Add(new SubItem("btnRevenue","Thu Chi Tien"));
            menuRegister.Add(new SubItem("btnCategory","Danh muc"));
            var item = new DynamicMenuItem("Tổng hợp", menuRegister);
            grdDynamic.DataContext = item;

        }
        public void acc()
        {
            var userControl = new UserTest ();
        }

        private void dckWin_Loaded(object sender, RoutedEventArgs e)
        {
            acc();
        }

        private void dckApp_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnHidden_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {
                Application.Current.MainWindow = this;
                Application.Current.MainWindow.Width = 600;
                Application.Current.MainWindow.Height = 400;


            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        public void LoadDynamicItem()
        {
          

        }
    }
}
