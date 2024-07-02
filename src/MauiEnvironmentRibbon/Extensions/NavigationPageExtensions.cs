namespace MauiEnvironmentRibbon.Extensions;

public static class NavigationPageExtensions
{
    public static NavigationPage AddEnvironmentRibbon(this NavigationPage navigationPage, EnvironmentRibbonType environmentRibbonType, EnvironmentRibbonPosition environmentRibbonPosition)
    {
        EnvironmentRibbonService.SetConfiguration(environmentRibbonType, environmentRibbonPosition);
        return navigationPage.AddEnvironmentRibbon();
    }

    public static NavigationPage AddEnvironmentRibbon(this NavigationPage navigationPage, EnvironmentRibbonConfiguration configuration)
    {
        EnvironmentRibbonService.SetConfiguration(configuration);
        return navigationPage.AddEnvironmentRibbon();
    }

    public static NavigationPage AddEnvironmentRibbon(this NavigationPage navigationPage)
    {
        EnvironmentRibbonService.AddEnvironmentRibbonToPage(navigationPage.CurrentPage);

        navigationPage.Pushed += EnvironmentRibbonService.NavigationPage_Pushed;
        return navigationPage;
    }
}