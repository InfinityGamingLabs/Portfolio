using System.Data;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CrudMarioKart
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CharacterDB _nfl = new CharacterDB();
        public MainWindow()
        {
            InitializeComponent();
            FillDataGrid();
        }

        private void FillDataGrid()
        {
            DataTable character = _nfl.selectteams();
            if (character != null)
            {
                dgnfl.ItemsSource = character.DefaultView;
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dgnfl.SelectedItem as DataRowView;

            Edit edit = new Edit(selectedRow);
            edit.ShowDialog();
            FillDataGrid();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = dgnfl.SelectedItem as DataRowView;

            if (_nfl.DeleteCharacter(selectedRow["TeamID"].ToString()))
            {
                MessageBox.Show($"team {selectedRow["naam"]} verwijderd");
            }
            else
            {
                MessageBox.Show($"Verwijderen van {selectedRow["naam"]} mislukt");
            }

            FillDataGrid();
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            Create create = new Create();
            create.ShowDialog();
            FillDataGrid();
        }

        private void CarDB_Click(object sender, RoutedEventArgs e)
        {
            Car car = new Car();
            car.ShowDialog();
            FillDataGrid();
        }
    }
}
