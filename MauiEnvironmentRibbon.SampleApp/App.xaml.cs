using MauiEnvironmentRibbon.SampleApp.Controls;

namespace MauiEnvironmentRibbon.SampleApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var appShell = new AppShell();
            appShell.Navigated += AppShell_Navigated;

            MainPage = appShell;
        }

        private void AppShell_Navigated(object? sender, ShellNavigatedEventArgs e)
        {
            if (sender is Shell shell)
            {
                AddEnvironmentRibbonToShell(shell);
            }
        }

        private void AddEnvironmentRibbonToShell(Shell shell)
        {
            if (shell.CurrentPage is ContentPage contentPage)
            {
                if (contentPage.Content is Grid rootGrid)
                {
                    rootGrid.Children.Add(new EnvironmentRibbon());
                }
                else
                {
                    var newRootGrid = new Grid();

                    newRootGrid.Children.Add(contentPage.Content);
                    newRootGrid.Children.Add(new EnvironmentRibbon());

                    contentPage.Content = newRootGrid;
                }
            }
        }
    }
}
