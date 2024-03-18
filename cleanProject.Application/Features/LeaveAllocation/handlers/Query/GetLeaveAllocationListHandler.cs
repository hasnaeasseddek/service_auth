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
    public class GetLeaveAllocationListHandler : IRequestHandler<GetLeaveAllocationListQuery, List<LeaveAllocationDTO>>
    {
        public GetLeaveAllocationListHandler(ILeaveAllocationRepository LeaveAllocationRepository, Mapper mapper)
        {
            _LeaveAllocationRepository = LeaveAllocationRepository;
            _mapper = mapper;

        }
        private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
        private readonly IMapper _mapper;
        public async Task<List<LeaveAllocationDTO>> Handle(GetLeaveAllocationListQuery request, CancellationToken cancellationToken)
        {
            var LeaveAllocations = await _LeaveAllocationRepository.GetLeaveAllocationWithDetails();
            return _mapper.Map<List<LeaveAllocationDTO>>(LeaveAllocations);
        }
    }
}
