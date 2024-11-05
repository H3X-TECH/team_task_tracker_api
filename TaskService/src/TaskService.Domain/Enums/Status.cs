using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskService.Domain.Enums
{
    public enum Status
    {
        ToDo = 1,
        InProgress,
        Blocked,
        Complete,
        NeedsRevision,
        Approved,
        FinalComplete,
        Cancelled
    }
}
