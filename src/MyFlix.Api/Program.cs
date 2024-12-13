using MyFlix.Api.Services;
using MyFlix.Api.Services.Interfaces;
using Myflix.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["Mongo:ConnectionString"];

builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddControllers();
builder.Services.AddInfrastructure(connectionString);
builder.Services.AddScoped<IMovieService, MovieService>();

var app = builder.Build();

app.UseRouting();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapControllers();
app.Run();