using cleanProject.Application.DTOs.LeaveType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDTO
    {
        public  LeaveTypeDTO LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public bool? Approved { get; set; }

    }
}
