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
    /// Interaction logic for Medewerker.xaml
    /// </summary>
    public partial class Medewerker : Window, INotifyPropertyChanged
    {
        public Medewerker()
        {
            System.Drawing.Color Color = System.Drawing.Color.Black;
            InitializeComponent();
            DataContext = this;
            PopulateMedewerkers();
        }
        private void PopulateMedewerkers()
        {
            Medewerkers.Clear();
            string dbResult = db.GetMedewerkers(Medewerkers);
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


        private ObservableCollection<Medewerkers> medewerkers = new();
        public ObservableCollection<Medewerkers> Medewerkers
        {
            get { return medewerkers; }
            set { medewerkers = value; OnPropertyChanged(); }
        }
        private Medewerkers SelectedMedwerkers;
        public Medewerkers SelectedMedwerker
        {
            get
            { return SelectedMedwerkers; }
            set
            {
                SelectedMedwerkers = value;
                OnPropertyChanged();
            }
        }
        private Medewerkers nieuwmedewerkers = new();
        public Medewerkers NieuwMedewerkers
        {
            get { return nieuwmedewerkers; }
            set
            {
                nieuwmedewerkers = value;
                OnPropertyChanged();
            }
        }



        private void CreateName_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(NieuwMedewerkers.Name) && (NieuwMedewerkers.Telefoonnummer == null))
            {
                MessageBox.Show("Vul naam van de Medwerker en prijs in");
                return;
            }
            if (tbName.Text == "")
            {
                MessageBox.Show("je moet alles invullen");
            }
            string dbResult = db.CreateMedewerkers(NieuwMedewerkers);
            if (dbResult == Pizzadb.ok)
            {
                //Medewerkers.Add(NieuwMedewerkers);    // Hiermee heb je geen id
                PopulateMedewerkers();                  // Hiermee volledige refresh, inclusief id
                MessageBox.Show("Nieuwe Medewerker toegevoegd");
                NieuwMedewerkers = new();
            }
            /*else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }*/
        }

        private void UpdateName_Click(object sender, RoutedEventArgs e)
        {

            if (SelectedMedwerker == null)
            {
                MessageBox.Show("Selecteer de naam van de persoon die u wil wijzigen.");
                return;
            }

            if (string.IsNullOrEmpty(SelectedMedwerker.Name))
            {
                MessageBox.Show("Vul de naam van de persoon in.");
                return;
            }

            string dbResult = db.UpdateMedewerkers(SelectedMedwerker.Medewerkers_id, SelectedMedwerker);
            if (dbResult == Pizzadb.ok)
            {
                PopulateMedewerkers();
            }
            else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }
        }

        private void DeleteName_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedMedwerkers != null)
            {
                Medewerkers medewerkers = SelectedMedwerkers;
                string dbResult = db.DeleteMedewerkers(medewerkers.Medewerkers_id);

                if (dbResult == Pizzadb.ok)
                {
                    PopulateMedewerkers();
                }
                else
                {
                    MessageBox.Show(dbResult + serviceDeskBericht);
                }
            }
        }

        private void tbWoonplaats_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "^[a-zA-Z ]*$"))
            {
                e.Handled = true;
            }
        }

        private void tbTelefoonnummer_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int value;
            if (!int.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }

        private void tbName_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "^[a-zA-Z ]*$"))
            {
                e.Handled = true;
            }
        }

        private void tbTelefoonnummer_PreviewTextInput_1(object sender, TextCompositionEventArgs e)
        {
            int value;
            if (!int.TryParse(e.Text, out value))
            {
                e.Handled = true;
            }
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "^[a-zA-Z ]*$"))
            {
                e.Handled = true;
            }
        }

        private void tbwoon_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Regex.IsMatch(e.Text, "^[a-zA-Z ]*$"))
            {
                e.Handled = true;
            }
        }

        private void tbtele_PreviewTextInput(object sender, TextCompositionEventArgs e)
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
