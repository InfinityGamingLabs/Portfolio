using project4.classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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
    /// Interaction logic for bestelpizza.xaml
    /// </summary>
    public partial class bestelpizza : Window, INotifyPropertyChanged
    {
       
        string Status;

        private static List<string> _toppings = new List<string>();

        public static List<string> Toppings
        {
            get { return _toppings; }
            set { _toppings = value; }
        }


        public bestelpizza()
        {
            InitializeComponent();
            lvOrderedPizzas.DataContext = this;
            PopulateOrders();

        }


        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        #region fields
        private readonly Pizzadb db = new Pizzadb();
        public BindingList<PizzaOrder> OrderedPizzass { get; set; } = new BindingList<PizzaOrder>();
        private string serviceDeskBericht = "Cannot connect to database";

        #endregion

        private ObservableCollection<string> _toppingOptions;
        public ObservableCollection<string> ToppingOptions
        {
            get
            {
                if (_toppingOptions == null)
                {
                    _toppingOptions = new ObservableCollection<string>();
                    _toppingOptions.Add("Pepperoni");
                    _toppingOptions.Add("Mushrooms");
                    _toppingOptions.Add("Onions");
                    _toppingOptions.Add("Sausage");
                    _toppingOptions.Add("Bacon");
                    _toppingOptions.Add("Extra cheese");
                }
                return _toppingOptions;
            }
        }

        private ObservableCollection<string> _pizzaTypes;
        public ObservableCollection<string> PizzaTypes
        {
            get
            {
                if (_pizzaTypes == null)
                {
                    _pizzaTypes = new ObservableCollection<string>();
                    _pizzaTypes.Add("Margherita");
                    _pizzaTypes.Add("Pepperoni");
                    _pizzaTypes.Add("Vegetarian");
                    _pizzaTypes.Add("BBQ Chicken");
                    _pizzaTypes.Add("Seafood");
                }
                return _pizzaTypes;
            }
        }

        private void PopulateOrders()
        {
            OrderedPizzas.Clear();
            string dbResult = db.GetPizzaOrders(OrderedPizzas);
            if (dbResult != Pizzadb.ok)
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }

        private ObservableCollection<PizzaOrder> orderedpizzas = new ObservableCollection<PizzaOrder>();
        public ObservableCollection<PizzaOrder> OrderedPizzas
        {
            get { return orderedpizzas; }
            set { orderedpizzas = value; OnPropertyChanged(); }
        }
        private PizzaOrder selectedpizzaorder;
        public PizzaOrder SelectedPizzaOrder
        {
            get
            { return selectedpizzaorder; }
            set
            {
                selectedpizzaorder = value;
                OnPropertyChanged();
            }
        }
        private PizzaOrder nieuwpizzaorder = new PizzaOrder();
        public PizzaOrder NieuwPizzaOrder
        {
            get { return nieuwpizzaorder; }
            set
            {
                nieuwpizzaorder = value;
                OnPropertyChanged();
            }
        }


        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                NieuwPizzaOrder.Name = txtName.Text;
                NieuwPizzaOrder.Street = txtStreet.Text;
                NieuwPizzaOrder.Town = txtTown.Text;
                NieuwPizzaOrder.addition = txtHouseNumberAddition.Text;
                NieuwPizzaOrder.HouseNumber = int.Parse(txtHouseNumber.Text);
                NieuwPizzaOrder.KlantId = int.Parse(txtKlantId.Text);
                if (string.IsNullOrEmpty(NieuwPizzaOrder.Name) || string.IsNullOrEmpty(NieuwPizzaOrder.Street) ||
            string.IsNullOrEmpty(NieuwPizzaOrder.Town))
                {
                    MessageBox.Show("Please fill in the required fields");
                    return;
                }
                else
                {
                    NieuwPizzaOrder.Toppings = ((ComboBoxItem)lstToppings.SelectedItem).Content.ToString();
                    NieuwPizzaOrder.PizzaType = ((ComboBoxItem)lstPizzaTypes.SelectedItem).Content.ToString();
                    MessageBox.Show("New Order added");
                }
                string dbResult = db.CreatePizzaOrder(NieuwPizzaOrder);
                if (dbResult == Pizzadb.ok)
                {
                    NieuwPizzaOrder = new PizzaOrder();
                }
                else
                {
                    MessageBox.Show(dbResult + serviceDeskBericht);
                }
                txtName.Text = "";
                txtStreet.Text = "";
                txtTown.Text = "";
                txtHouseNumber.Text = "";
                PopulateOrders();
                tbtotaalprice.Text = "€" + (lvOrderedPizzas.Items.Count * 15);
            }

            catch(Exception ex)
            {
                MessageBox.Show("je hebt niet alles in gevuld");
            }
           
           

        }

        private void orderpizzas_Click(object sender, RoutedEventArgs e)
        {
            order Order = new order();
            this.Close();
            Order.Show();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menu Menu = new menu();
            Menu.ShowDialog();
            this.Close();
        }
    }
}

