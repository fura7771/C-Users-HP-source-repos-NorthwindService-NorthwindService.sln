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
    /// Логика взаимодействия для EighthForm.xaml
    /// </summary>
    public partial class EighthForm : Window
    {
        public EighthForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                new Product {Name = "Кола 0,33", Price = 49},
                new Product {Name = "Кола 0,5", Price = 69},
                new Product {Name = "Фанта 0,33", Price = 49},
                new Product {Name = "Соки", Price = 70},
                new Product {Name = "Морс фирменный", Price = 49}
            };

        }
    }
}
