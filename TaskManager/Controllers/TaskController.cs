

using Microsoft.AspNetCore.Mvc;
using TaskManager.Domain.Core.Interfaces.IRepositories;
using TaskManager.Domain.Models;

namespace TaskManager.Controllers {
    public class TaskController : Controller {
        private readonly IEntityRepository<TaskEntity> _repository;

        public TaskController(IEntityRepository<TaskEntity> repository) {
            _repository = repository;
        }

        [HttpPost("{id}")]
        public IActionResult CreateTask([FromBody] TaskEntity task) {
            if (task == null || string.IsNullOrEmpty(task.Title) || string.IsNullOrEmpty(task.Description)) {
                return BadRequest();
            }

            return Ok();
        }
    }
}
