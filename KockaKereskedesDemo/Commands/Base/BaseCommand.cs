using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KockaKereskedesDemo.Commands.Base
{
    public class BaseCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        public virtual bool CanExecute(object parameter) => true;

        public void Execute(object parameter)
        {

        }
    }
}
