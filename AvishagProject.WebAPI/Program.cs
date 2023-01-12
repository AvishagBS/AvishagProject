using AvishagProject.Context;
using AvishagProject.Mock;
using AvishagProject.Repositories;
using AvishagProject.Repositories.Interfaces;
using AvishagProject.Repositories.Repositories;
using AvishagProject.Services;
using AvishagProject.WebAPI.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddSingleton<IContext, MockContext>();
builder.Services.AddDbContext<IContext,DataContext>();

//builder.Services.AddServices();//לשאול את המורה מה זה

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseExceptionHandler();

app.UseHttpsRedirection();

app.UseAuthorization();
//my middleware 
app.UserShabbat();
app.UserTrack();


app.MapControllers();

app.Run();
