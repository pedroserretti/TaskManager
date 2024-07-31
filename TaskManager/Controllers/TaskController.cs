

using Domain.Common;
using Domain.Common.Exceptions;
using Domain.Common.Validators;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using TaskManager.Domain.Core.Interfaces.IRepositories;
using TaskManager.Domain.Models;

namespace TaskManager.Controllers {

    [ApiController]
    public class TaskController : Controller {
        private readonly IEntityRepository<TaskEntity> _repository;
        private readonly TaskValidator _validator;
        private readonly Result<TaskEntity, TaskValidator> _result = new();


        public TaskController(IEntityRepository<TaskEntity> repository, TaskValidator validator, Result<TaskEntity, TaskValidator> result) {
            _repository = repository;
            _validator = validator;
        }

        [HttpPost]
        public IActionResult CreateTask([FromBody] TaskEntity task) {
            _validator.TaskValidate(task);
            if (!_validator.IsValid) {
                throw new TaskFailedException("The informed has invalid or incorrect data.");
            }

            return _result.Match<IActionResult>(
                s => CreatedAtAction(nameof(GetTask), new { id = task.Id }, task),
                e => BadRequest()
            );
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTask(int id) {
            return Ok();
        }
    }
}
