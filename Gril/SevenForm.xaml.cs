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
    /// Логика взаимодействия для SevenForm.xaml
    /// </summary>
    public partial class SevenForm : Window
    {
        public SevenForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                new Product {Name = "Соус Томатный", Price = 30},
                new Product {Name = "Соус Йогуртовый", Price = 30},
                new Product {Name ="Соус Сырный", Price = 30},
                new Product {Name = "Майонез", Price = 30},
                new Product {Name = "Сыр", Price = 25},
                new Product {Name = "Сухарики", Price = 10},
                new Product {Name = "Халапенньо", Price = 25},
                new Product {Name = "Морковка корейская", Price = 10},
                new Product {Name = "Мясо говядина", Price = 70},
                new Product {Name = "Мясо курица", Price = 40},
                new Product {Name = "Кетчуп", Price = 30 },
                new Product {Name = "Лук", Price = 10},
                new Product {Name = "Огурец Свежий", Price = 15},
                new Product {Name = "Помидор", Price = 15},
                new Product {Name = "Огурец мариннованный", Price = 15}
            };
        }
    }
}
