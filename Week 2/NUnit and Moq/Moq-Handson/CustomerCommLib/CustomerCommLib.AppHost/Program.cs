var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.CustomerCommLib_ApiService>("apiservice");

builder.AddProject<Projects.CustomerCommLib_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
