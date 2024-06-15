namespace MauiEnvironmentRibbon.SampleApp
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            var appShell = new AppShell()
                .AddEnvironmentRibbon(EnvironmentRibbonType.Beta);

            MainPage = appShell;
        }
    }
}
