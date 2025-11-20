var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Middleware 1: Simple Logger
app.Use(async (context, next) =>
{
    Console.WriteLine("Incoming Request...........");
    await next();  // Pass Control to the Next Middleware
    Console.WriteLine("Loading Response...........");
});

// Middleware 2: Endpoint Request Handler
app.MapGet("/", () => "Welcome to CodeLeapWebApp Request Pipeline Demo for Learning C#");

app.Run();
