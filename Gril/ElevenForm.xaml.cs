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
    /// Логика взаимодействия для ElevenForm.xaml
    /// </summary>
    public partial class ElevenForm : Window
    {
        public ElevenForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                new Product {Name ="Пакет", Price = 3},
                new Product {Name = "Антисептик", Price = 100},
                new Product {Name = "Маска", Price = 20}
            };
        }
    }
}
