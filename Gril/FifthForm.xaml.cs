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
    /// Логика взаимодействия для FifthForm.xaml
    /// </summary>
    public partial class FifthForm : Window
    {
        public FifthForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                new Product {Name ="Борщ", Price = 150},
                new Product {Name = "Шурпа из говядины", Price = 190},
                new Product {Name = "Мастава", Price = 170}

            };
        }
    }
}
