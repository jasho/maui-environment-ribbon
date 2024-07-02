namespace MauiEnvironmentRibbon.Extensions;

public static class ShellExtensions
{
    public static Shell AddEnvironmentRibbon(this Shell shell, EnvironmentRibbonType environmentRibbonType, EnvironmentRibbonPosition environmentRibbonPosition)
    {
        EnvironmentRibbonService.SetConfiguration(environmentRibbonType, environmentRibbonPosition);
        return shell.AddEnvironmentRibbon();
    }

    public static Shell AddEnvironmentRibbon(this Shell shell, EnvironmentRibbonConfiguration configuration)
    {
        EnvironmentRibbonService.SetConfiguration(configuration);
        return shell.AddEnvironmentRibbon();
    }

    private static Shell AddEnvironmentRibbon(this Shell shell)
    {
        shell.Navigated += EnvironmentRibbonService.Shell_Navigated;
        return shell;
    }
}