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
    /// Interaction logic for toppings.xaml
    /// </summary>
    public partial class toppings : Window, INotifyPropertyChanged
    {
        public toppings()
        {
            InitializeComponent();
            DataContext = this;
            PopulateToppings();
        }

        private void PopulateToppings()
        {
            Topping.Clear();
            string dbResult = db.GetToppings(Topping);
            if (dbResult != Pizzadb.ok)
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
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


        private ObservableCollection<Toppings> topping = new();
        public ObservableCollection<Toppings> Topping
        {
            get { return topping; }
            set { topping = value; OnPropertyChanged(); }
        }
        private Toppings selectedtopping;
        public Toppings SelectedTopping
        {
            get
            { return selectedtopping; }
            set
            {
                selectedtopping = value;
                OnPropertyChanged();
            }
        }
        private Toppings nieuwtopping = new();
        public Toppings NieuwTopping
        {
            get { return nieuwtopping; }
            set
            {
                nieuwtopping = value;
                OnPropertyChanged();
            }
        }

        private void UpdateName_Click(object sender, RoutedEventArgs e)
        {
            if (selectedtopping == null)
            {
                MessageBox.Show("Selecteer de naam van de persoon die u wil wijzigen.");
                return;
            }

            if (string.IsNullOrEmpty(selectedtopping.Name))
            {
                MessageBox.Show("Vul de naam van de persoon in.");
                return;
            }

            string dbResult = db.UpdateToppings(selectedtopping.Toppings_id, selectedtopping);
            if (dbResult == Pizzadb.ok)
            {
                PopulateToppings();
            }
            else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }

        private void DeleteName_Click(object sender, RoutedEventArgs e)
        {
            if (selectedtopping != null)
            {
                Toppings toppings = selectedtopping;
                string dbResult = db.DeleteToppings(toppings.Toppings_id);

                if (dbResult == Pizzadb.ok)
                {
                    PopulateToppings();
                }
                else
                {
                    MessageBox.Show(dbResult + serviceDeskBericht);
                }
            }
        }

        private void CreateName_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NieuwTopping.Name) && (NieuwTopping.Prijs == null))
            {
                MessageBox.Show("Vul naam van de pizza en prijs in");
                return;
            }

            if (tbName.Text == "")
            {
                MessageBox.Show("je moet alles invullen");
            }

            string dbResult = db.CreateToppings(NieuwTopping);
            if (dbResult == Pizzadb.ok)
            {
                PopulateToppings();
                MessageBox.Show("Nieuwe Tpping is toegevoegd");
                NieuwTopping = new();
            }
           // else
          //  {
          //     MessageBox.Show(dbResult + serviceDeskBericht);
           // }
        }

        private void tbprijs_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int value;
            if (!int.TryParse(e.Text, out value))
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

        private void tbPrijs_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
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

        private void mederwerkermenu_Click(object sender, RoutedEventArgs e)
        {
            menuwerknemer werkermenu = new menuwerknemer();
            werkermenu.ShowDialog();
            this.Close();
        }
    }
}
