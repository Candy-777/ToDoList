using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using DataAccess.Repository;
using WebApi.Validators;
using Domain.Interfaces;
using Domain.Handler;
using Domain.Enities;
using DataAccess;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// подключение валидации 

builder.Services.AddDbContext<AppDbContext>();

builder.Services.AddValidatorsFromAssemblyContaining<TaskDtoValidator>();
builder.Services.AddScoped<ValidationFilter>();

// Регистрация репозиториев и обработчиков
builder.Services.AddScoped<ITaskHandler, TaskHandler>();
builder.Services.AddScoped<IBaseRepository<TaskEntity>, TaskRepository>();
builder.Logging.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Warning);

// Добавление контроллеров
builder.Services.AddControllers();

// Добавление Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Middleware для обработки ошибок
app.UseMiddleware<ErrorHandlingMiddleware>();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
