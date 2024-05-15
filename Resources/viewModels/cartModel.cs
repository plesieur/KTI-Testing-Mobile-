using Camera.MAUI;
using CommunityToolkit.Maui.Markup;
using KTI_Testing__Mobile_.Models;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace KTI_Testing__Mobile_.Resources.viewModels
{
    public partial class cartModel : BaseViewModel
    {

        public cartModel()
        {
            cartList = new List<string>();
        }

        [ObservableProperty]
        List<string> cartList = new List<string>();



        [ObservableProperty]
        Tool? scanned;

        [ObservableProperty]
         string name = "pooh";

        Style myStyle = new Style<Button>(

            (Button.HeightRequestProperty, 120),
            (Button.MaximumWidthRequestProperty, 430),
            (Button.TextColorProperty, Colors.Black),
            (Button.BackgroundColorProperty, Colors.WhiteSmoke),
            (Button.FontSizeProperty, 28)  
            );

        
        [ICommand]
        void AddToCart()
        {
            cartList.Add("banana");
        }



    }
}
