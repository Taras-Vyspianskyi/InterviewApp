using InterviewApp.Common.Dto;
using InterviewApp.Common.Dto.User;
using InterviewApp.Common.Entity;
using InterviewApp.Common.Service;
using InterviewApp.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;

        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<GetUserResponseDto> GetUserAsync(GetUserRequestDto request)
        {
            var user = await this.unitOfWork.UserRepository.GetByIdAsync(request.Id);

            return new GetUserResponseDto
            {
                Id = user.Id,
                GroupId = user.GroupId,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                PhoneNumber = user.PhoneNumber
            };
        }

        public async Task<GetAllUsersResponseDto> GetAllUsersAsync()
        {
            var users = await this.unitOfWork.UserRepository.GetAllAsync();

            return new GetAllUsersResponseDto
            { 
                Users = users
            };
        }

        public async Task<bool> EditUserAsync(EditUserRequestDto request)
        {
            try
            {
                this.unitOfWork.UserRepository.Update(request.User);

                await this.unitOfWork.SaveAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteUserAsync(DeleteUserRequestDto request)
        {
            try
            {
                this.unitOfWork.UserRepository.Remove(request.User);

                await this.unitOfWork.SaveAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
