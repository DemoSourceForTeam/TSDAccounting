using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using TSD.AccountingSoft.WPF.UserDictionary;
using TSD.AccountingSoft.WPF.ViewModel;

namespace TSD.AccountingSoft.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainAccounting : Window
    {
        public MainAccounting()
        {
            InitializeComponent();
        }
     

     

        //public void LoadDynamicItem(int sb)

        //{

        //}
        //public void AddEventSBMainMenu()
        //{
        //    foreach (Control item in sbMainMenu.Children)
        //    {
        //        if (item is Button)
        //            ((Button)item).Click += sbButton_Click;

        //    }
        //}
        //void sbButton_Click(object sender, RoutedEventArgs e)
        //{
           
        //    var menuRegister = new List<SubItem>();
        //    var item = new DynamicMenuItem();
        //    switch ((sender as Button).Name.ToString())
        //    {
        //        case "btnSynthetic":
                   
        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnRevenue", "Thu chi tiền", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh Mục", @"Resource/Icon/Group_9348.png"));
        //            item.Header = "Tổng hợp";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break; 
        //        case "btnCash":
                   
        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnProc", "Thu tiền mặt", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnProc", "Chi tiền mặt", @"Resource/Icon/Group_9927.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh mục", @"Resource/Icon/Group_9348.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Giấy báo có", @"Resource/Icon/Group_9921.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Giấy báo nợ", @"Resource/Icon/Group_9920.png"));
        //            item.Header = "Tiền mặt";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break;
        //        case "btnPurchase":

        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnRevenue", "Thu chi tiền", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh Mục", @"Resource/Icon/Group_9348.png"));
        //            item.Header = "Mua hàng";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break;
        //        case "btnSell":

        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnRevenue", "Thu chi tiền", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh Mục", @"Resource/Icon/Group_9348.png"));
        //            item.Header = "Bán hàng";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break; 
        //        case "btnSupplies":

        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnRevenue", "Thu chi tiền", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh Mục", @"Resource/Icon/Group_9348.png"));
        //            item.Header = "Vật tư";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break; 
        //        case "btnFixedAsset":

        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnRevenue", "Thu chi tiền", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh Mục", @"Resource/Icon/Group_9348.png"));
        //            item.Header = "Tài sản cố định";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break;
        //        case "btnInventoryItems":

        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnRevenue", "Thu chi tiền", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh Mục", @"Resource/Icon/Group_9348.png"));
        //            item.Header = "Công cụ dụng cụ";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break;

        //        case "btnPrices":

        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnRevenue", "Thu chi tiền", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh Mục", @"Resource/Icon/Group_9348.png"));
        //            item.Header = "Giá thành";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break;

        //        case "btnInvestor":
        //            menuRegister.Add(new SubItem("btnProc", "Quy Trình", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnRevenue", "Thu chi tiền", @"Resource/Icon/Group_9349.png"));
        //            menuRegister.Add(new SubItem("btnCategory", "Danh Mục", @"Resource/Icon/Group_9348.png"));
        //            item.Header = "Chủ đầu tư";
        //            item.SubItems = menuRegister;
        //            grdDynamic.DataContext = item;
        //            break;


        //    }
        //}

        void sbSubMenu_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show((sender as StackPanel).Tag.ToString());
            //switch ((sender as Button).Name.ToString())
            //{
            //    case "btnSynthetic":
            //        MessageBox.Show((sender as Button).Name.ToString());
            //        break;
            //}
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //AddEventSBMainMenu();
        }

       

        private void menuSystem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = e.Source as MenuItem;
            switch (menuItem.Name)

            {
                case "btnDictionary":
                    var userControl = new UCDictionaryList();
                    userControl.Infor = menuItem;
                    mainPanelUC.Children.Clear();
                    mainPanelUC.Children.Add(userControl);
                    break;
            }
        }
        #region EventWindows
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click_1(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Maximized)
            {

                this.WindowState = WindowState.Normal;


            }
            else
            {
                this.WindowState = WindowState.Maximized;
            }
        }

        private void btnHidden_Click_1(object sender, RoutedEventArgs e)
        {

            this.WindowState = WindowState.Minimized;

        }
        #endregion
    }
}
