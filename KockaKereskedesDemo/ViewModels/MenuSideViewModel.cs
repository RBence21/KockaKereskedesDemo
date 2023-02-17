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
    public class MenuSideViewModel : BaseViewModel
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public ICommand OpenActiveAdsCommand { get; set; }

        public MenuSideViewModel(MainWindowViewModel mainWindowViewModel)
        {
            _mainWindowViewModel = mainWindowViewModel;
            OpenActiveAdsCommand = new ChangeViewCommand(_mainWindowViewModel);
        }
    }
}
