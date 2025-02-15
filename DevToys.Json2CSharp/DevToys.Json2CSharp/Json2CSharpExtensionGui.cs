using DevToys.Api;
using System.ComponentModel.Composition;
using static DevToys.Api.GUI;

namespace DevToys.Json2CSharp;

[Export(typeof(IGuiTool))]
[Name("Json2CSharp")]                                                         
[ToolDisplayInformation(
    IconFontName = "FluentSystemIcons",                                       
    IconGlyph = '\uE670',                                                     
    GroupName = PredefinedCommonToolGroupNames.Converters,                    
    ResourceManagerAssemblyIdentifier = nameof(Json2CSharpExtensionResourceAssemblyIdentifier), 
    ResourceManagerBaseName = "DevToys.Json2CSharp.Resources",                      
    ShortDisplayTitleResourceName = nameof(Json2CSharp.ShortDisplayTitle),    
    LongDisplayTitleResourceName = nameof(Json2CSharp.LongDisplayTitle),
    DescriptionResourceName = nameof(Json2CSharp.Description),
    AccessibleNameResourceName = nameof(Json2CSharp.AccessibleName))]
internal sealed class Json2CSharpExtensionGui : IGuiTool
{
    public UIToolView View => new(Label().Style(UILabelStyle.BodyStrong).Text(Json2CSharp.HelloWorldLabel));

    public void OnDataReceived(string dataTypeName, object? parsedData)
    {
        throw new NotImplementedException();
    }
}