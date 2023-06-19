using eindopdracht.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    /// Interaction logic for CreateWindow.xaml
    /// </summary>
    public partial class CreateWindow : Window, INotifyPropertyChanged
    {
        public CreateWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

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


        private persons newPerson = new();
        public persons NewPerson
        {
            get { return newPerson; }
            set
            {
                newPerson = value;
                OnPropertyChanged();

            }
        }



        private void Create_Click(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrEmpty(NewPerson.Name))
            {
                MessageBox.Show("Vul naam van de persoon in");
                return;
            }
            else
            {
                MessageBox.Show("New Person is added");
            }


            string dbResult = db.CreatePeople(NewPerson);
            if (dbResult == landenDB.ok)
            {
                NewPerson = new();
            }
            else
            {
                MessageBox.Show(dbResult + serviceDeskBericht);
            }


        }
    }
}
