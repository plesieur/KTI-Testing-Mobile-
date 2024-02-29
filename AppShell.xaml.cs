using KTI_Testing__Mobile_.Resources.viewModels;

namespace MauiApp2
{
    public partial class AppShell : Shell
    {
        
        public AppShell()
        {
            InitializeComponent();
            this.BindingContext = new AppShellViewMode();
            Routing.RegisterRoute(nameof(ProfilePage), typeof(ProfilePage));
            Routing.RegisterRoute(nameof(HistoryPage), typeof(HistoryPage));
            Routing.RegisterRoute(nameof(CartPage), typeof(CartPage));
            Routing.RegisterRoute(nameof(SettingsPage), typeof(SettingsPage));
        }
    }
}
