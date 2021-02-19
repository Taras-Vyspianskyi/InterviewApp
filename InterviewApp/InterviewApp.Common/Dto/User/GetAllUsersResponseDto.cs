using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Common.Dto.User
{
    public class GetAllUsersResponseDto
    {
        public IEnumerable<Entity.User> Users { get; set; }
    }
}
