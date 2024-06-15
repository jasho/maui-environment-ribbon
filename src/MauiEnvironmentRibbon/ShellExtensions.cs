using MauiEnvironmentRibbon.Controls;

namespace MauiEnvironmentRibbon;

public static class ShellExtensions
{
    private static EnvironmentRibbonConfiguration? configuration;

    public static Shell AddEnvironmentRibbon(this Shell shell, EnvironmentRibbonType environmentRibbonType)
    {
        configuration = GetConfiguration(environmentRibbonType);

        shell.Navigated += AppShell_Navigated;
        return shell;
    }

    private static EnvironmentRibbonConfiguration GetConfiguration(EnvironmentRibbonType environmentRibbonType)
        => environmentRibbonType switch
        {
            EnvironmentRibbonType.Dev => new EnvironmentRibbonConfiguration
            {
                Text = "Dev",
                TextColor = Colors.White,
                BackgroundColor = Colors.Red
            },
            EnvironmentRibbonType.Alpha => new EnvironmentRibbonConfiguration
            {
                Text = "Alpha",
                TextColor = Colors.White,
                BackgroundColor = Colors.DarkOrange
            },
            EnvironmentRibbonType.Beta => new EnvironmentRibbonConfiguration
            {
                Text = "Beta",
                TextColor = Colors.White,
                BackgroundColor = Colors.Green
            },

            _ => throw new ArgumentOutOfRangeException(nameof(environmentRibbonType))
        };

    public static Shell AddEnvironmentRibbon(this Shell shell, EnvironmentRibbonConfiguration configuration)
    {
        ShellExtensions.configuration = configuration;

        shell.Navigated += AppShell_Navigated;
        return shell;
    }

    private static void AppShell_Navigated(object? sender, ShellNavigatedEventArgs e)
    {
        if (sender is Shell { CurrentPage: not null } shell)
        {
            if (shell.CurrentPage.GetValue(EnvironmentRibbon.IsEnvironmentRibbonAddedProperty) is false)
            {
                AddEnvironmentRibbonToPage(shell.CurrentPage);
                shell.CurrentPage.SetValue(EnvironmentRibbon.IsEnvironmentRibbonAddedProperty, true);
            }
        }
    }

    private static void AddEnvironmentRibbonToPage(Page page)
    {
        if (page is ContentPage contentPage)
        {
            if (contentPage.Content is Grid rootGrid)
            {
                rootGrid.Children.Add(new EnvironmentRibbon(configuration));
            }
            else
            {
                var newRootGrid = new Grid();

                newRootGrid.Children.Add(contentPage.Content);
                newRootGrid.Children.Add(new EnvironmentRibbon(configuration));

                contentPage.Content = newRootGrid;
            }
        }
    }
}