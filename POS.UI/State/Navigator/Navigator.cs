using POS.UI.Commands;
using POS.UI.Models;
using POS.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POS.UI.State.Navigator
{
    public class Navigator : ObseverableObject,INavigator
    {
        private ViewModelBase _currentViewModelBase;
        public ViewModelBase CurrentViewModel { 
            get
            {
                return _currentViewModelBase;
            }

            set
            {
                _currentViewModelBase = value;
                OnPropertyChanged(nameof(CurrentViewModel));
            }
        }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
