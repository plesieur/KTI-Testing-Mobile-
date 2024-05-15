using KTI_Testing__Mobile_.Resources.viewModels;

namespace MauiApp2
{
    public partial class CartPage : ContentPage
    {
        public CartPage()
        {
            InitializeComponent();
            this.BindingContext = new cartModel();
        }
    }
}