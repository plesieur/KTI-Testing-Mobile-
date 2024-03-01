<<<<<<< HEAD
﻿using KTI_Testing__Mobile_;

namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(HistoryPage), typeof(HistoryPage));
            Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(ToolsPage), typeof(ToolsPage));
        }
    }
}
=======
﻿using KTI_Testing__Mobile_.Pages;

namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(HistoryPage), typeof(HistoryPage));
            Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
            Routing.RegisterRoute(nameof(ToolsPage), typeof(ToolsPage));
        }
    }
}
>>>>>>> 26e8b99429aadd2b322a4947d3ca7b0818675f0d
