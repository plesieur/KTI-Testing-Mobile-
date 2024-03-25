using KTI_Testing__Mobile_.Models;

namespace KTI_Testing__Mobile_;

public partial class ToolsPage : ContentPage
{
	public ToolsPage()
	{
		InitializeComponent();
	}

	public ToolsPage(Tool t)
	{
		InitializeComponent();
		toolName.Text = "This page is for a " + t.Name + "!"; 
	}
}