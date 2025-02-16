using DevToys.Api;
using static DevToys.Api.GUI;
using System.ComponentModel.Composition;

namespace Json2CSharp.GUI;

[Export(typeof(IGuiTool))]
[Name("Json to C# Gui Tool")]
[ToolDisplayInformation(
    IconFontName = "FluentSystemIcons",
    IconGlyph = '\uE670',
    ResourceManagerAssemblyIdentifier = nameof(Json2CSharpExtensionResourceAssemblyIdentifier),
    ResourceManagerBaseName = "Json2CSharp",
    ShortDisplayTitleResourceName = nameof(Json2CSharp.ShortDisplayTitle),
    LongDisplayTitleResourceName = nameof(Json2CSharp.LongDisplayTitle),
    DescriptionResourceName = nameof(Json2CSharp.Description),
    AccessibleNameResourceName = nameof(Json2CSharp.AccessibleName),
    SearchKeywordsResourceName = nameof(Json2CSharp.SearchKeywords),
    GroupName = "Converters"
)]
[TargetPlatform(Platform.Windows)]
[TargetPlatform(Platform.MacOS)]
[TargetPlatform(Platform.Linux)]
[NoCompactOverlaySupport]
internal sealed class Json2CSharpGuiTool : IGuiTool
{
    private readonly IUIMultiLineTextInput _multiLineTextInput = MultiLineTextInput();

    public UIToolView View 
        => new(
            Stack()
                .Vertical()
                .WithChildren(
                    MultiLineTextInput()
                        .Title("JSON Input")
                        .Language("Json"),

                    MultiLineTextInput()
                        .Title("Always wrapping editor")
                        .AlwaysWrap(),
                    
                    MultiLineTextInput()
                        .Title("Read only, extendable editor")
                        .Extendable()
                        .ReadOnly(),

                    _multiLineTextInput
                        .Title("Extra command & Highlight")
                        .CommandBarExtraContent(
                            Button()
                                .Text("Highlight")
                                .AccentAppearance()
                                .OnClick(OnHighlightButtonClick)
                        )
                )
        );

    public void OnDataReceived(string dataTypeName, object? parsedData) 
    {
        // Handle Smart Detection.
    }

    private void OnHighlightButtonClick()
    {
        if (_multiLineTextInput.Text.Length > 20)
        {
            _multiLineTextInput.Highlight(
                new UIHighlightedTextSpan(0, 5, UIHighlightedTextSpanColor.Red),
                new UIHighlightedTextSpan(12, 5, UIHighlightedTextSpanColor.Green));

            _multiLineTextInput.HoverTooltip(
                new UIHoverTooltip(0, 5, "Hello world!"),
                new UIHoverTooltip(12, 5, "This is a tooltip"));
        }
    }
}
