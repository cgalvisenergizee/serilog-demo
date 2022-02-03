# Save exception logs with Serilog

> some code and steps from [campusmvp.es](https://www.campusmvp.es/recursos/post/como-manejar-trazas-en-net-core-con-serilog.aspx)

## Make base project

```bash
# Make source folder
mkdir src && cd src
# Make solution
dotnet new sln -n SerilogDemo
# Make asp.net project
dotnet new webapi -n WebApi
# Add serilog dependencies
dotnet add WebApi/WebApi.csproj package Serilog --version 2.10.0
dotnet add WebApi/WebApi.csproj package Serilog.Settings.Configuration --version 3.3.0
dotnet add WebApi/WebApi.csproj package Serilog.Sinks.File --version 5.0.0
dotnet add WebApi/WebApi.csproj package Serilog.AspNetCore --version 4.1.0
# Add projects to solution
dotnet sln add WebApi/WebApi.csproj
# Restore NuGet packages
dotnet restore
# Delete default files
rm WebApi/WeatherForecast.cs WebApi/Controllers/WeatherForecastController.cs
```

## Watch log file changes

```bash
watch tail -n 20 src/WebApi/serilog*.txt
```