using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace InterviewApp.Common.Contract.Group
{
    [DataContract]
    public class DeleteGroupApiRequest
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Title { get; set; }
    }
}
