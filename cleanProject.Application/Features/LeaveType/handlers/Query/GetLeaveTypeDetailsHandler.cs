using AutoMapper;
using cleanProject.Application.DTOs.LeaveType;
using cleanProject.Application.Features.LeaveType.Requests.Query;
using cleanProject.Application.Persistence.Contracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.Features.LeaveType.handlers.Query
{
    public class GetLeaveTypeDetailsHandler : IRequestHandler<GetLeaveTypeDetailsRequest, LeaveTypeDTO>
    {
        private readonly ILeaveTypeRepository _LeaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeDetailsHandler(ILeaveTypeRepository LeaveTypeRepository, Mapper mapper)
        {
            _LeaveTypeRepository = LeaveTypeRepository;
            _mapper = mapper;

        }
        public async Task<LeaveTypeDTO> Handle(GetLeaveTypeDetailsRequest request, CancellationToken cancellationToken)
        {
            var typeleave = await _LeaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDTO>(typeleave);


        }
    }
}
