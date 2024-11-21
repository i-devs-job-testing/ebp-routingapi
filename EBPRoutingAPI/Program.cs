using EBPRoutingAPI.Domain.Interfaces;
using EBPRoutingAPI.Domain.Validators;
using EBPRoutingAPI.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Injecter les validateurs, fourniseurs de données,  
builder.Services.AddScoped<IRoutingValidator, RoutingValidator>();
builder.Services.AddScoped<IRoutingRepository, RoutingRepository>();

//TODO : Injecter le service Logging


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
