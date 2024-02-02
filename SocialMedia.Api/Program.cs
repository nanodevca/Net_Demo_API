
using SocialMedia.Api.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterSevices(typeof(Program));

var app = builder.Build();

app.RegisterPipelineComponents(typeof(Program));

app.Run();

