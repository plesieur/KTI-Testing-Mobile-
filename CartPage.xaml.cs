using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MauiApp2
{
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
        }
        private void GoToProfilePage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ProfilePage));
        }

        private void GoToHistoryPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(HistoryPage));
        }

        private void GoSubmit_Clicked(object sender, EventArgs e)
        {
            OutputLabel.Text = "Are you sure you want to hit submit?";
        }

        private void GoCancle_Clicked(object sender, EventArgs e)
        {

        }
        private void GoToSettingPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(SettingsPage));
        }
    }
}