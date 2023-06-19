using eindopdracht.Models;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace eindopdracht.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion


        #region fields
        private readonly landenDB db = new landenDB();
        private readonly string serviceDeskBericht = "\n\nNeem contact op met de service desk";
        #endregion

        #region Properties
        private ObservableCollection<persons> person = new();
        public ObservableCollection<persons> Person
        {
            get { return person; }
            set { person = value; OnPropertyChanged(); }
        }
        private persons? selectedPerson;
        public persons? SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                selectedPerson = value; OnPropertyChanged();
                OnPropertyChanged();
            }
        }

        private ObservableCollection<countries> country = new();
        public ObservableCollection<countries> Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged(); }
        }
        private countries? selectedcountry;
        public countries? SelectedCountry
        {
            get { return selectedcountry; }
            set
            {
                selectedcountry = value; OnPropertyChanged();
            }
        }


        private void Create_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow Createwindow = new CreateWindow();
            Createwindow.ShowDialog();
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            string tb = tbperson.Text;
            string dbResult = db.UpdatePeople(SelectedPerson.PersonId,selectedPerson);
                PopulatePeople();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var listperson = viewperson.SelectedItem;
            persons person = (persons)listperson;

            string dbResult = db.DeletePeople(person.PersonId);
            if (dbResult == landenDB.ok)
            {
                PopulatePeople();
            }
            else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }

        private void DeleteCountry_Click(object sender, RoutedEventArgs e)
        {
            var listcountry = viewcountry.SelectedItem;
            countries country = (countries)listcountry;

            string dbResult = db.DeleteCountry(country.CountryId);
            if (dbResult == landenDB.ok)
            {
                PopulateCountry();
            }
            else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }

        private void UpdateCountry_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateCountry_Click(object sender, RoutedEventArgs e)
        {
            CreateWindow Createwindow = new CreateWindow();
            Createwindow.ShowDialog();
        }
        private void PopulatePeople()
        {
            Person.Clear();
            string dbResult = db.GetPeople(Person);
            if (dbResult != landenDB.ok)
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }

        private void PopulateCountry()
        {
            Country.Clear();
            string dbResult = db.GetCountry(Country);
            if (dbResult != landenDB.ok)
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            PopulatePeople();
            PopulateCountry();
            DataContext = this;
        }

        private void viewperson_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(selectedPerson != null)
            {
            string people1 = SelectedPerson.Name.ToString();
            tbperson.Text = people1;
            }

            else
            {
                return;
            }
        }
    }
}

#endregion