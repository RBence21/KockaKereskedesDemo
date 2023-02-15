using KockaKereskedesDemo.Stores;
using KockaKereskedesDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KockaKereskedesDemo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            PresentedViewStore presentedViewStore = new PresentedViewStore();
            presentedViewStore.PresentedView = new LoginViewModel(presentedViewStore);
            presentedViewStore.PresentedSideView = new LoginSideViewModel(presentedViewStore);

            MainWindow = new MainWindow()
            {
                DataContext = new MainWindowViewModel(presentedViewStore)
            };

            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
