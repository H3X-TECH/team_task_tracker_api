using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskService.Domain.Enums;

namespace TaskService.Domain.Entities.Information
{
    public class TaskHistory : BaseEntity
    {
        public string Id { get; set; }
        public string TaskId { get; set; }
        public Status OldStatus { get; set; }
        public Status NewStatus { get; set; }
    }
}
