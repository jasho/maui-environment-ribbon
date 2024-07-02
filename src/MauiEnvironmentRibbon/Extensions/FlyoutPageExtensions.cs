namespace MauiEnvironmentRibbon.Extensions;

public static class FlyoutPageExtensions
{
    public static FlyoutPage AddEnvironmentRibbon(this FlyoutPage flyoutPage, EnvironmentRibbonType environmentRibbonType, EnvironmentRibbonPosition environmentRibbonPosition)
    {
        EnvironmentRibbonService.SetConfiguration(environmentRibbonType, environmentRibbonPosition);
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