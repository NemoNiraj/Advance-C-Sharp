var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "My First ASP.Net core APP");

app.Run();

