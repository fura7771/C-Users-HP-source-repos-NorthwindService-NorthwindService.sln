using Kassa;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
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


namespace Gril
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
          /// FrameWindows.Navigate(new ProductDetals());
            DGridCategorys.ItemsSource = KassaEntities.GetContext().Categories.ToList();
        }
        
        private void ProductOpin_Click(object sender, RoutedEventArgs e)
        {
             FrameWindows.Content = new ProductDetals();
        }
        
        private void Kassa_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackTo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ClosedOrders_Click(object sender, RoutedEventArgs e)
        {
       
        }

        private void ListBack_Click(object sender, RoutedEventArgs e)
        {
           
        }
      
    }
}
