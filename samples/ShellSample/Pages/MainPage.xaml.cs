namespace MauiEnvironmentRibbon.ShellSample.Pages
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GoToContentPageWithGridClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(ContentPageWithGrid.Route);
        }
    }
}
