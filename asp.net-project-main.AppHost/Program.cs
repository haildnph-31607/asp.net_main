var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.asp_net_project_main>("asp-net-project-main");

builder.Build().Run();
