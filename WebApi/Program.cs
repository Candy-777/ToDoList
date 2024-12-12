using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using WebApi.Filters;
using WebApi.Handlers;
using WebApi.Interfaces;
using WebApi.Models.Validators;
using WebApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

// подключение валидации 

builder.Services.AddValidatorsFromAssemblyContaining<TaskDtoValidator>();
builder.Services.AddScoped<ValidationFilter>();

// Регистрация репозиториев и обработчиков
builder.Services.AddScoped<ITaskHandler, TaskHandler>();
builder.Services.AddSingleton<ITaskRepository, TaskRepository>();
builder.Services.Decorate<ITaskRepository, UniqueTitleTaskRepositoryDecorator>();

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
