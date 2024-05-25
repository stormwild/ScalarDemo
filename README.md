# Scalar Swagger Editor UI Demo

[Scalar - Document, Test & Discover APIs](https://scalar.com/)

[scalar/scalar: Beautiful API references from OpenAPI/Swagger files ✨](https://github.com/ScalaR/ScalaR)

[Get started with Microsoft.AspNetCore.OpenApi | Microsoft Learn](https://learn.microsoft.com/en-us/aspnet/core/fundamentals/minimal-apis/aspnetcore-openapi?view=aspnetcore-9.0&tabs=visual-studio#using-scalar-for-interactive-api-documentation)

[Swagger is Going Away in .NET 9! - YouTube](https://www.youtube.com/watch?v=8xEkVmqlr4I&sttick=0)

## How to use

<!-- Install .NET 9 SDK (v9.0.100-preview.4)

[Download .NET 9.0 (Linux, macOS, and Windows)](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) -->

<!-- ```sh
dotnet add package Scalar.AspNetCore
``` -->

```sh
dotnet new classlib -o src/Scalar.AspNetCore
```

```sh
dotnet add package Microsoft.AspNetCore.OpenApi --version 8.0.5
```

Copy files from:

[scalar/packages/scalar.aspnetcore/README.md at main · scalar/scalar](https://github.com/scalar/scalar/blob/main/packages/scalar.aspnetcore/README.md)

```csharp
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Scalar.AspNetCore;

var builder = WebApplication.CreateBuilder();

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

if (app.Environment.IsDevelopment())
{
    app.MapScalarApiReference();
}

app.MapGet("/", () => "Hello world!");

app.Run();
```
