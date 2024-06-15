namespace MauiEnvironmentRibbon.NavigationPageSample.Pages.Tabs;

public partial class Tab1Page
{
	public Tab1Page()
	{
		InitializeComponent();
	}

    private async void NavigateToTab1InnerPageClicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new Tab1InnerPage());
    }
}