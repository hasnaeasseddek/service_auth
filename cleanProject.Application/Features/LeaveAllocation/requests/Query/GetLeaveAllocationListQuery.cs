using cleanProject.Application.DTOs.LeaveAllocation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.Features.LeaveAllocation.requests.Query
{
    public class GetLeaveAllocationListQuery : IRequest<List<LeaveAllocationDTO>>
    {
    }
}
