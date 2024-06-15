﻿using MauiEnvironmentRibbon.Controls;

namespace MauiEnvironmentRibbon;

public static class ShellExtensions
{
    public static Shell AddEnvironmentRibbon(this Shell shell)
    {
        shell.Navigated += AppShell_Navigated;
        return shell;
    }

    private static void AppShell_Navigated(object? sender, ShellNavigatedEventArgs e)
    {
        if (sender is Shell { CurrentPage: not null } shell)
        {
            if (shell.CurrentPage.GetValue(EnvironmentRibbon.IsEnvironmentRibbonAddedProperty) is false)
            {
                AddEnvironmentRibbonToPage(shell.CurrentPage);
                shell.CurrentPage.SetValue(EnvironmentRibbon.IsEnvironmentRibbonAddedProperty, true);
            }
        }
    }

    private static void AddEnvironmentRibbonToPage(Page page)
    {
        if (page is ContentPage contentPage)
        {
            if (contentPage.Content is Grid rootGrid)
            {
                rootGrid.Children.Add(new EnvironmentRibbon());
            }
            else
            {
                var newRootGrid = new Grid();

                newRootGrid.Children.Add(contentPage.Content);
                newRootGrid.Children.Add(new EnvironmentRibbon());

                contentPage.Content = newRootGrid;
            }
        }
    }
}