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
    /// Логика взаимодействия для FourthForm.xaml
    /// </summary>
    public partial class FourthForm : Window
    {
        public FourthForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                // Донеры
                new Product { Name = "Туркиш Кебаб", Price = 180},
                new Product { Name = "Гимуси Кебаб", Price = 285},
                new Product { Name = "Берлин Кебаб", Price = 265},
                new Product { Name = "Гирус Кебаб", Price = 255},
                new Product { Name = "Марокканский Кебаб", Price = 230},
                new Product {Name = "Люла Кебаб", Price = 280}
            };
        }
    }
}
