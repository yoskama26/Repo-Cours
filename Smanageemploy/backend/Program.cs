﻿using backend.Infrastructures.Database;
using backend.Repositories;
using backend.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionBDD = builder.Configuration.GetConnectionString("EmployeesDatabase");

builder.Services.AddDbContext<ManageEmployeeDbContext>(options => options.UseNpgsql(connectionBDD));

builder.Services.AddScoped<DepartmentRepository>();
builder.Services.AddScoped<EmployeeRepository>();
builder.Services.AddScoped<AttendanceRepository>();
builder.Services.AddScoped<StatusRepository>();
builder.Services.AddScoped<LeaverequestRepository>();

builder.Services.AddScoped<DepartmentService>();
builder.Services.AddScoped<EmployeeService>();
builder.Services.AddScoped<EmployeeDepartmentService>();
builder.Services.AddScoped<AttendanceService>();
builder.Services.AddScoped<StatusService>();
builder.Services.AddScoped<LeaverequestService>();

builder.Services.AddControllers();

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

app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
