using AirMonitor.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace AirMonitor.ViewModels
{
    public class HomeViewModel
    {
        private INavigation _nav;
        public HomeViewModel(INavigation nav)
        {
            _nav = nav;
        }
        private ICommand _goToDetails;
        public ICommand GoToDetails => _goToDetails ?? (_goToDetails = new Command(OnGoToDetails));

        private void OnGoToDetails()
        {
            _nav.PushAsync(new DetailsPage());
        }

    }
}
