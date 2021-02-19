using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InterviewApp.Common.Contract.User
{
    [DataContract]
    public class GetUserApiRequest
    {
        [DataMember]
        public int Id { get; set; }
    }
}
