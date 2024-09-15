var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.YarpApiGateway>("yarpapigateway");

builder.AddProject<Projects.Identity_API>("identity-api");

builder.Build().Run();
