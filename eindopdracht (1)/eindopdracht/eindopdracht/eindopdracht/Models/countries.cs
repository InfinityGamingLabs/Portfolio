using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace eindopdracht.Models
{
    public class countries: INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private int countryId; //2
        public int CountryId
        {
            get { return countryId; } //3
            set { countryId = value; OnPropertyChanged(); } //4
        }
        private string country = null!; //5
        public string Country
        {
            get { return country; }
            set { country = value; OnPropertyChanged(); }
        }
    }
}
