using MauiEnvironmentRibbon.Extensions;
using MauiEnvironmentRibbon.NavigationPageSample.Models;

namespace MauiEnvironmentRibbon.NavigationPageSample.Pages.Flyouts;

public partial class MainFlyoutPage
{
	public MainFlyoutPage()
	{
		InitializeComponent();

		FlyoutPage.CollectionView.SelectionChanged += OnCollectionViewSelectionChanged;
    }

    private void OnCollectionViewSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is FlyoutMenuPageItemModel item)
        {
            var navigationPage = new NavigationPage(Activator.CreateInstance(item.TargetType) as Page);
            navigationPage.AddEnvironmentRibbon(EnvironmentRibbonType.Alpha);

            Detail = navigationPage;
            IsPresented = false;
        }
    }
}