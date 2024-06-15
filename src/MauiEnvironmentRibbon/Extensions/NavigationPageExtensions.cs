namespace MauiEnvironmentRibbon.Extensions;

public static class NavigationPageExtensions
{
    public static NavigationPage AddEnvironmentRibbon(this NavigationPage navigationPage, EnvironmentRibbonType environmentRibbonType)
    {
        EnvironmentRibbonService.SetConfiguration(environmentRibbonType);
        EnvironmentRibbonService.AddEnvironmentRibbonToPage(navigationPage.CurrentPage);

        navigationPage.Pushed += EnvironmentRibbonService.NavigationPage_Pushed;
        return navigationPage;
    }

    public static NavigationPage AddEnvironmentRibbon(this NavigationPage navigationPage, EnvironmentRibbonConfiguration configuration)
    {
        EnvironmentRibbonService.SetConfiguration(configuration);
        EnvironmentRibbonService.AddEnvironmentRibbonToPage(navigationPage.CurrentPage);

        navigationPage.Pushed += EnvironmentRibbonService.NavigationPage_Pushed;
        return navigationPage;
    }
}