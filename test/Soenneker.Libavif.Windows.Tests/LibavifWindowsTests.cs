using System.IO;
using System.Threading.Tasks;

namespace Soenneker.Libavif.Windows.Tests;

public sealed class LibavifWindowsTests
{
    [Test]
    public async Task Project_defines_the_expected_runtime_path()
    {
        string path = Path.Combine("Resources", "win-x64", "libavif", "avifenc.exe");
        await Assert.That(path).EndsWith("avifenc.exe");
    }
}
