using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MapAndBottmSheetExample {
    public class MainViewModel : BaseViewModel {
        CityItem selectedCity;
        ObservableCollection<CityItem> cities;
        public CityItem SelectedCity {
            get {
                return selectedCity;
            }
            set {
                selectedCity = value;
                OnPropertyChanged();
            }
        }
        public ObservableCollection<CityItem> Cities {
            get {
                return cities;
            }
            set {
                cities = value;
                OnPropertyChanged();
            }
        }
        public MainViewModel() {
            Cities = new ObservableCollection<CityItem>(){
                new CityItem() {
                    Name = "Athens",
                    Location = new Location(37.9838, 23.7275),
                    Address = "Greece"
                },
                new CityItem() {
                    Name = "Paris",
                    Location = new Location(48.8566, 2.3522),
                    Address = "France",
                }
            };
        }
    }

    public class CityItem {
        public string Name {
            get;
            set;
        }
        public string Address {
            get;
            set;
        }
        public Location Location {
            get;
            set;
        }
    }

    public class BaseViewModel : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
