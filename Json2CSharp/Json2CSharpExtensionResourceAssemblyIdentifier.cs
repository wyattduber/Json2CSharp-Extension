using System.ComponentModel.Composition;
using DevToys.Api;

namespace Json2CSharp;

[Export(typeof(IResourceAssemblyIdentifier))]
[Name(nameof(Json2CSharpExtensionResourceAssemblyIdentifier))]
internal sealed class Json2CSharpExtensionResourceAssemblyIdentifier
{
    public ValueTask<FontDefinition[]> GetFontDefinitionsAsync()
    {
        throw new NotImplementedException();
    }
}