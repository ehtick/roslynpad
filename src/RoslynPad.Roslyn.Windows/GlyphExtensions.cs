using System.Windows.Media;
using RoslynPad.Roslyn.Completion;
using RoslynPad.Roslyn.Resources;

namespace RoslynPad.Roslyn;

public static class GlyphExtensions
{
    public static IGlyphService GlyphService { get; set; } = new DefaultGlyphService();

    public static ImageSource? ToImageSource(this Glyph glyph) => GlyphService.GetGlyphImage(glyph);

    private class DefaultGlyphService : IGlyphService
    {
        private readonly Glyphs _glyphs = new();

        public ImageSource? GetGlyphImage(Glyph glyph) => _glyphs[glyph] as ImageSource;
    }
}
