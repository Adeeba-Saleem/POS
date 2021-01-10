using POS.UI.Commands;
using POS.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POS.UI.State.Navigator
{
    public class Navigator : INavigator
    {
        public ViewModelBase CurrentViewModel { get ; set ; }

        public ICommand UpdateCurrentViewModelCommand => new UpdateCurrentViewModelCommand(this);
    }
}
