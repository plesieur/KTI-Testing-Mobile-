namespace KTI_Testing__Mobile_
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
            //MainPage = new AppShell();
        }
    }
}
