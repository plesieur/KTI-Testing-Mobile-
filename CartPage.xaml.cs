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

        private void GoCancle_Clicked(object sender, EventArgs e)
        {
            OutputLabel.Text = "are you sure?";
        }
        private void GoToSettingPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(SettingsPage));
        }
        private void addItem(Tool tool)
        {
            toolList.Add(tool);

            var myStyle = new Style<Entry>(

            (Entry.HeightRequestProperty, 120),
            (Entry.MaximumWidthRequestProperty, 430),
            (Entry.ShadowProperty, 10),
            (Entry.TextColorProperty, Colors.Black),
            (Entry.BackgroundColorProperty, Colors.WhiteSmoke),
            (Entry.FontSizeProperty, 28)
            );

            Button button = new Button { Text = tool.Name, Style = myStyle };
            button.Clicked += (s, e) => { Navigation.PushAsync(new ToolsPage(tool)); };
            button.Margin = new Thickness(15, 15, 15, 0);

        }
    }
}