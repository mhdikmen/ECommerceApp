using BuildingBlocks.Responses;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();
var app = builder.Build();

app.MapDefaultEndpoints();

app.MapGet("/", () => Results.Ok(new BaseResponse(false, "asd")));

app.Run();
