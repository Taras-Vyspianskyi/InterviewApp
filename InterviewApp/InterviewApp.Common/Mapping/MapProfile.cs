using AutoMapper;
using InterviewApp.Common.Contract.Group;
using InterviewApp.Common.Contract.User;
using InterviewApp.Common.Dto;
using InterviewApp.Common.Dto.Group;
using InterviewApp.Common.Dto.User;
using InterviewApp.Common.Entity;

namespace InterviewApp.Common.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Group, GetGroupApiResponse>();
            CreateMap<GetGroupResponseDto, GetGroupApiResponse>();
            CreateMap<GetGroupApiRequest, GetGroupRequestDto>();
            CreateMap<EditGroupApiRequest, EditGroupRequestDto>();
            CreateMap<DeleteGroupApiRequest, DeleteGroupRequestDto>();

            CreateMap<User, GetUserApiResponse>();
            CreateMap<GetUserResponseDto, GetUserApiResponse>();
            CreateMap<GetUserApiRequest, GetUserRequestDto>();
            CreateMap<EditUserApiRequest, EditUserRequestDto>();
            CreateMap<DeleteUserApiRequest, DeleteUserRequestDto>();
        }
    }
}
