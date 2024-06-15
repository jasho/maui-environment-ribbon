using MauiEnvironmentRibbon.NavigationPageSample.Pages;

namespace MauiEnvironmentRibbon.NavigationPageSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var navigationPage = new NavigationPage(new MainPage())
                .AddEnvironmentRibbon(EnvironmentRibbonType.Alpha);

            MainPage = navigationPage;
        }
    }
}
