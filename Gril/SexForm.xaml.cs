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
    /// Логика взаимодействия для SexForm.xaml
    /// </summary>
    public partial class SexForm : Window
    {
        public SexForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                 // Салаты / salads
                new Product { Name = "Греческий салат", Price = 130},
                new Product { Name = "Цезарь салат", Price = 110 },
                new Product { Name = "Капустный салат", Price = 85}
            };
        }
    }
}
