using Domain.Common.Exceptions;
using TaskManager.Domain.Models;

namespace Domain.Common.Validators {
    public class TaskValidator {

        public bool IsValid { get; set; }

        public void TaskValidate(TaskEntity task) {
            if (task == null || string.IsNullOrEmpty(task.Title) || string.IsNullOrEmpty(task.Description)) {
                IsValid = false;
            }
        }
    }
}
