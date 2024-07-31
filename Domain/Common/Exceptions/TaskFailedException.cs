using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.Exceptions {
    public class TaskFailedException : Exception {

        public TaskFailedException(string message) : base(message) { }
    }
}
