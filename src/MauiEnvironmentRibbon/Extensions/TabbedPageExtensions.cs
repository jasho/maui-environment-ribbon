namespace MauiEnvironmentRibbon.Extensions;

public static class TabbedPageExtensions
{
    public static TabbedPage AddEnvironmentRibbon(this TabbedPage tabbedPage, EnvironmentRibbonType environmentRibbonType)
    {
        EnvironmentRibbonService.SetConfiguration(environmentRibbonType);
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