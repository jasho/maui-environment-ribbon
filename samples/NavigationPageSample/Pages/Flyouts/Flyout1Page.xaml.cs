namespace MauiEnvironmentRibbon.NavigationPageSample.Pages.Flyouts;

public partial class Flyout1Page
{
	public Flyout1Page()
	{
		InitializeComponent();
    }

    private void NavigateToFlyout1InnerPageClicked(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new Flyout1InnerPage());
    }
}