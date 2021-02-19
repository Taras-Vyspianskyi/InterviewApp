using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Common.Contract.Group
{
    public class GetGroupsApiResponse
    {
        public IEnumerable<GetGroupApiResponse> Groups { get; set; }
    }
}
