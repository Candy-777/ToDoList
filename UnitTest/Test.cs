using Moq;
using ToDoListApi.Enums;
using WebApi.Handlers;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Repositories;
using Xunit;

namespace UnitTest
{
    public class Test
    {
        private readonly ITaskRepository _repository;
        private readonly TaskHandler _handler;
        private readonly UniqueTitleTaskRepositoryDecorator _decorator;

        public Test()
        {
            _repository = new TaskRepository();
            _decorator = new UniqueTitleTaskRepositoryDecorator(_repository);
            _handler = new TaskHandler(_decorator);
            _repository.Add(new TaskItem { Id = 1, Title = "Task 1", Priority = Priority.Low, DeadLine = DateTime.Now.Date.AddDays(1) });
            _repository.Add(new TaskItem { Id = 2, Title = "Task 2", Priority = Priority.Medium, DeadLine = DateTime.Now.Date.AddDays(2) });

        }

        [Fact]
        public void GetTask_ShouldReturnTask()
        {
            var result = _handler.GetTask(1);
            Assert.Equal("Task 1", result.Title);
        }
        [Fact]
        public void GetTask_ThrowKeyNotFound()
        {
            // попытка получить несуществующую задачу
            Assert.Throws<KeyNotFoundException>(() => _handler.GetTask(5));
        }

        [Fact]
        public void CreateTask_ShoutRetundTrue()
        {
            var task = new TaskDto {Title = "Task 3", Priority = Priority.Medium, DeadLine = DateTime.Now.AddDays(2)};
            Assert.True(_handler.CreateTask(task));
        }

        [Fact]
        public void CreateTask_ThrowArgumentException()
        {
            // попытка создать задачу с повторящимся Title (проверка декоратора)
            var task = new TaskDto { Title = "Task 1", Priority = Priority.Medium, DeadLine = DateTime.Now.AddDays(2) };
            Assert.Throws<ArgumentException>(() => _handler.CreateTask(task));
        }

        [Fact]
        public void DeleteTask_ShouldReturnTrue() 
        {
            int id = 1;
            var result = _handler.DeleteTask(id);
            Assert.True(result);
        }

        [Fact]
        public void DeleteTask_ThrowKeyNotFound()
        {
            // попытка удалить несуществующую задачу
            Assert.Throws<KeyNotFoundException>(() => _handler.DeleteTask(111));
        }

        [Fact]
        public void UpdateTask_ShouldReturnTrue()
        {
            var task = new TaskDto { Title = "Task 1", Priority = Priority.Low, DeadLine = DateTime.Now.AddDays(2) };
            int id = 1;
            var result = _handler.UpdateTask(id, task);
            Assert.True(result);
        }

        [Fact]
        public void UpdateTask_ThrowArgumentException()
        {
            // попытка обновить Title который уже есть у другой таски (проверка декоратора)
            var task = new TaskDto { Title = "Task 2", Priority = Priority.Low, DeadLine = DateTime.Now.AddDays(2) };
            int id = 1;        
            Assert.Throws<ArgumentException>(() => _handler.UpdateTask(id, task));
        }

        [Fact]
        public void UpdateTask_ThrowKeyNotFound()
        {
            // попытка апдейтнуть несуществующую таску
            var task = new TaskDto { Title = "Task 2", Priority = Priority.Low, DeadLine = DateTime.Now.AddDays(2) };
            int id = 100;
            Assert.Throws<KeyNotFoundException>(() => _handler.UpdateTask(id, task));
        }

    }

}