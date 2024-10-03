using System;
using AutoMapper;
using LeaveManagementSystem.Data;
using LeaveManagementSystem.Models.LeaveType;

namespace LeaveManagementSystem.MappingProfiles;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<LeaveType, LeaveTypeReadOnlyVM>();
            // .ForMember(dest => dest.Days, opt => opt.MapFrom(src => src.NumberOfDays));
        CreateMap<LeaveTypeCreateVM, LeaveType>();
        CreateMap<LeaveTypeEditVM, LeaveType>().ReverseMap();
    }

}
