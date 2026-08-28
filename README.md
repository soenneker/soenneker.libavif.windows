[![](https://img.shields.io/nuget/v/soenneker.libavif.windows.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libavif.windows/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.windows/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.windows/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libavif.windows.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libavif.windows/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.windows/codeql.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.windows/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Libavif.Windows
### A bundled libavif command-line distribution for Windows x64 .NET applications.

## Installation

```
dotnet add package Soenneker.Libavif.Windows
```

The package copies the official statically linked `avifenc.exe`, `avifdec.exe`, and `avifgainmaputil.exe` release tools to `Resources/win-x64/libavif`.

The binaries come from [AOMediaCodec/libavif](https://github.com/AOMediaCodec/libavif/releases). The upstream license and source information are included with the runtime.
