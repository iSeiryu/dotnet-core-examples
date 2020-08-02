The purpose of this project is to demo the minimum setup required to start a fully functional and ready to be extended console application with [dotnet core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1). It works on Windows, Lunux, and Mac.

# Build Run Test
```powershell
git clone https://github.com/iSeiryu/dotnet-core-examples.git
cd path/to/dotnet-core-examples/console/core3.1/BasicConsoleProject/BasicConsoleProject

dotnet build
dotnet run
```

[Dotnet commands](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet) can take a lot of arguments. By default the project is built with the Debug configuration. To [build](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build) it in Release (for Production usage) do the following:
```powershell
dotnet build -c Release
dotnet run -c Release
```

The [run](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run) command is usually used for testing purposes. To actially run the application in Production do the following (the **dll** is produced by the [build](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build) and [publish](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish) commands and can be output to any folder you'd like, but the default path is ```\BasicConsoleProject\bin\Release\netcoreapp3.1```):
```powershell
dotnet BasicConsoleProject.dll
```

# Develop
The project is ready to be opened in [VS 2019 or above](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/).  
For general info on how to work with .NET Core in VS Code refer to this article: https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code