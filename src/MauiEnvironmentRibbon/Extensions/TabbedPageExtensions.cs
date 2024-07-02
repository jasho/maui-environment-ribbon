namespace MauiEnvironmentRibbon.Extensions;

public static class TabbedPageExtensions
{
    public static TabbedPage AddEnvironmentRibbon(this TabbedPage tabbedPage, EnvironmentRibbonType environmentRibbonType, EnvironmentRibbonPosition environmentRibbonPosition)
    {
        EnvironmentRibbonService.SetConfiguration(environmentRibbonType, environmentRibbonPosition);
        foreach (var child in tabbedPage.Children)
        {
            EnvironmentRibbonService.AddEnvironmentRibbonToPage(child);
        }

        return tabbedPage;
    }

    public static TabbedPage AddEnvironmentRibbon(this TabbedPage tabbedPage, EnvironmentRibbonConfiguration configuration)
    {
        EnvironmentRibbonService.SetConfiguration(configuration);
        foreach (var child in tabbedPage.Children)
        {
            EnvironmentRibbonService.AddEnvironmentRibbonToPage(child);
        }

        return tabbedPage;
    }
}