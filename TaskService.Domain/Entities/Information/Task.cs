using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskService.Domain.Enums;

namespace TaskService.Domain.Entities.Information
{
    public class Task : BaseEntity
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; } 
        public Status Status { get; set; }
        public string ProjectId { get; set; }
        public string AssignedTo { get; set; }
        public DateTime DueDate { get; set; }
    }
}
