using KockaKereskedesDemo.Commands;
using KockaKereskedesDemo.Stores;
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
        private readonly PresentedViewStore _presentedViewStore;
        
        public ICommand LoginCommand { get; }

        public LoginSideViewModel(PresentedViewStore presentedViewStore)
        {
            _presentedViewStore = presentedViewStore;
            LoginCommand = new ChangeViewCommand(_presentedViewStore);
        }
    }
}
