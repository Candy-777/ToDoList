using Moq;
using ToDoListApi.Enums;
using WebApi.Handlers;
using WebApi.Interfaces;
using WebApi.Models;
using WebApi.Repositories;
using Xunit;

namespace UnitTest
{
    public class HandlerTestMoq
    {
        private readonly Mock<ITaskRepository> _mockRepository;
        private readonly TaskHandler _handler;

        public HandlerTestMoq()
        {
            _mockRepository = new Mock<ITaskRepository>();
            _handler = new TaskHandler(_mockRepository.Object);
        }

        [Fact]
        public void GetAllTasks_ShouldReturnAllTasks()
        {   
            var tasks = new List<TaskItem>
        {
            new TaskItem { Id = 1, Title = "Task 1" },
            new TaskItem { Id = 2, Title = "Task 2" }
        };
            _mockRepository.Setup(r => r.GetAll()).Returns(tasks);

            // Act
            var result = _handler.GetAllTasks();

            // Assert
            Assert.Equal(tasks, result);
            _mockRepository.Verify(r => r.GetAll(), Times.Once);
        }

        [Fact]
        public void GetTask_ExistingId_ReturnsTask()
        {
            var taskId = 1;
            var tasks = new Dictionary<int, TaskItem>
            {
                { 1, new TaskItem { Id = 1, Title = "Task 1", Priority = Priority.Low, DeadLine = DateTime.Now.AddDays(1) } },
                { 2, new TaskItem { Id = 2, Title = "Task 2", Priority = Priority.Medium, DeadLine = DateTime.Now.AddDays(2) } }
            };                        
            _mockRepository.Setup(repo => repo.Get(It.IsAny<int>())).Returns<int>(id=>
            {
                return tasks[id];
            });

            var taskHandler = new TaskHandler(_mockRepository.Object);

            // Act
            var result = taskHandler.GetTask(taskId);

            // Assert
            Assert.NotNull(result);
            Assert.Equal(taskId, result.Id);
            Assert.Equal("Task 1", result.Title);
        }

        [Fact]
        public void GetTask_NonExistingId_ThrowsKeyNotFoundException()
        {
            // Arrange
            var tasks = new Dictionary<int, TaskItem>
        {
            { 1, new TaskItem { Id = 1, Title = "Task 1", Priority = Priority.Low, DeadLine = DateTime.Now.AddDays(1) } },
            { 2, new TaskItem { Id = 2, Title = "Task 2", Priority = Priority.Medium, DeadLine = DateTime.Now.AddDays(2) } }
        };

            var taskId = 11;

            _mockRepository.Setup(repo => repo.Get(It.IsAny<int>())).Returns<int>(id =>
            {
                if (tasks.ContainsKey(id))
                    return tasks[id];
                throw new KeyNotFoundException();
            });

            // Act & Assert
            Assert.Throws<KeyNotFoundException>(() => _handler.GetTask(taskId));
        }

       
    }      
    
}