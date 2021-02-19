using InterviewApp.Common.Dto.Group;
using InterviewApp.Common.Service;
using InterviewApp.Common.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Services.Service
{
    class GroupService : IGroupService
    {
        private readonly IUnitOfWork unitOfWork;

        public GroupService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<GetGroupResponseDto> GetGroupAsync(GetGroupRequestDto request)
        {
            var group = (await this.unitOfWork.GroupRepository.FilterByAsync(x => x.Id == request.Id)).First();

            return new GetGroupResponseDto
            {
                Id = group.Id,
                Title = group.Title,
                Users = group.Users
            };
        }

        public async Task<GetGroupsResponseDto> GetGroupsAsync()
        {
            var groups = await this.unitOfWork.GroupRepository.GetAllAsync();

            return new GetGroupsResponseDto
            {
                Groups = groups
            };
        }

        public async Task<bool> EditGroupAsync(EditGroupRequestDto request)
        {
            try
            {
                this.unitOfWork.GroupRepository.Update(request.Group);

                await this.unitOfWork.SaveAsync();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<bool> DeleteGroupAsync(DeleteGroupRequestDto request)
        {
            try
            {
                this.unitOfWork.GroupRepository.Remove(request.Group);

                var users = await this.unitOfWork.UserRepository.FilterByAsync(g => g.GroupId == request.Group.Id);

                foreach (var user in users)
                {
                    user.GroupId = -1;

                    this.unitOfWork.UserRepository.Update(user);
                }

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
