using CommunityToolkit.Maui.Markup;
using KTI_Testing__Mobile_;
using KTI_Testing__Mobile_.Models;
using System.Collections;


namespace MauiApp2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        List<Tool> toolList = new List<Tool>();

        public CartPage()
        {
            InitializeComponent();

            Tool clone2Tool = new Tool(1, "Hammer", "a bangy boi", "hehe", 50);

            for (int i = 0; i < 20; i++)
            {
                AddItem(clone2Tool);
            }
        }

        private void GoCancle_Clicked(object sender, EventArgs e)
        {
            OutputLabel.Text = "are you sure?";
        }
        private void GoToSettingPage(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync(nameof(SettingsPage));
        }
        private void AddItem(Tool tool)
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