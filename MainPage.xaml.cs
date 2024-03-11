using KTI_Testing__Mobile_;
using KTI_Testing__Mobile_.Models;
using System.Collections;

namespace MauiApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        List<Tool> toolList = new List<Tool>();

        Style MyStyle;
        public MainPage()
        {
            InitializeComponent();

            Tool cloneTool = new Tool(1,"Hammer","a bangy boi","hehe",50);

            for(int i = 0; i < 20; i++)
            {
                addItem(cloneTool);
            }
        }
        private void GoToProfilePage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(ProfilePage));
        }

        private void GoToHistoryPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(HistoryPage));
        }

        private void GoToCartPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(CartPage));
        }

        private void GoToSettingPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(SettingsPage));
        }

        private async void TakeMeAway(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToolsPage());
        }

        private void addItem(Tool tool)
        {
            toolList.Add(tool);

            //var button = new Button { Text = tool.Name , StyleClass="items"};
            //listBox.Children.Add(button);
        }

    }

}
