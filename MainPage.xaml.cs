namespace KTI_Testing__Mobile_
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = "bitch";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
