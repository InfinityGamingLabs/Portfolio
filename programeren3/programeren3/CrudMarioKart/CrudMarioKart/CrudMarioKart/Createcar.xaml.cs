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

namespace CrudMarioKart
{
    /// <summary>
    /// Interaction logic for Createcar.xaml
    /// </summary>
    public partial class Createcar : Window
    {
        public Createcar()
        {
            InitializeComponent();
        }

        private void CarCreate_Click(object sender, RoutedEventArgs e)
        {
            CharacterDB characterDB = new CharacterDB();
            if (characterDB.InsertCar(tbCarID.Text, tbKart.Text, tbSpeed.Text, tbacceleration.Text, tbWeight.Text))
            {
                MessageBox.Show($"player aangemaakt");
            }
            else
            {
                MessageBox.Show($"Aanmaken mislukt");
            }
            this.Close();
        }
    }
}
