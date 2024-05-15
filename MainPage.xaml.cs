using KTI_Testing__Mobile_;
using KTI_Testing__Mobile_.Models;
using System.Collections;
using CommunityToolkit.Maui.Markup;

namespace MauiApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        List<Tool> toolList = new List<Tool>();
        
    public MainPage()
        {
            InitializeComponent();

            Tool cloneTool = new Tool(1,"Hammer","a bangy boi",50);

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

        private void addItem(Tool tool)
        {
            toolList.Add(tool);

            var myStyle = new Style<Button>(

            (Button.HeightRequestProperty, 120),
            (Button.MaximumWidthRequestProperty, 430),
            (Button.TextColorProperty, Colors.Black),
            (Button.BackgroundColorProperty, Colors.WhiteSmoke),
            (Button.FontSizeProperty, 28)
            );

            Button button = new Button {Text = tool.Name, Style = myStyle};
            button.Margin = new Thickness(15, 15, 15, 0);
            listBox.Children.Add(button);
        }

    }

}
