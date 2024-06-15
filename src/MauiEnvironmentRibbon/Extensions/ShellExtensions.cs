namespace MauiEnvironmentRibbon.Extensions;

public static class ShellExtensions
{
    public static Shell AddEnvironmentRibbon(this Shell shell, EnvironmentRibbonType environmentRibbonType)
    {
        EnvironmentRibbonService.SetConfiguration(environmentRibbonType);
        shell.Navigated += EnvironmentRibbonService.Shell_Navigated;
        return shell;
    }

    public static Shell AddEnvironmentRibbon(this Shell shell, EnvironmentRibbonConfiguration configuration)
    {
        EnvironmentRibbonService.SetConfiguration(configuration);
        shell.Navigated += EnvironmentRibbonService.Shell_Navigated;
        return shell;
    }
}