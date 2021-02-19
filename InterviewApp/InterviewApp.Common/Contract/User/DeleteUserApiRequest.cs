using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InterviewApp.Common.Contract.User
{
    [DataContract]
    public class DeleteUserApiRequest
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int GroupId { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string PhoneNumber { get; set; }
    }
}
