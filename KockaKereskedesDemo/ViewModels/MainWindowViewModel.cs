using KockaKereskedesDemo.Stores;
using KockaKereskedesDemo.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaKereskedesDemo.ViewModels
{
    public class MainWindowViewModel : BaseViewModel
    {
        private readonly PresentedViewStore _presentedViewStore;

        public BaseViewModel PresentedSideView => _presentedViewStore.PresentedSideView;
        public BaseViewModel PresentedView => _presentedViewStore.PresentedView;

        public MainWindowViewModel(PresentedViewStore presentedViewStore)
        {
            _presentedViewStore = presentedViewStore;
            _presentedViewStore.OnPropertyChanged(nameof(PresentedView));
            _presentedViewStore.OnPropertyChanged(nameof(PresentedSideView));
        }
        private void OnPresentedViewChanged()
        {
            OnPropertyChanged(nameof(PresentedSideView));
        }
    }
}
