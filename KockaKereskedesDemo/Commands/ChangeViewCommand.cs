using KockaKereskedesDemo.Commands.Base;
using KockaKereskedesDemo.Stores;
using KockaKereskedesDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaKereskedesDemo.Commands
{
    public class ChangeViewCommand : BaseCommand
    {
        private readonly PresentedViewStore _presentedViewStore;

        public ChangeViewCommand(PresentedViewStore presentedViewStore)
        {
            _presentedViewStore = presentedViewStore;
        }

        public override void Execute(object parameter)
        {
            if (parameter.ToString() == "login")
            {
                _presentedViewStore.PresentedSideView = new MenuSideViewModel(_presentedViewStore);
            }
        }
    }
}
