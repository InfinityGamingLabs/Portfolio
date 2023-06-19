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
    /// Interaction logic for Car.xaml
    /// </summary>
    public partial class Car : Window
    {
        CharacterDB _players = new CharacterDB();
        public Car()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            DataTable character = _players.SelectCar();
            if (character != null)
            {
                dgnfl.ItemsSource = character.DefaultView;
            }
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dgnfl.SelectedItem as DataRowView;

            Editcar edit = new Editcar(selectedRow);
            edit.ShowDialog();
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dgnfl.SelectedItem as DataRowView;

            if (_players.DeleteCar(selectedRow["PlayerID"].ToString()))
            {
                MessageBox.Show($"player {selectedRow["voornaam"]} verwijderd");
            }
            else
            {
                MessageBox.Show($"Verwijderen van {selectedRow["voornaam"]} mislukt");
            }

            FillDataGrid();
        }
        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Createcar create = new Createcar();
            create.ShowDialog();
            FillDataGrid();
        }

    }
}
