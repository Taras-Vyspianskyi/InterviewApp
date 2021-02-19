using InterviewApp.Common.Dto;
using InterviewApp.Common.Dto.User;
using InterviewApp.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Common.Service
{
    public interface IUserService
    {
        Task<GetUserResponseDto> GetUserAsync(GetUserRequestDto request);

        Task<GetAllUsersResponseDto> GetAllUsersAsync();

        Task<bool> EditUserAsync(EditUserRequestDto request);

        Task<bool> DeleteUserAsync(DeleteUserRequestDto request);
    }
}
