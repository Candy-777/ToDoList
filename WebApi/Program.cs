using WebApi.Handlers;
using WebApi.Interfaces;
using WebApi.Repositories;
using FluentValidation;
using WebApi.Models.Validators;
using Scrutor;

var builder = WebApplication.CreateBuilder(args);

// добавление валидации
builder.Services.AddValidatorsFromAssemblyContaining<TaskDtoValidator>();

// Добавление сервисов в контейнер
builder.Services.AddControllers();

// Регистрация обработчика задач (Handler) и репозитория (Repository) для DI

builder.Services.AddScoped<ITaskHandler, TaskHandler>();
builder.Services.AddSingleton<ITaskRepository, TaskRepository>();
builder.Services.Decorate<ITaskRepository, UniqueTitleTaskRepositoryDecorator>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();