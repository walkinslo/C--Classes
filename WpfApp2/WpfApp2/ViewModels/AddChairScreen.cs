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
    class AddChairScreen : BaseViewModel
    {
        public AddChairScreen(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }

        public ICommand GoToStoreScreen
        {
            get { return new RelayCommand(PopToStoreScreen); }
        }
        
        private void PopToStoreScreen()
        {
            PopViewModel();
        }
    } 
}