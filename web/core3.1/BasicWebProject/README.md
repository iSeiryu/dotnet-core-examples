The purpose of this project is to demo the minimum setup required to start a web application with [dotnet core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1).

# Build Run Test
```bash
git clone https://github.com/iSeiryu/dotnet-core-examples.git
cd path/to/dotnet-core-examples/web/core3.1/BasicWebProject

dotnet build
dotnet run -p BasicWebProject/BasicWebProject.csproj

curl localhost:5000/home
```

You can also navigate to http://localhost:5000/home