using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Markup;
using KTI_Testing__Mobile_.Models;


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

            Button button = new Button { Text = t.Name, Style = myStyle };
            button.Margin = new Thickness(15, 15, 15, 0);

            Cart.Children.Add(button);
        }
    }
}