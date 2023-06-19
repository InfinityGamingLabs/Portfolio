using project4.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.DirectoryServices.ActiveDirectory;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Threading.Tasks;
using Timer = System.Timers.Timer;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace project4
{
    /// <summary>
    /// Interaction logic for order.xaml
    /// </summary>
    public partial class order : Window
    {
        private List<PizzaOrder> orders = new List<PizzaOrder>();
        private Timer _timer; // added member variable for Timer

        public order()
        {
            InitializeComponent();
            RefreshOrders();
            _statusIndex = 0;
            Status = _statusList[_statusIndex];
            _timer = new Timer(20000); // 20 seconds
            _timer.Elapsed += new ElapsedEventHandler(OnTimerElapsed); // Add this line
            _timer.Start();
            DataContext = this;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private ObservableCollection<PizzaOrder> orderedpizzas = new ObservableCollection<PizzaOrder>();
        public ObservableCollection<PizzaOrder> OrderedPizzas
        {
            get { return orderedpizzas; }
            set { orderedpizzas = value; OnPropertyChanged(); }
        }

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; OnPropertyChanged(); }
        }

        private int _statusIndex;
        public readonly List<string> _statusList = new List<string>
    {
        PizzaStatus.Wachten,
        PizzaStatus.Voorbereiding,
        PizzaStatus.oven,
        PizzaStatus.onderweg,
        PizzaStatus.klaar
    };

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            if (_statusIndex == 0)
            {
                Status = PizzaStatus.Wachten;
            }
            else if (_statusIndex >= 3)
            {
                _statusIndex = 4;
            }
            _statusIndex++;
            Status = _statusList[_statusIndex];
        }


        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            RefreshOrders();
            _timer.Start();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            int klantId;
            if (!int.TryParse(KlantIdTextBox.Text, out klantId))
            {
                MessageBox.Show("Please enter a valid KlantId.");
                return;
            }

            ICollection<PizzaOrder> orders = new List<PizzaOrder>();
            string result = Pizzadb.GetPizzaOrdersByKlantId(orders, klantId);
            if (result != "ok")
            {
                MessageBox.Show("An error occurred while retrieving PizzaOrders: " + result);
                return;
            }

            // Display the PizzaOrders in a ListView or any other UI control
            // For example:
            OrdersListView.ItemsSource = orders;
            _timer.Start();
        }

        private void RefreshOrders()
        {
            int klantId = 0; // or any default value you prefer
            orderedpizzas.Clear();
            Pizzadb pizzadb = new Pizzadb(); // create an instance of Pizzadb
            string result = pizzadb.GetPizzaOrders(orderedpizzas);
            if (result != "ok")
            {
                MessageBox.Show(result);
                return;
            }

            OrdersListView.ItemsSource = orderedpizzas;
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            if (OrdersListView.SelectedItem == null)
            {
                MessageBox.Show("Please select an order to cancel");
                return;
            }

            PizzaOrder selectedOrder = OrdersListView.SelectedItem as PizzaOrder;
            Pizzadb.CancelPizzaOrder(selectedOrder.OrderId);
            RefreshOrders();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            menu Menu = new menu();
            Menu.ShowDialog();
            this.Close();
        }
    }
}