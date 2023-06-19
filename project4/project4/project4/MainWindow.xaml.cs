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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace project4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        { 
            InitializeComponent();
            DataContext = this;
            Populatepizza();
        }
        private void Populatepizza()
        {
            Pizzas.Clear();
            string dbResult = db.GetPizzas(Pizzas);
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


        private ObservableCollection<Pizza> pizzas = new();
        public ObservableCollection<Pizza> Pizzas
        {
            get { return pizzas; }
            set { pizzas = value; OnPropertyChanged(); }
        }
        private Pizza? selectedPizza;
        public Pizza? SelectedPizza
        {
            get
            { return selectedPizza; }
            set
            {
                selectedPizza = value;
                OnPropertyChanged();
            }
        }
        private Pizza nieuwPizza = new();
        public Pizza NieuwPizza
        {
            get { return nieuwPizza; }
            set
            {
                nieuwPizza = value;
                OnPropertyChanged();
            }
        }



        private void CreatePizza_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(NieuwPizza.Name) && (NieuwPizza.Prijs == null))
            {
                MessageBox.Show("Vul naam van de pizza en prijs in");
                return;

            }
                if (tbName.Text == "")
                {
                    MessageBox.Show("je moet alles invullen");
                }

            string dbResult = db.CreatePizzas(NieuwPizza);
            if (dbResult == Pizzadb.ok)
            {
                Populatepizza();
                MessageBox.Show("Nieuwe pizza toegevoegd");
                NieuwPizza = new();
            }
            /* else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }*/
        }

        private void UpdatePizza_Click(object sender, RoutedEventArgs e)
        {
            if (selectedPizza == null)
            {
                MessageBox.Show("Selecteer de naam van de persoon die u wil wijzigen.");
                return;
            }

            if (string.IsNullOrEmpty(selectedPizza.Name))
            {
                MessageBox.Show("Vul de naam van de persoon in.");
                return;
            }

            string dbResult = db.Updatepizza(selectedPizza.pizza_Id, selectedPizza);
            if (dbResult == Pizzadb.ok)
            {
                Populatepizza();
            }
            else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }

        private void DeletePizza_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedPizza != null)
            {
                Pizza pizza = SelectedPizza;
                string dbResult = db.Deletepizza(pizza.pizza_Id);

                if (dbResult == Pizzadb.ok)
                {
                    Populatepizza();
                }
                else
                {
                    MessageBox.Show(dbResult + serviceDeskBericht);
                }
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
