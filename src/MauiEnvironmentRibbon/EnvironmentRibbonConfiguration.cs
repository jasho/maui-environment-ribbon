namespace MauiEnvironmentRibbon;

public record EnvironmentRibbonConfiguration
{
    public EnvironmentRibbonPosition Position { get; set; }
    public string Text { get; set; } = string.Empty;
    public Color TextColor { get; set; } = Colors.White;
    public Color BackgroundColor { get; set; } = Colors.Black;
}