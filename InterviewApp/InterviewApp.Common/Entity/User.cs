using System.ComponentModel.DataAnnotations.Schema;

namespace InterviewApp.Common.Entity
{
    public class User
    {
        public int Id { get; set; }

        [ForeignKey("Group")]
        public int GroupId { get; set; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }
    }
}
