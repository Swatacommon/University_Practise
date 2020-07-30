using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MVVM_architecture
{
    class ViewModel : INotifyPropertyChanged
    {
        private Phone selectedPhone;

        public ObservableCollection<Phone> Phones { get; set; }

        public Phone SelectedPhone
        {
            get { return selectedPhone; }
            set
            {
                selectedPhone = value;
                OnPropertyChanged("SelectedPhone");
            }
        }

        public ViewModel()
        {
            Phones = new ObservableCollection<Phone>
            {
                new Phone { Id=1, First_Name="Nikita", Phone_Number=6401337},
                new Phone { Id=2, First_Name="Artemiy", Phone_Number=2281337},
                new Phone { Id=3, First_Name="Ilya", Phone_Number=3221337}
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
