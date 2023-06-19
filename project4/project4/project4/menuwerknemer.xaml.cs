using project4.classes;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace project4
{
    /// <summary>
    /// Interaction logic for menuwerknemer.xaml
    /// </summary>
    public partial class menuwerknemer : Window
    {
        public menuwerknemer()
        {
            InitializeComponent();
        }

        private void pizza_Click(object sender, RoutedEventArgs e)
        {

            MainWindow mainWindow = new MainWindow();
            mainWindow.ShowDialog();
            this.Close();
        }

        private void product_Click(object sender, RoutedEventArgs e)
        {

            Units producten = new Units();
            producten.ShowDialog();
            this.Close();

        }

        private void product_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void topings_Click(object sender, RoutedEventArgs e)
        {

            toppings producten = new toppings();
            producten.ShowDialog();
            this.Close();
        }

        private void mederwerkers_Click(object sender, RoutedEventArgs e)
        {

            Medewerker producten = new Medewerker();
            producten.ShowDialog();
            this.Close();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menu Menu = new menu();
            Menu.ShowDialog();
            this.Close();
        }
    }
}
