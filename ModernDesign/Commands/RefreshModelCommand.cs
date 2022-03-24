using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ModernDesign.Core;
using ModernDesign.MVVM.Model;
using ModernDesign.MVVM.ViewModel;

namespace ModernDesign.Commands
{
    public class RefreshModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private HomeViewModel homeVM;
        private MainViewModel main;

        public RefreshModelCommand(object mainVM, object name)
        {
            homeVM = (HomeViewModel)name;
            main = (MainViewModel)mainVM;
        }

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {

        }
    }
}
