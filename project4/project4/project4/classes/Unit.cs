using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project4.classes
{
  public  class Unit
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private int unit_id;  // die is var die ik in de functie gebruik
        public int Unit_id // die is functie 
        {
            get { return unit_id; } //hier mee haalt die de value van de pizza id 
            set { unit_id = value; OnPropertyChanged(); }
        }

        //


        private string name;
        public string Name
        {
            get { return name; } //
            set { name = value; OnPropertyChanged(); } //
        }

        private int prijs; //die ga ik halen van db 
        public int Prijs //en die ga ik gebruiken in de database classes

        {
            get { return prijs; }
            set { prijs = value; OnPropertyChanged(); }
        }
        private int aantal; //die ga ik halen van db 
        public int Aantal //en die ga ik gebruiken in de database classes

        {
            get { return aantal; }
            set { aantal = value; OnPropertyChanged(); }
        }

    }
}
