using KockaKereskedesDemo.Commands.Base;
using KockaKereskedesDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaKereskedesDemo.Commands
{
    public class ChangeViewCommand : BaseCommand
    {
        private readonly MainWindowViewModel _mainWindowViewModel;

        public ChangeViewCommand(MainWindowViewModel presentedViewStore)
        {
            _mainWindowViewModel = presentedViewStore;
        }

        public override void Execute(object parameter)
        {
            switch (parameter.ToString())
            {
                case "dashboard":
                    _mainWindowViewModel.PresentedSideView = new MenuSideViewModel(_mainWindowViewModel);
                    _mainWindowViewModel.PresentedView = new EmptyDashboardViewModel(_mainWindowViewModel);
                    break;
                case "advertisements":
                    _mainWindowViewModel.PresentedSideView = new ActiveAdsSideViewModel(_mainWindowViewModel);
                    _mainWindowViewModel.PresentedView = new ActiveAdsViewModel(_mainWindowViewModel);
                    break;
                default:
                    break;
            }

            
        }
    }
}
