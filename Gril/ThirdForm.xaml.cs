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
    /// Логика взаимодействия для Third.xaml
    /// </summary>
    public partial class ThirdForm : Window
    {
        public ThirdForm()
        {
            InitializeComponent();
            NewsList.ItemsSource = new[]
            {
                // Дисерты
                new Product { Name = "Прага", Price = 110 },
                new Product { Name = "Наполеон" , Price = 90},
                new Product { Name = "Чизкейк", Price = 130},
        
            };
        }
    }
}
