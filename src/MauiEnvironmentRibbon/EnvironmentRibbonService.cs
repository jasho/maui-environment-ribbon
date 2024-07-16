using MauiEnvironmentRibbon.Controls;
using Page = Microsoft.Maui.Controls.Page;

namespace MauiEnvironmentRibbon;

public class EnvironmentRibbonService
{
    private static EnvironmentRibbonConfiguration? _configuration;

    public static void SetConfiguration(EnvironmentRibbonType environmentRibbonType, EnvironmentRibbonPosition environmentRibbonPosition)
    {
        SetConfiguration(CreateConfiguration(environmentRibbonType, environmentRibbonPosition));
    }

    public static void SetConfiguration(EnvironmentRibbonConfiguration configuration)
    {
        _configuration ??= configuration;
    }

    private static EnvironmentRibbonConfiguration CreateConfiguration(EnvironmentRibbonType environmentRibbonType, EnvironmentRibbonPosition environmentRibbonPosition)
    {
        var configuration = environmentRibbonType switch
        {
            EnvironmentRibbonType.Dev => new EnvironmentRibbonConfiguration
            {
                TextColor = Colors.White,
                BackgroundColor = Colors.Red
            },
            EnvironmentRibbonType.Alpha => new EnvironmentRibbonConfiguration
            {
                TextColor = Colors.White,
                BackgroundColor = Colors.DarkOrange
            },
            EnvironmentRibbonType.Beta => new EnvironmentRibbonConfiguration
            {
                TextColor = Colors.White,
                BackgroundColor = Colors.Green
            },

            _ => throw new ArgumentOutOfRangeException(nameof(environmentRibbonType))
        };

        configuration.Text = AppInfo.Current.VersionString;
        configuration.Position = environmentRibbonPosition;

        return configuration;
    }

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
        if (_configuration is null
            || page?.GetValue(EnvironmentRibbon.IsEnvironmentRibbonAddedProperty) is true)
        {
            return;
        }

        if (page is ContentPage contentPage)
        {
            var newRootGrid = new Grid();

            newRootGrid.Children.Add(contentPage.Content);
            newRootGrid.Children.Add(new EnvironmentRibbon(_configuration));
            contentPage.Content = newRootGrid;
        }
        else if (page is NavigationPage navigationPage)
        {
            navigationPage.Pushed += NavigationPage_Pushed;
            AddEnvironmentRibbonToPage(navigationPage.CurrentPage);
        }
        else if (page is TabbedPage tabbedPage)
        {
            foreach (var child in tabbedPage.Children)
            {
                AddEnvironmentRibbonToPage(child);
            }
        }
        else if (page is FlyoutPage flyoutPage)
        {
            AddEnvironmentRibbonToPage(flyoutPage.Detail);
        }

        page?.SetValue(EnvironmentRibbon.IsEnvironmentRibbonAddedProperty, true);
    }
}