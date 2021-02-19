using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Common.Dto.Group
{
    public class GetGroupsResponseDto
    {
        public IEnumerable<Entity.Group> Groups { get; set; }
    }
}
