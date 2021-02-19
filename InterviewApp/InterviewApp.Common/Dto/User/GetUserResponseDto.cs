using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Common.Dto.User
{
    public class GetUserResponseDto
    {
        public int Id { get; set; }

        public int GroupId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
    }
}
