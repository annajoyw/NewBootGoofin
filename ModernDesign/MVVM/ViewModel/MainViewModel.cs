using ModernDesign.Core;
using ModernDesign.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
   public class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand HomeViewCommand1 { get; set; }
        public RelayCommand HomeViewCommand2 { get; set; }
        public RelayCommand DiscoveryViewCommand { get; set; }
        public RelayCommand RegisterViewCommand { get; set; }

        public HomeViewModel HomeVM{ get; set; }
        public HomeViewModel HomeVM1 { get; set; }
        public HomeViewModel HomeVM2 { get; set; }
        public DiscoveryViewModel DiscoveryVM { get; set; }
        public RegisterViewModel RegisterVM { get; set; }
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

        private MaterialModel _currentMaterialModel = new MaterialModel { MaterialName = "plswork" };
        public MaterialModel CurrentMaterialModel
        {
            get { return _currentMaterialModel; }
            set
            {
                if (_currentMaterialModel == value)
                    return;

                _currentMaterialModel = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(MainViewModel));
            }
        }
        public MainViewModel()
        {
            HomeVM = new HomeViewModel();
            HomeVM1 = new HomeViewModel(this);
            HomeVM2 = new HomeViewModel(this);
            DiscoveryVM = new DiscoveryViewModel();
            RegisterVM = new RegisterViewModel();
            CurrentViewModel = HomeVM;

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentViewModel = HomeVM;
            });

            HomeViewCommand1 = new RelayCommand(o =>
            {
                CurrentViewModel = HomeVM1;
            });

            HomeViewCommand2 = new RelayCommand(o =>
            {
                CurrentViewModel = HomeVM2;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentViewModel = DiscoveryVM;
            });

            RegisterViewCommand = new RelayCommand(o =>
            {
                CurrentViewModel = RegisterVM;
            });
        }
        public MainViewModel(MainWindow window)
        {
            HomeVM = new HomeViewModel();
            HomeVM1 = new HomeViewModel(this);
            HomeVM2 = new HomeViewModel(this);
            DiscoveryVM = new DiscoveryViewModel();
            RegisterVM = new RegisterViewModel();
            CurrentViewModel = HomeVM;

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentViewModel = HomeVM;
            });

            HomeViewCommand1 = new RelayCommand(o =>
            {
                CurrentViewModel = HomeVM1;
            });

            HomeViewCommand2 = new RelayCommand(o =>
            {
                CurrentViewModel = HomeVM2;
            });

            DiscoveryViewCommand = new RelayCommand(o =>
            {
                CurrentViewModel = DiscoveryVM;
            });

            RegisterViewCommand = new RelayCommand(o =>
            {
                CurrentViewModel = RegisterVM;
            });
        }
    }
}
