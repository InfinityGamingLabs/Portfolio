using project4.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for Units.xaml
    /// </summary>
    public partial class Units : Window, INotifyPropertyChanged // die zorgt dat gegevens  uit de db haalt en hier in de appl zit  
    {
        public Units()
        { 
             InitializeComponent();
             DataContext = this;
             PopulateUnit();  
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null) 
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region fields
        private readonly Pizzadb db = new Pizzadb();//
        private readonly string serviceDeskBericht = "\n\nNeem contact op met de service desk";
        #endregion

        private void PopulateUnit()
        { 
            Unit.Clear();
            string dbResult = db.GetUnit(Unit);
            if (dbResult != Pizzadb.ok)
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }


        private ObservableCollection<Unit> unit = new();
        public ObservableCollection<Unit> Unit
        {
            get { return unit; } 
            set { unit = value; OnPropertyChanged(); }
        }
        private Unit selectedUnit;
        public Unit selectedunit
        {
            get
            { return selectedUnit; }
            set
            {
                selectedUnit = value;
                OnPropertyChanged();
            }
        }
        private Unit nieuwunit = new();
        public Unit NieuwUnit
        {

            get { return nieuwunit; }
            set
            {
                nieuwunit = value;
                OnPropertyChanged();
            }
        }

        private void CreateName_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NieuwUnit.Name) && (NieuwUnit.Prijs == null))
            {
                MessageBox.Show("Vul naam van de unit en prijs in");
                return;
            }

            if (tbName.Text == "")
            {
                MessageBox.Show("je moet alles invullen");
            }

            string dbResult = db.CreateUnit(NieuwUnit);
            if (dbResult == Pizzadb.ok)
            {
                PopulateUnit();
                MessageBox.Show("Nieuwe Unit is toegevoegd");
                NieuwUnit = new();
            }
           /* else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }*/
        }

        private void UpdateName_Click(object sender, RoutedEventArgs e)
        {
            if (selectedUnit == null)
            {
                MessageBox.Show("Selecteer de naam van de persoon die u wil wijzigen.");
                return;
            }

            if (string.IsNullOrEmpty(selectedUnit.Name))
            {
                MessageBox.Show("Vul de naam van de persoon in.");
                return;
            }

            string dbResult = db.UpdateUnit(selectedUnit.Unit_id, selectedUnit);
            if (dbResult == Pizzadb.ok)
            {
                PopulateUnit();
            }
            else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }

        private void DeleteName_Click(object sender, RoutedEventArgs e)
        {

            if (selectedUnit != null)
            {
                Unit unit = selectedUnit;
                string dbResult = db.DeleteUnit(unit.Unit_id);

                if (dbResult == Pizzadb.ok)
                {
                    PopulateUnit();
                }
                else
                {
                    MessageBox.Show(dbResult + serviceDeskBericht);
                }
            }
        }

        private void tbname_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "^[a-zA-Z ]*$"))
            {
                e.Handled = true;
            }
        }

        private void tbName_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "^[a-zA-Z ]*$"))
            {
                e.Handled = true;
            }
        }

        private void tbaantal_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int value;
            if (!int.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }

        private void tbPrijs_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int value;
            if (!int.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }

        private void tbAantal_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            int value;
            if (!int.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }

        private void tbprijs_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            int value;
            if (!int.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }

        private void mederwerkermenu_Click(object sender, RoutedEventArgs e)
        {
            menuwerknemer werkermenu = new menuwerknemer();
            werkermenu.ShowDialog();
            this.Close();
        }
    }
}