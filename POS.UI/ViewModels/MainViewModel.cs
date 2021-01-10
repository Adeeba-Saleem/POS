using POS.UI.State.Navigator;
using System;
using System.Collections.Generic;
using System.Text;

namespace POS.UI.ViewModels
{
   public class MainViewModel : ViewModelBase
    {
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
