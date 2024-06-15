using MauiEnvironmentRibbon.SampleApp.Controls;

namespace MauiEnvironmentRibbon.SampleApp;

public static class ShellExtensions
{
    public static Shell AddEnvironmentRibbon(this Shell shell)
    {
        shell.Navigated += AppShell_Navigated;
        return shell;
    }

    private static void AppShell_Navigated(object? sender, ShellNavigatedEventArgs e)
    {
        if (sender is Shell { CurrentPage: not null } shell)
        {
            AddEnvironmentRibbonToPage(shell.CurrentPage);
        }
    }

    private static void AddEnvironmentRibbonToPage(Page page)
    {
        if (page is ContentPage contentPage)
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