using HelloWorld;

var builder = WebApplication.CreateBuilder(args);

//do some service config here later.
builder.Services.AddSingleton<DateUtils>();
var app = builder.Build();

Console.WriteLine("App is gonna run now...");


app.MapGet("/break/{minutes:int}", (int minutes, DateUtils utils) =>
{
    var response = new BreakTimerResponse(
        minutes,
        DateTime.Now,
        utils.TakeABreak(minutes)
        );
    return Results.Ok(response);
});

app.Run();

public record BreakTimerResponse(int Minutes, DateTime StartTime, DateTime EndTime);