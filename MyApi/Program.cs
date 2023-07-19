var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/name/{nome}", (string nome) => $"Hello {nome}!");

app.MapPost("/", (User user) => user);

app.Run();

public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
}