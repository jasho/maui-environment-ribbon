using MauiEnvironmentRibbon.NavigationPageSample.Pages.Flyouts;
using MauiEnvironmentRibbon.NavigationPageSample.Pages.Tabs;

namespace MauiEnvironmentRibbon.NavigationPageSample.Pages
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NavigateToContentPageWithGridClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageWithGrid());
        }

        private void NavigateToTabbedPageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainTabbedPage());
        }

        private void NavigateToFlyoutPageClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainFlyoutPage());
        }
    }
}
