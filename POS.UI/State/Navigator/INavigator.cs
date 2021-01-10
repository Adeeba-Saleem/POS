using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace POS.UI.State.Navigator
{
    public enum ViewType
    {
        Home,
        About,
        POS,
        Contact,
        Exit
    }
    public interface INavigator
    {
        ViewModels.ViewModelBase CurrentViewModel { get; set; }

        ICommand UpdateCurrentViewModelCommand { get; }
    }
}
