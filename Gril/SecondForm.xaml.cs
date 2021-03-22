using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gril
{
    /// <summary>
    /// Логика взаимодействия для SecondForm.xaml
    /// </summary>
    public partial class SecondForm : Window
    {
        public SecondForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                // Выпочки 
                new Product { Name = "Самса", Price = 80},
                new Product { Name = "Слойка с сыром", Price = 85},
                new Product { Name = "Пирожки", Price = 50}
            };
        }
      
    }
}
