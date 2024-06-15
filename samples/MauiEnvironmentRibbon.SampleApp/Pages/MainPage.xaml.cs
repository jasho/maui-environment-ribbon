namespace MauiEnvironmentRibbon.SampleApp.Pages
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(ContentPageWithGrid.Route);
        }
    }
}
