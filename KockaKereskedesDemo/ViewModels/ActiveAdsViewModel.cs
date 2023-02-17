using KockaKereskedesDemo.Models;
using KockaKereskedesDemo.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KockaKereskedesDemo.ViewModels
{
    public class ActiveAdsViewModel : BaseViewModel
    {
        private readonly ObservableCollection<Car> _activeAds;

        public IEnumerable<Car> ActiveAds => _activeAds;

        public ActiveAdsViewModel(MainWindowViewModel mainWindowViewModel)
        {
            // Ez majd ugye backendről jön, csak most feltöltöm pár elemmel, hogy azért legyen ott valami
            _activeAds = new ObservableCollection<Car>()
            {

            };
            HttpClient httpClient = new HttpClient();
            
        }
    }
}
