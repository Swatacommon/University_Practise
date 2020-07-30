using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_architecture
{
    class Phone : INotifyPropertyChanged
    {
        private int id;
        private string first_name;
        private int phone_number;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        public string First_Name
        {
            get { return first_name; }
            set
            {
                first_name = value;
                OnPropertyChanged("First_Name");
            }
        }
        
        public int Phone_Number
        {
            get { return phone_number; }
            set
            {
                phone_number = value;
                OnPropertyChanged("Phone_Number");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
