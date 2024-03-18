using cleanProject.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.DTOs.LeaveType
{
    public class LeaveTypeDTO : BaseDTO
    {
        public string? Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
