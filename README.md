# Save exception logs with Serilog

## Make base project

```bash
# Make source folder
mkdir src && cd src
# Make solution
dotnet new sln -n SerilogDemo
# Make asp.net project
dotnet new webapi -n WebApi
# Add serilog dependency
dotnet add WebApi/WebApi.csproj package Serilog --version 2.10.0
# Add serilog Sink dependency
dotnet add WebApi/WebApi.csproj package Serilog.Sinks.File --version 5.0.0
# Add projects to solution
dotnet sln add WebApi/WebApi.csproj
# Restore NuGet packages
dotnet restore
# Delete default files
rm WebApi/WeatherForecast.cs WebApi/Controllers/WeatherForecastController.cs
```

## Add files

```bash

```