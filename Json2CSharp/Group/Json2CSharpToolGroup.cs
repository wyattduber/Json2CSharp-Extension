using DevToys.Api;
using System.ComponentModel.Composition;

namespace Json2CSharp.Group;

[Export(typeof(Json2CSharpToolGroup))]
[Name("Json2CSharp")]
[Order(After = PredefinedCommonToolGroupNames.Converters)]
internal class Json2CSharpToolGroup : GuiToolGroup
{
    [ImportingConstructor]
    internal Json2CSharpToolGroup()
    {
        IconFontName = "FluentSystemIcons";
        IconGlyph = '\uE670';
        DisplayTitle = Json2CSharp.GroupDisplayTitle;
        AccessibleName = Json2CSharp.GroupAccessibleName;
    }
}