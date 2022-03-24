using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ModernDesign.Commands
{
    public class CloseCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        MainWindow Window;

        public CloseCommand(MainWindow window)
        {
            Window = window;
        }
        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {
            Window.Close();
        }
    }
}
