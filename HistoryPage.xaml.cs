using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MauiApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HistoryPage : ContentPage
    {
        public HistoryPage()
        {
            InitializeComponent();
        }
        private void latestSubmitions_Clicked(object sender, EventArgs e)
        {
           
        }
        private void GoToProfilePage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ProfilePage));
        }

        private void GoToCartPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(CartPage));
        }

        private void GoToSettingPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(SettingsPage));
        }
    }
}