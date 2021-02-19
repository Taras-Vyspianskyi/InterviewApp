using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Common.Dto.Group
{
    public class GetGroupResponseDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<Entity.User> Users { get; set; } = new List<Entity.User>();
    }
}
