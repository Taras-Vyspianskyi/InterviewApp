using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InterviewApp.Common.Contract.User
{
    [DataContract]
    public class GetAllUsersApiResponse
    {
        [DataMember]
        public IEnumerable<GetUserApiResponse> Users { get; set; }
    }
}
