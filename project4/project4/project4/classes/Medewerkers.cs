using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project4.classes
{
  public  class Medewerkers
    {

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion
        private int medewerkers_id;  // die is var die ik in de functie gebruik
        public int Medewerkers_id // die is functie 
        {
            get { return medewerkers_id; } //hier mee haalt die de value van de pizza id 
            set { medewerkers_id = value; OnPropertyChanged(); }
        }
        //
        private string name;
        public string Name
        {
            get { return name; } //
            set { name = value; OnPropertyChanged(); } //
        }

        private string woonplaats; //die ga ik halen van db 
        public string Woonplaats //en die ga ik gebruiken in de database classes

        {
            get { return woonplaats; }
            set { woonplaats = value; OnPropertyChanged(); }
        }
        private int telefoonnummer; //die ga ik halen van db 
        public int Telefoonnummer //en die ga ik gebruiken in de database classes

        {
            get { return telefoonnummer; }
            set { telefoonnummer = value; OnPropertyChanged(); }
        }

    }
}
