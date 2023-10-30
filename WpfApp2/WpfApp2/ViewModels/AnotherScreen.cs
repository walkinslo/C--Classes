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
    class AnotherScreen : BaseViewModel
    {
        public AnotherScreen(IChangeViewModel viewModelChanger) : base(viewModelChanger)
        {
        }

        public ICommand GoToMainMenu
        {
            get { return new RelayCommand(PopToMainMenu); }
        }

        private void PopToMainMenu()
        {
            PopViewModel();
        }
    }
}
