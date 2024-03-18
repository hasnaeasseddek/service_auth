using AutoMapper;
using cleanProject.Application.DTOs.LeaveRequest;
using cleanProject.Application.Features.LeaveAllocation.request.Query;
using cleanProject.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.Features.LeaveAllocation.handlers.Query
{
    public class GetLeaveRequestListHandler : IRequestHandler<GetLeaveRequestListQuery, List<LeaveRequestDTO>>
    {
        private readonly Mapper _mapper;
        private readonly ILeaveRequestRepository _LeaveRequestRepository;
        public GetLeaveRequestListHandler(ILeaveRequestRepository LeaveRequestRepository, Mapper mapper)
        {
            _mapper = mapper;
            _LeaveRequestRepository = LeaveRequestRepository;
            
        }
        public async Task<List<LeaveRequestDTO>> Handle(GetLeaveRequestListQuery request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _LeaveRequestRepository.GetLeaveRequestWithDetails();
            return _mapper.Map<List<LeaveRequestDTO>>(leaveRequests);
        }
    }
}
