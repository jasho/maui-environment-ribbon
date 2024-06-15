namespace MauiEnvironmentRibbon.Controls;

public partial class EnvironmentRibbon
{
    public static readonly BindableProperty IsEnvironmentRibbonAddedProperty = BindableProperty.CreateAttached(
        "IsEnvironmentRibbonAdded",
        typeof(bool),
        typeof(EnvironmentRibbon),
        false);

    public static bool GetIsEnvironmentRibbonAdded(BindableObject view)
    {
        return (bool)view.GetValue(IsEnvironmentRibbonAddedProperty);
    }

    public static void SetIsEnvironmentRibbonAdded(BindableObject view, bool value)
    {
        view.SetValue(IsEnvironmentRibbonAddedProperty, value);
    }

    public EnvironmentRibbon(EnvironmentRibbonConfiguration configuration)
    {
        InitializeComponent();

        EnvironmentLabel.Text = configuration.Text;
        EnvironmentLabel.TextColor = configuration.TextColor;
        TrianglePath.Fill = configuration.BackgroundColor;
    }
}