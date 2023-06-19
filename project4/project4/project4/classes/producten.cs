using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project4.classes
{
    class Producten
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private int producten_id; //2
        public int Producten_Id
        {
            get { return producten_id; } //3
            set { Producten_Id = value; OnPropertyChanged(); } //4
        }



        private int name; //2
        public int Name
        {
            get { return name; } //3
            set { Name = value; OnPropertyChanged(); } //4
        }

        private int prijs; //die ga ik halen van db 
        public int Prijs //en die ga ik gebruiken in de database classes
        {
            get { return prijs; } //3
            set { Prijs = value; OnPropertyChanged(); } //4
        }

        private int Aantal; //die ga ik halen van db 
        public int aantal //en die ga ik gebruiken in de database classes
        {
            get { return Aantal; } //3
            set { aantal = value; OnPropertyChanged(); } //4
        }

    }

}


