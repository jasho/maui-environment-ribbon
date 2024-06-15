using MauiEnvironmentRibbon.Extensions;
using MauiEnvironmentRibbon.NavigationPageSample.Pages;
using MauiEnvironmentRibbon.NavigationPageSample.Pages.Flyouts;

namespace MauiEnvironmentRibbon.NavigationPageSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var mainPage = new NavigationPage(new MainPage())
                .AddEnvironmentRibbon(EnvironmentRibbonType.Alpha);

            // Use this initialization to test out flyout page with hamburger menu
            //var mainPage = new MainFlyoutPage().AddEnvironmentRibbon(EnvironmentRibbonType.Alpha);

            MainPage = mainPage;
        }
    }
}
