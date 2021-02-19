using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.Common.Entity
{
    public class Group
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public List<User> Users { get; set; } = new List<User>();
    }
}
