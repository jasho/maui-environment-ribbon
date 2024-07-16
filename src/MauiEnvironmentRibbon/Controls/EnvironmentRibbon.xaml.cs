using Microsoft.Maui.Controls.Shapes;

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
        RibbonPath.Fill = configuration.BackgroundColor;
        SetPositionValues(configuration.Position);
    }

    private void SetPositionValues(EnvironmentRibbonPosition position)
    {
        var pathData = string.Empty;
        var horizontalOptions = LayoutOptions.Start;
        var verticalOptions = LayoutOptions.Start;
        var environmentLabelRotation = 0;
        var environmentLabelTranslationX = 0;
        var environmentLabelTranslationY = 0;

        switch (position)
        {
            case EnvironmentRibbonPosition.TopLeft:
                pathData = "M 30,0 L 50,0 L 0,50 L 0,30 Z";
                horizontalOptions = LayoutOptions.Start;
                verticalOptions = LayoutOptions.Start;
                environmentLabelRotation = -45;
                environmentLabelTranslationX = -6;
                environmentLabelTranslationY = -6;
                break;
            case EnvironmentRibbonPosition.TopRight:
                pathData = "M 0,0 L 20,0 L 50,30 L 50,50 Z";
                horizontalOptions = LayoutOptions.End;
                verticalOptions = LayoutOptions.Start;
                environmentLabelRotation = 45;
                environmentLabelTranslationX = 6;
                environmentLabelTranslationY = -6;
                break;
            case EnvironmentRibbonPosition.BottomLeft:
                pathData = "M 0,0 L 50,50 L 30,50 L 0,20 Z";
                horizontalOptions = LayoutOptions.Start;
                verticalOptions = LayoutOptions.End;
                environmentLabelRotation = 45;
                environmentLabelTranslationX = -4;
                environmentLabelTranslationY = 4;
                break;
            case EnvironmentRibbonPosition.BottomRight:
                pathData = "M 50,0 L 50,20 L 20,50 L 0,50 Z";
                horizontalOptions = LayoutOptions.End;
                verticalOptions = LayoutOptions.End;
                environmentLabelRotation = -45;
                environmentLabelTranslationX = 4;
                environmentLabelTranslationY = 4;
                break;
        }

        RibbonPath.Data = new PathGeometryConverter().ConvertFromInvariantString(pathData) as Geometry;
        HorizontalOptions = horizontalOptions;
        VerticalOptions = verticalOptions;
        EnvironmentLabel.Rotation = environmentLabelRotation;
        EnvironmentLabel.TranslationX = environmentLabelTranslationX;
        EnvironmentLabel.TranslationY = environmentLabelTranslationY;
    }
}