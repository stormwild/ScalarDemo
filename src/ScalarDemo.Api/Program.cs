
using ScalarDemo.Api;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();

app.MapOpenApi();

if (app.Environment.IsDevelopment())
{
    app.MapScalarUI(options => { });
}

app.MapGet("/", () => "Hello World!");

app.Run();
