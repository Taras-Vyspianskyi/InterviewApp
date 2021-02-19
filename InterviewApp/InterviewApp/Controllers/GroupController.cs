using AutoMapper;
using InterviewApp.Common.Contract.Group;
using InterviewApp.Common.Dto.Group;
using InterviewApp.Common.Service;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IGroupService groupService;
        private readonly IMapper mapper;

        public GroupController(IGroupService groupService, IMapper mapper)
        {
            this.groupService = groupService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<GetGroupsApiResponse> GetAllGroups()
        {
            var response = await this.groupService.GetGroupsAsync();

            return new GetGroupsApiResponse
            {
                Groups = response.Groups.Select(u => this.mapper.Map<GetGroupApiResponse>(u))
            };
        }

        [HttpGet]
        public async Task<GetGroupApiResponse> GetGroup(int id)
        {
            var response = await this.groupService.GetGroupAsync(new GetGroupRequestDto { Id = id });

            return this.mapper.Map<GetGroupApiResponse>(response);
        }

        [HttpPut]
        public async Task<IActionResult> EditGroup(EditGroupApiRequest request)
        {
            var response = await this.groupService.EditGroupAsync(this.mapper.Map<EditGroupRequestDto>(request));

            return response ? Ok() : StatusCode(500);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteGroup(DeleteGroupApiRequest request)
        {
            var response = await this.groupService.DeleteGroupAsync(this.mapper.Map<DeleteGroupRequestDto>(request));

            return response ? Ok() : StatusCode(500);
        }
    }
}
