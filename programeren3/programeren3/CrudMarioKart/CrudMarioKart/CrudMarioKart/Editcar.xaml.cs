using System;
using System.Data;
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
    /// Interaction logic for Editcar.xaml
    /// </summary>
    public partial class Editcar : Window
    {
        public Editcar(DataRowView car)
        {
            InitializeComponent();
            FillScreen(car);
        }

        private void FillScreen(DataRowView car)
        {
            tbCarID.Text = car["PlayerID"].ToString();
            tbKart.Text = car["voornaam"].ToString();
            tbSpeed.Text = car["achternaam"].ToString();
            tbacceleration.Text = car["college"].ToString();
            tbWeight.Text = car["TeamID"].ToString();
        }

        private void CarUpdate_Click(object sender, RoutedEventArgs e)
        {
            CharacterDB characterDB = new CharacterDB();
            if (characterDB.UpdateCar(tbCarID.Text, tbKart.Text, tbSpeed.Text, tbacceleration.Text, tbWeight.Text))
            {
                MessageBox.Show($"Player {tbCarID.Text} aangepast");
            }
            else
            {
                MessageBox.Show($"Aanpassen van {tbCarID.Text} mislukt");
            }
            this.Close();
        }
    }
}
