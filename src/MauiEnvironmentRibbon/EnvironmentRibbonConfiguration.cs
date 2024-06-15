namespace MauiEnvironmentRibbon;

public record EnvironmentRibbonConfiguration
{
    public string Text { get; set; } = "Unknown";
    public Color TextColor { get; set; } = Colors.White;
    public Color BackgroundColor { get; set; } = Colors.Black;
    public CornerRadius CornerRadius { get; set; } = new(10);
}