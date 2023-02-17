using KockaKereskedesDemo.Commands;
using KockaKereskedesDemo.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace KockaKereskedesDemo.ViewModels
{
    public class ActiveAdsSideViewModel : BaseViewModel
    {
        private MainWindowViewModel _mainWindowViewModel;

        public ICommand BackToDashboardCommand { get; set; }

        public ActiveAdsSideViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            BackToDashboardCommand = new ChangeViewCommand(_mainWindowViewModel);
        }
    }
}
