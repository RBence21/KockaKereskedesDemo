using KockaKereskedesDemo.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KockaKereskedesDemo.Stores
{
    public class PresentedViewStore : BaseViewModel
    {
        private BaseViewModel _presentedSideView;
        private BaseViewModel _presentedView;
		
        public BaseViewModel PresentedSideView
		{
			get { return _presentedSideView; }
			set 
			{ 
				_presentedSideView = value;               
                OnPropertyChanged(nameof(PresentedSideView));
            }
		}

        public BaseViewModel PresentedView
        {
            get { return _presentedView; }
            set
            {
                _presentedView = value;
                OnPropertyChanged(nameof(PresentedView));
            }
        }



    }
}
