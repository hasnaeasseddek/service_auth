using cleanProject.Application.DTOs.LeaveRequest;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.Features.LeaveAllocation.request.Query
{
    public class GetLeaveRequestListQuery : IRequest<List<LeaveRequestDTO>>
    {
    }
}
