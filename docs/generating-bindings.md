# Generating Bindings

> [!WARNING]
> 
> In absolutely *no* case should you be directly modifying/working in generated files, other than figuring out what types and functions it generates.
> Never commit any code that's been manually human edited in any of the `Generated/` directories.
> 
> The Generator *will* overwrite any changes you've made to the `Generated/` directories, **you have been warned**
> 
> Any code that has been changed should be changed to the Generator itself, if something breaks, fix it in the Generator.

TODO: Better instructions, this is just temp for my [asojidev] usage

## Windows

- Make sure .NET 10 SDK is installed
- Open up Rider
- Open up the terminal
- Run `download-native-deps.ps1`, it should start downloading the native dependencies you've generated in [Tricky-Tanuki-Studios/ImGui.NET-nativebuild](https://github.com/Tricky-Tanuki-Studios/ImGui.NET-nativebuild)
- Run `dotnet run --project CodeGenerator\CodeGenerator.csproj TrickyTanukiStudios.ImGui.NET\Generated`
- If all succeeds, then congrats, you've generated your bindings! You can now work in the [CodeGenerator](../CodeGenerator) project!

## Linux

TODO

## macOS

what?