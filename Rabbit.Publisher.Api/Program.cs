using Rabbit.Application.Interfaces;
using Rabbit.Application.Services;
using Rabbit.Publisher.Api.Controllers.Presenters;
using Rabbit.Publisher.Api.Controllers.Presenters.Interfaces;
using Rabbit.Repositories;
using Rabbit.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IRabbitMessagePresenter, RabbitMessagePresenter>();
builder.Services.AddScoped<IRabbitMessageService, RabbitMessageService>();
builder.Services.AddTransient<IRabbitMessageRepository, RabbitMessageRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
