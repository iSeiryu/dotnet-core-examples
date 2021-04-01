The purpose of this project is to demo the minimum setup required to start a fully functional and ready to be extended web application with [dotnet core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1). It works on Windows, Lunux, and Mac.

# Build Run Test
```powershell
git clone https://github.com/iSeiryu/dotnet-core-examples.git
cd path/to/dotnet-core-examples/web/core3.1/BasicWebProject

dotnet build
dotnet run -p BasicWebProject/BasicWebProject.csproj

curl localhost:5000/home
```

You can also navigate to http://localhost:5000/home in a browser.

[Dotnet commands](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet) can take a lot of arguments. By default the project is built with the Debug configuration. To [build](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build) it in Release (for Production usage) do the following:
```powershell
dotnet build -c Release
dotnet run -p BasicWebProject/BasicWebProject.csproj -c Release
```

The [run](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-run) command is usually used for testing purposes. To actially run the application in Production do the following (the **dll** is produced by the [build](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-build) and [publish](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish) commands and can be output to any folder you'd like, but the default path is ```\BasicWebProject\bin\Release\netcoreapp3.1```):
```powershell
dotnet BasicWebProject.dll
```

The output of the build produces ~285 KB of files on Windows and ~200 KB on Ubuntu (Linux) that are ready to be deployed and ran on a server. The default build does not include the runtime and requires either .NET Core 3.1 SDK or Runtime to be installed on the server.

There is an option to [publish](https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-publish) the project for a specific environment that includes everything required for the application to run. This way .NET Core is not required to be installed on the server.
```powershell
dotnet publish --self-contained true
#OR
dotnet publish --self-contained true --runtime osx.10.11-x64
#OR
dotnet publish --self-contained true --runtime ubuntu.18.04-x64
```

# Develop
The project is ready to be opened in [VS 2019 or above](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/).  
For general info on how to work with .NET Core in VS Code refer to this article: https://docs.microsoft.com/en-us/dotnet/core/tutorials/with-visual-studio-code

[Run self contained app on Linux](https://stackoverflow.com/questions/40226032/running-a-self-contained-asp-net-core-application-on-ubuntu)