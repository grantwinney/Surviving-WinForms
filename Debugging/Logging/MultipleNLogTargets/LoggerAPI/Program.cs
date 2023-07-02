using LoggerAPI;
using NLog;
using LogLevel = NLog.LogLevel;

var builder = WebApplication.CreateBuilder(args);
var logger = LogManager.GetCurrentClassLogger();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Use this when you aren't sure of the shape of the
// incoming body, just to see what's being passed in
//app.MapPost("/log", (HttpRequest request) =>
//{
//    using var reader = new StreamReader(request.Body);
//    var bodyStr = reader.ReadToEndAsync();
//});

app.MapPost("/log", async (HttpRequest request) =>
{
    var payload = await request.ReadFromJsonAsync<AppLog>();

    var logMsg = $"{payload.Event.UTC}|{payload.Host}|{payload.Event.Level}||({payload.Event.Thread}) {payload.Event.Message}";

    logger.Log(LogLevel.FromString(payload.Event.Level), logMsg);
});

app.Run();
