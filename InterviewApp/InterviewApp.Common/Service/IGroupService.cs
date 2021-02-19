using InterviewApp.Common.Dto.Group;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace InterviewApp.Common.Service
{
    public interface IGroupService
    {
        Task<GetGroupResponseDto> GetGroupAsync(GetGroupRequestDto request);

        Task<GetGroupsResponseDto> GetGroupsAsync();

        Task<bool> EditGroupAsync(EditGroupRequestDto request);

        Task<bool> DeleteGroupAsync(DeleteGroupRequestDto request);
    }
}
