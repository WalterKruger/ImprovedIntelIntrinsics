# Overview
This project is a .NET Windows Forms recreation of the [Intel Intrinsic Guide website](https://www.intel.com/content/www/us/en/docs/intrinsics-guide/index.html), with additional search options like vector size, type, and masked variations. This is mostly created as an excuse to learn WinForms and because of how much AVX-512 has bloated things. Some entries are missing information or notes and thus may be misleading or broken in various non-obvious ways. Please refer to Intel’s website (or better yet, their developer manual) for anything important.

Intel’s Intrinsic Guide is an excellent online resource documenting their x86 intrinsics, which are C wrappers around individual x86-64 machine instructions. Most of them are Single Instruction, Multiple Data intrinsics which allow for SIMD programming in higher level languages. They are supported on most modern x86 compilers.

## Building
I programmed this in `Visual Studio 2022`, using `.NET 8.0-Windows`. The [releases page](../../releases) contains a Windows x64 executable which you can run directly or build it yourself using the following instructions:
1. Install “.NET desktop development” component using the Visual Studio installer.
2. Download this repository and open the `ImproveIntelInstrincs.csproj` file in VS.
3. You should be able to run the project directly, as it doesn’t contain any additional dependencies. You can also create your own executable by right clicking the project in the solutions explorer and selecting the `Publish` option.
