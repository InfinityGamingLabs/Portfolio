using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace eindopdracht.Models
{
    public class persons: INotifyPropertyChanged
    {
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string? name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        #endregion

        private int personId; //2
        public int PersonId
        {
            get { return personId; } //3
            set { personId = value; OnPropertyChanged(); } //4
        }

        private string name = null!; //5
        public string Name
        {
            get { return name; }
            set { name = value; OnPropertyChanged(); }
        }
    }
}
