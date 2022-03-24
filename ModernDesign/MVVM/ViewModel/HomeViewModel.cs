using ModernDesign.Core;
using ModernDesign.MVVM.Model;
using ModernDesign.MVVM.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModernDesign.MVVM.ViewModel
{
    public class HomeViewModel : Notifiable,IViewModel
    {
     
        public MainViewModel MainViewModel { get; }
        public event PropertyChangedEventHandler PropertyChanged;

        private string materialName = "test";
        public string MaterialName
        {
            get
            {
                return materialName;
            }
            set
            {
                materialName = value;
                OnPropertyChanged(nameof(MaterialName));
                OnPropertyChanged(nameof(MainViewModel));
            }
        }
        public HomeView homeView { get; set; }
        public HomeViewModel(HomeView control)
        {
            homeView = control;
        }

        public HomeViewModel()
        {
           
        }

        public HomeViewModel(MainViewModel mainViewModel)
        {
            MainViewModel = mainViewModel;
            CurrentMaterialModel = MainViewModel.CurrentMaterialModel;
            //this.CurrentMaterialModel.PropertyChanged += HomeViewModel_PropertyChanged;
        }

        private void HomeViewModel_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            MaterialName = sender.ToString();
            OnPropertyChanged(nameof(MaterialName));

        }

        private MaterialModel _currentMaterialModel;
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

    }
}
