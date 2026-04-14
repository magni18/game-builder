using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend",
        policy =>
        {
            policy.WithOrigins("http://localhost:5173")
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

var app = builder.Build();

app.UseRouting();
app.UseCors("AllowFrontend");
app.UseAuthorization();

using var db = new GameCreationSessionContext();

Console.WriteLine($"Database path: {db.DbPath}.");

var creationSession = new GameCreationSession
{
    CreationPackType = CreationPackTypes.UIPartyPack
};

var sessionStoring = new GameCreationSessionStoring();

app.MapPost("/create-session", 
    ([FromBody] GameCreationSession creationSession) => sessionStoring.StoreSession(creationSession));

app.MapGet("/get-session/{sessionId}", 
    (string sessionId) => sessionStoring.GetSession(sessionId));

app.Run();