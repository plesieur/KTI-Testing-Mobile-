using CommunityToolkit.Maui.Markup;
using KTI_Testing__Mobile_;
using KTI_Testing__Mobile_.Models;
using MauiApp3.Models;
using System.Collections.ObjectModel;
/* Unmerged change from project 'KTI Testing (Mobile) (net8.0-android)'
Before:
using System.Collections;
using CommunityToolkit.Maui.Markup;
After:
using System.Collections;
*/

/* Unmerged change from project 'KTI Testing (Mobile) (net8.0-ios)'
Before:
using System.Collections;
using CommunityToolkit.Maui.Markup;
After:
using System.Collections;
*/

/* Unmerged change from project 'KTI Testing (Mobile) (net8.0-maccatalyst)'
Before:
using System.Collections;
using CommunityToolkit.Maui.Markup;
After:
using System.Collections;
*/


namespace MauiApp3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        List<Tool> toolList = new List<Tool>();

        public MainPage()
        {
            InitializeComponent();

            List<Tools> tools = ToolRepository.GetTools();

            toolList.ItemsSource = tools;

            Tool cloneTool = new Tool(1, "Hammer", "a bangy boi", "hehe", 50);

            for (int i = 0; i < 20; i++)
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
            listBox.Children.Add(button);
        }

        private async void toolList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
{
    if (toolList.SelectedItem != null)
    {
        await Shell.Current.GoToAsync($"{nameof(CartPage)}?Id={((Tools)toolList.SelectedItem).toolId}");
    }


}

private void toolList_ItemTapped(object sender, ItemTappedEventArgs e)
{
    toolList.SelectedItem = null;
}

private void loadTools()
{
    var tools = new ObservableCollection<Tools>(ToolRepository.GetTools());
    toolList.ItemsSource = tools;
}
private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
{
    var tools = new ObservableCollection<Tools>(ToolRepository.SearchTools(((SearchBar)sender).Text));
    toolList.ItemsSource = tools;
}

    }

}
