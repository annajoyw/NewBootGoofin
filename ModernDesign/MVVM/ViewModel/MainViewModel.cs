using ModernDesign.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }

        public HomeViewModel HomeVM{ get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        private IViewModel _currentViewModel;

        public IViewModel CurrentViewModel
        {
            get { return _currentViewModel; }
            set
            {
                _currentViewModel = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            DiscoveryVM = new DiscoveryViewModel();
            CurrentViewModel = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentViewModel = HomeVM;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentViewModel = DiscoveryVM;
            });
        }
    }
}
