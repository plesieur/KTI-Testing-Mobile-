namespace KTI_Testing__Mobile_
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = "nahhh";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
