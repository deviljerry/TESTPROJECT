var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.PROJECT_ApiService>("apiservice");

builder.AddProject<Projects.PROJECT_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
