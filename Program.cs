var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddTypes()
    .AddMutationConventions();

var app = builder.Build();
app.MapGraphQL();
app.Run();
