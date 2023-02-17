using KockaKereskedesDemo.Commands;
using KockaKereskedesDemo.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KockaKereskedesDemo.ViewModels
{
    public class LoginSideViewModel : BaseViewModel
    {
        private readonly MainWindowViewModel _mainWindowViewModel;
        
        public ICommand LoginCommand { get; set; }

        public LoginSideViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            LoginCommand = new ChangeViewCommand(_mainWindowViewModel);
        }
    }
}
