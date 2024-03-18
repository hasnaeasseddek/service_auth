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
    public class GetLeaveTypeListHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDTO>>
    {
        public GetLeaveTypeListHandler(ILeaveTypeRepository LeaveTypeRepository,Mapper mapper)
        {
            _LeaveTypeRepository = LeaveTypeRepository;
            _mapper = mapper;
            
        }
        private readonly ILeaveTypeRepository _LeaveTypeRepository;
        private readonly IMapper _mapper;
        public async Task<List<LeaveTypeDTO>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _LeaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypeDTO>>(leaveTypes);
        }
    }
}
