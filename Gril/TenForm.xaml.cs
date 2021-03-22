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
    /// Логика взаимодействия для TenForm.xaml
    /// </summary>
    public partial class TenForm : Window
    {
        public TenForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                new Product {Name = "Ritter Sport", Price = 130},
                new Product {Name = "Milka", Price = 120},
                new Product {Name = "Алёнка", Price = 100},
                new Product {Name = "Nesquik", Price = 110},
                new Product {Name = "Орбит", Price = 35}
            };
        }
    }
}
