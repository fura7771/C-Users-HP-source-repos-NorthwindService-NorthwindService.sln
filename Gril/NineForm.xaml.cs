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
    /// Логика взаимодействия для NineForm.xaml
    /// </summary>
    public partial class NineForm : Window
    {
        public NineForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                new Product {Name = "Чай зеленый п/к", Price = 35},
                new Product {Name = "Чай черный п/к", Price = 35},
                new Product {Name = "Чай чайнике", Price = 100},
                new Product {Name = "Капучино 200мл", Price = 110},
                new Product {Name = "Капучино 300мл", Price = 140},
                new Product {Name = "Латте 200мл", Price = 110},
                new Product {Name = "Латте 300мл", Price = 140},
                new Product {Name = "Американо 200мл", Price = 90},
                new Product {Name = "Флэд уайд 300мл", Price = 160},
                new Product {Name = "Коктейль Молочный 300мл", Price = 150},
                new Product {Name = "Фреш Апельсиновый 200мл", Price = 155},
                new Product {Name = "Сироп 15мл", Price =  25},
                new Product {Name = "Молоко 30мл", Price = 30},
                new Product {Name = "Сливки 30мл", Price = 50}
            };
        }
    }
}
