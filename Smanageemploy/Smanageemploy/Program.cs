using Smanageemploy.Infrastructures.Database;
using Smanageemploy.Repositories.Contracts;
using Smanageemploy.Repositories.Implementations;
using Smanageemploy.Services.Contracts;
using Smanageemploy.Services.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Ajout des repositories
builder.Services.AddScoped<IDepartementRepository, DepartementRepository>();

// Ajout des services
builder.Services.AddScoped<IDepartementService, DepartementService>();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
