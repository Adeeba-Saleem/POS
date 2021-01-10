using POS.UI.State.Navigator;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POS.UI.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        private INavigator _navigator;
        public event EventHandler CanExecuteChanged;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            _navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
          return true;
        }

        public void Execute(object parameter)
        {
           if (parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;

                switch (viewType)
                {
                    case ViewType.Home:
                        _navigator.CurrentViewModel = new ViewModels.HomeViewModel();
                        break;
                    case ViewType.About:
                        break;
                    case ViewType.POS:
                        _navigator.CurrentViewModel = new ViewModels.POSViewModel();
                        break;
                    case ViewType.Contact:
                        break;
                    case ViewType.Exit:
                        break;
                }
            }
        }
    }
}
