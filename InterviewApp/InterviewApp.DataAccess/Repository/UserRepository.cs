using InterviewApp.Common.Entity;
using InterviewApp.Common.Repository;
using InterviewApp.DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewApp.DataAccess.Repository
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
