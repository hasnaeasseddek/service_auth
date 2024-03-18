using AutoMapper;
using cleanProject.Application.DTOs.LeaveRequest;
using cleanProject.Application.Features.LeaveRequest.request.Query;
using cleanProject.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.Features.LeaveRequest.handlers.Query
{
    internal class GetLeaveRequestDetailsHandler : IRequestHandler<GetLeaveRequestDetailsQuery, LeaveRequestDTO>
    {
        private readonly Mapper _mapper;
        private readonly ILeaveRequestRepository _LeaveRequestRepository;
        public GetLeaveRequestDetailsHandler(ILeaveRequestRepository LeaveRequestRepository, Mapper mapper)
        {
            _mapper = mapper;
            _LeaveRequestRepository = LeaveRequestRepository;

        }
        public async Task<LeaveRequestDTO> Handle(GetLeaveRequestDetailsQuery request, CancellationToken cancellationToken)
        {
            var leaverequest = await _LeaveRequestRepository.GetLeaveRequestWithDetails(request.id);
            return _mapper.Map<LeaveRequestDTO>(leaverequest);
        }
    }
}
