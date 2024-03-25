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

        public CartPage(Tool t)
        {
            InitializeComponent();

            var myStyle = new Style<Entry>(

            (Entry.HeightRequestProperty, 120),
            (Entry.MaximumWidthRequestProperty, 430),
            (Entry.ShadowProperty, 10),
            (Entry.TextColorProperty, Colors.Black),
            (Entry.BackgroundColorProperty, Colors.WhiteSmoke),
            (Entry.FontSizeProperty, 28)
            );

        private void GoCancle_Clicked(object sender, EventArgs e)
        {

        }
        private void GoToSettingPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(SettingsPage));
        }
    }
}