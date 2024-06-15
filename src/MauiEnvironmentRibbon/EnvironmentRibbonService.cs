using MauiEnvironmentRibbon.Controls;
using Page = Microsoft.Maui.Controls.Page;

namespace MauiEnvironmentRibbon;

public class EnvironmentRibbonService
{
    private static EnvironmentRibbonConfiguration? configuration;

    public static void SetConfiguration(EnvironmentRibbonType environmentRibbonType)
    {
        configuration = GetConfiguration(environmentRibbonType);
    }

    public static void SetConfiguration(EnvironmentRibbonConfiguration configuration)
    {
        EnvironmentRibbonService.configuration = configuration;
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

    public static void Shell_Navigated(object? sender, ShellNavigatedEventArgs e)
    {
        if (sender is Shell shell)
        {
            AddEnvironmentRibbonToPage(shell.CurrentPage);
        }
    }

    public static void NavigationPage_Pushed(object? sender, NavigationEventArgs e)
    {
        if (sender is NavigationPage navigationPage)
        {
            AddEnvironmentRibbonToPage(navigationPage.CurrentPage);
        }
    }

    public static void AddEnvironmentRibbonToPage(Page? page)
    {
        if (page is ContentPage contentPage
            && contentPage.GetValue(EnvironmentRibbon.IsEnvironmentRibbonAddedProperty) is false
            && configuration is not null)
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

            page.SetValue(EnvironmentRibbon.IsEnvironmentRibbonAddedProperty, true);
        }
    }
}