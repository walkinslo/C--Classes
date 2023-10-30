using WpfApp2.Helpers;
using WpfApp2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp2.ViewModels
{
    class HomeScreenViewModel : BaseViewModel
    {

        public HomeScreenViewModel(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }

        public ICommand MoveToAnotherScreen
        {
            get { return new RelayCommand(LoadAnotherScreen); }
        }

        public ICommand MoveToStoreScreen
        {
            get { return new RelayCommand(LoadStoreScreen); }
        }

        public ICommand MoveToAddChairScreen
        {
            get { return new RelayCommand(LoadAddChairScreen); }
        }
        
        private void LoadAnotherScreen()
        {
            PushViewModel(new AnotherScreen(ViewModelChanger));
        }

        private void LoadStoreScreen()
        {
            PushViewModel(new StoreScreen(ViewModelChanger));
        }
        
        private void LoadAddChairScreen()
        {
            PushViewModel(new AddChairScreen(ViewModelChanger));
        }
    }
}
