var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

// GET UTC
app.MapGet("time/utc", () => Results.Ok("This is the current UTC time: " + DateTime.UtcNow));
app.MapPost("This is the POST", () => Results.Ok("This is what happens when OK 200"));

await app.RunAsync();
