using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace project4.classes
{
    class Pizzaproducten
    {
         
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private int productenpizza_id; 
        public int Productenpizza_Id
        {
            get { return productenpizza_id; }
            set { Productenpizza_Id = value; OnPropertyChanged(); } 
        }

        private int pizza_id; 
        public int Pizza_id
        {
            get { return pizza_id; } 
            set { Pizza_id = value; OnPropertyChanged(); } 
        }
        private int product_id; 
        public int Product_id
        {
            get { return product_id; }
            set { Product_id = value; OnPropertyChanged(); } 
        }





    }
}

