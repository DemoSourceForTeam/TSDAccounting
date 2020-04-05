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
using System.Windows.Shapes;

namespace TSD.AccountingSoft.WPF
{
    /// <summary>
    /// Interaction logic for tank.xaml
    /// </summary>
    public partial class LayoutFormBase : Window
    {
        public LayoutFormBase()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Di chuyển windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HeaderBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();

            if (e.ClickCount == 2)
            {
                if (this.WindowState.Equals(WindowState.Normal))
                {
                    this.WindowState = WindowState.Maximized;
                }
                else
                    this.WindowState = WindowState.Normal;
            }

        }
    }
}
