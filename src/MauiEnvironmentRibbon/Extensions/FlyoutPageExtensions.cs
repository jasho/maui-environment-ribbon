namespace MauiEnvironmentRibbon.Extensions;

public static class FlyoutPageExtensions
{
    public static FlyoutPage AddEnvironmentRibbon(this FlyoutPage flyoutPage, EnvironmentRibbonType environmentRibbonType)
    {
        EnvironmentRibbonService.SetConfiguration(environmentRibbonType);
        EnvironmentRibbonService.AddEnvironmentRibbonToPage(flyoutPage.Detail);

        return flyoutPage;
    }

    public static FlyoutPage AddEnvironmentRibbon(this FlyoutPage flyoutPage, EnvironmentRibbonConfiguration configuration)
    {
        EnvironmentRibbonService.SetConfiguration(configuration);
        EnvironmentRibbonService.AddEnvironmentRibbonToPage(flyoutPage.Detail);

        return flyoutPage;
    }
}