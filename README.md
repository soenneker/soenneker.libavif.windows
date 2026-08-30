[![](https://img.shields.io/nuget/v/soenneker.libavif.windows.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libavif.windows/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.windows/build-and-test.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.windows/actions/workflows/build-and-test.yml)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.windows/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.windows/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.libavif.windows.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.libavif.windows/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.libavif.windows/codeql.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.libavif.windows/actions/workflows/codeql.yml)

# Soenneker.Libavif.Windows

The libavif command-line tools packaged for Windows x64 .NET applications.

## Install

```
dotnet add package Soenneker.Libavif.Windows
```

The package copies `avifenc.exe`, `avifdec.exe`, and `avifgainmaputil.exe` beneath the application output directory:

```text
Resources/win-x64/libavif/
```

Resolve that directory from `AppContext.BaseDirectory`; do not depend on the process working directory. This package contains Windows x64 binaries only and does not select a binary for other operating systems or architectures.

Most applications should reference `Soenneker.Libavif.Util`, which selects and invokes the matching platform tool. Reference this package directly when you need the native assets without the managed wrapper.

The binaries come from [AOMediaCodec/libavif](https://github.com/AOMediaCodec/libavif/releases). The upstream license and source information are included with the runtime.
