namespace MauiEnvironmentRibbon.NavigationPageSample.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateToContentPageWithGridClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageWithGrid());
        }
    }
}
