using AutoMapper;
using cleanProject.Application.DTOs.LeaveAllocation;
using cleanProject.Application.DTOs.LeaveRequest;
using cleanProject.Application.DTOs.LeaveType;
using cleanProject.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanProject.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveType, LeaveTypeDTO>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDTO>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestDTO>().ReverseMap();
            CreateMap<LeaveAllocation, LeaveAllocationDTO>().ReverseMap();
        }
    }
}
