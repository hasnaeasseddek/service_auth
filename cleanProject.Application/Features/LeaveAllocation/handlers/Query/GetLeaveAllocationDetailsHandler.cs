using AutoMapper;
using cleanProject.Application.DTOs.LeaveAllocation;
using cleanProject.Application.Features.LeaveAllocation.requests.Query;
using cleanProject.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.Features.LeaveAllocation.handlers.Query
{
    public class GetLeaveAllocationDetailsHandler : IRequestHandler<GetLeaveAllocationDetailsQuery, LeaveAllocationDTO>
    {
        public GetLeaveAllocationDetailsHandler(ILeaveAllocationRepository LeaveAllocationRepository, Mapper mapper)
        {
            _LeaveAllocationRepository = LeaveAllocationRepository;
            _mapper = mapper;

        }
        private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
        private readonly IMapper _mapper;
        public async Task<LeaveAllocationDTO> Handle(GetLeaveAllocationDetailsQuery request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _LeaveAllocationRepository.GetLeaveAllocationWithDetails(request.id);
            return _mapper.Map<LeaveAllocationDTO>(leaveAllocation);
        }
    }
}
