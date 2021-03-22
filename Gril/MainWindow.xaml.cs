using MahApps.Metro.Controls.Dialogs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gril
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
         
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SecondForm secondForm = new SecondForm();
            secondForm.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ThirdForm thirdform = new ThirdForm();
            thirdform.ShowDialog();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            FourthForm fourthForm = new FourthForm();
            fourthForm.ShowDialog();

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            FifthForm fifthForm = new FifthForm();
            fifthForm.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            SexForm sexForm = new SexForm();
            sexForm.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            SevenForm sevenForm = new SevenForm();
            sevenForm.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            EighthForm eighthForm = new EighthForm();
            eighthForm.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            NineForm nineForm = new NineForm();
            nineForm.ShowDialog();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            TenForm tenForm = new TenForm();
            tenForm.ShowDialog();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            ElevenForm elevenForm = new ElevenForm();
            elevenForm.ShowDialog();
        }

        private void ItsNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
