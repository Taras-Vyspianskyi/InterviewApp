using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using InterviewApp.Common.Contract.User;
using InterviewApp.Common.Dto.User;
using InterviewApp.Common.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InterviewApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService userService;
        private readonly IMapper mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<GetAllUsersApiResponse> GetAllUsers()
        {
            var response = await this.userService.GetAllUsersAsync();

            return new GetAllUsersApiResponse
            {
                Users = response.Users.Select(u => this.mapper.Map<GetUserApiResponse>(u))
            };
        }

        [HttpGet]
        public async Task<GetUserApiResponse> GetUser(int id)
        {
            var response = await this.userService.GetUserAsync(new GetUserRequestDto { Id = id });

            return this.mapper.Map<GetUserApiResponse>(response);
        }

        [HttpPut]
        public async Task<IActionResult> EditUser(EditUserApiRequest request)
        {
            var response = await this.userService.EditUserAsync(this.mapper.Map<EditUserRequestDto>(request));

            return response ? Ok() : StatusCode(500);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteUser(DeleteUserApiRequest request)
        {
            var response = await this.userService.DeleteUserAsync(this.mapper.Map<DeleteUserRequestDto>(request));

            return response ? Ok() : StatusCode(500);
        }
    }
}
