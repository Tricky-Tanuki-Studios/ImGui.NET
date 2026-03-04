# Generating Bindings

> [!WARNING]
> IN ABSOLUTELY *NO* CASE SHOULD YOU BE DIRECTLY WORKING IN THE GENERATED FILES OTHER THAN FIGURING OUT WHAT TYPES AND FUNCTIONS IT GENERATES, NEVER COMMIT ANY CODE THAT'S BEEN MANUALLY HUMAN EDITED IN `Generated/` DIRECTORIES.
>
> THE GENERATOR *WILL* OVERWRITE ANY CHANGES YOU'VE MADE TO THE `Generated/` DIRECTORIES, YOU HAVE BEEN WARNED.
> 
> ANY CODE THERE CHANGED SHOULD BE TO THE GENERATOR ITSELF, IF SOMETHING BREAKS, FIX IT IN THE GENERATOR.

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