namespace MauiEnvironmentRibbon;

public record EnvironmentRibbonConfiguration
{
    public string Text { get; set; } = string.Empty;
    public Color TextColor { get; set; } = Colors.White;
    public Color BackgroundColor { get; set; } = Colors.Black;
}