using System.Text.Json;
using code_along_7_november.Services;
using Microsoft.AspNetCore.Http.HttpResults;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

var votingService = new VotingService();

app.MapGet("/health", () => "Healthy");

app.MapPost("/valg", () => {
    var newElection = votingService.CreateElection();
    return Results.Ok(new {Id = $"/valg/{newElection.Id}"});
});

app.MapGet("/valg", () => {
    var data = votingService.GetAll();
    var json = JsonSerializer.Serialize(data);
    return json;
});


app.Run();
