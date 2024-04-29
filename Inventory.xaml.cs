namespace MauiApp2;

using CommunityToolkit.Maui.Markup;
using KTI_Testing__Mobile_;
using KTI_Testing__Mobile_.Models;
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


public partial class Inventory : ContentPage
{
    public Inventory()
    {
        InitializeComponent();

        for (int i = 0; i < 20; i++)
        {
            addItem(new Tool(50, "kitty", "a cat", "icons", 500));
        }
    }

    List<Tool> toolList = new List<Tool>();

    private void addItem(Tool tool)
    {
        toolList.Add(tool);

        var myStyle = new Style<Entry>(

        (Entry.HeightRequestProperty, 120),
        (Entry.WidthRequestProperty, 120),
        (Entry.ShadowProperty, 10),
        (Entry.TextColorProperty, Colors.Black),
        (Entry.BackgroundColorProperty, Colors.WhiteSmoke),
        (Entry.FontSizeProperty, 28)
        );

        Button button = new Button { Text = tool.Name + "\n#" + tool.Amount, Style = myStyle };
        button.Clicked += (s, e) => { Navigation.PushAsync(new ToolsPage(tool)); };
        button.Margin = new Thickness(3, 3, 3, 3);
        Bag.Children.Add(button);
    }
}