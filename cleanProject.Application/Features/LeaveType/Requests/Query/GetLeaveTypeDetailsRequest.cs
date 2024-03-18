﻿using cleanProject.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.Features.LeaveType.Requests.Query
{
    public class GetLeaveTypeDetailsRequest : IRequest<LeaveTypeDTO>
    {
        public int Id { get; set; }
    }
}
