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
             


            AddBtn.Text = " +1 ";
            SubBtn.Text = " -1 ";


            SemanticScreenReader.Announce(AddBtn.Text);
            SemanticScreenReader.Announce(SubBtn.Text);
        }
    }

}
